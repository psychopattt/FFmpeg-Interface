using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace Video_Tools
{
    public static class Utils
    {
        #region Global Variables

        private static Thread playThread;
        public static Button playButton;

        private static Thread compressThread;
        public static byte compressMode = 0;
        public static Button compressButton;
        public static Label lblNbCompressed;
        public static Label lblPercentCompressed;
        public static ProgressBar progressBar;
        public static Stopwatch chrono;
        public static System.Windows.Forms.Timer timer;

        private static List<string> videoFileFilters = new List<string> { "Video Files|*.mpeg;*.wmv;*.avi;*.mpg;*.mov;*.mp4" };
        private static List<string> audioFileFilters = new List<string> { "Audio Files|*.aac;*.m4a;*.mp3;*.wav" };
        private static List<string> videoFolderFilters = new List<string> { ".mpeg", ".wmv", ".avi", ".mpg", ".mov", ".mp4" };
        private static List<string> audioFolderFilters = new List<string> { ".aac", ".m4a", ".mp3", ".wav" };

        #endregion

        #region Process Handling

        public static void LaunchProcess(string arguments, string[] inputPaths, bool autoExit, bool simultaneousLaunch)
        {
            if (inputPaths.Length == 0 || arguments.Length == 0)
                return;

            EnablePlayButton(false);
            LaunchProcess(0, arguments, inputPaths, " ", autoExit, false, simultaneousLaunch, false, " ", false, false, playThread);
        }

        public static void LaunchProcess(string arguments, string[] inputPaths, bool autoExit, bool autoOverwrite, string outputFolder, bool recreateDirTree, string dirTreeRoot, bool revertBiggerFiles, bool generateReport)
        {
            if (inputPaths.Length == 0 || outputFolder.Length == 0 || arguments.Length == 0)
                return;

            if (dirTreeRoot.Length == 0)
                dirTreeRoot = " ";

            EnableCompressButton(false);
            LaunchProcess(1, arguments, inputPaths, outputFolder, autoExit, autoOverwrite, false, recreateDirTree, dirTreeRoot, revertBiggerFiles, generateReport, compressThread);
        }

        private static void LaunchProcess(byte currentTab, string arguments, string[] inputPaths, string outputFolder, bool autoExit, bool autoOverwrite, bool simultaneousLaunch, bool recreateDirTree, string dirTreeRoot, bool revertBiggerFiles, bool generateReport, Thread thread)
        {
            string autoExitCommand = "";
            outputFolder = outputFolder.Remove(outputFolder.Length - 1);
            dirTreeRoot = dirTreeRoot.Remove(dirTreeRoot.Length - 1);
            ProcessStartInfo processInfo;
            string output = "";
            string command;

            long inputSize = 0;
            long outputSize = 0;
            uint nbRevertedFiles = 0;
            StringBuilder revertedFilesBuilder = new StringBuilder("");
            string extraReportInfo = "";

            if (autoExit)
                autoExitCommand = "& exit /b";

            try
            {
                thread = new Thread(() =>
                {
                    foreach (string readOnlyInput in inputPaths)
                    {
                        string input = readOnlyInput;

                        if (currentTab == 1)
                        {
                            if (recreateDirTree)
                            {
                                if (dirTreeRoot.Length > 0)
                                    output = outputFolder + input.Replace(dirTreeRoot, "");
                                else
                                    output = outputFolder + input.Remove(0, 3);

                                try
                                {
                                    Directory.CreateDirectory(output.Replace("\"", "").Remove(output.LastIndexOf('\\') - 1));
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Invalid directory tree root.\nMake sure that the directory tree root is present in ALL file paths.\nStopping compression...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                            }
                            else
                                output = outputFolder + input.Substring(input.LastIndexOf("\\"));
                        }

                        string compatibleOutput = output.Replace("%", "");

                        command = arguments.Replace("\"input\"", input).Replace("\"output\"", compatibleOutput).Insert(0, ".\\ffmpeg\\");

                        processInfo = new ProcessStartInfo("cmd.exe", $@"/k { command } " + autoExitCommand);
                        processInfo.WindowStyle = ProcessWindowStyle.Minimized;

                        Process process = new Process();
                        process.StartInfo = processInfo;
                        process.Start();

                        if (!simultaneousLaunch)
                        {
                            process.WaitForExit();

                            if (currentTab == 1)
                            {
                                if (revertBiggerFiles || generateReport)
                                {
                                    input = input.Replace("\"", "");
                                    output = output.Replace("\"", "");
                                    compatibleOutput = compatibleOutput.Replace("\"", "");
                                    FileInfo inputInfo = new FileInfo(input);
                                    FileInfo outputInfo = new FileInfo(compatibleOutput);

                                    if (output != compatibleOutput)
                                    {
                                        if (autoOverwrite || !File.Exists(output))
                                        {
                                            outputInfo.CopyTo(output, true);
                                            outputInfo.Delete();
                                            outputInfo = new FileInfo(output);
                                        }
                                        else
                                            extraReportInfo += "Unsupported symbols (\"%\") were removed.\n";
                                    }

                                    if (generateReport)
                                    {
                                        inputSize += inputInfo.Length;
                                        outputSize += outputInfo.Length;
                                    }

                                    if (inputInfo.Length <= outputInfo.Length)
                                    {
                                        if (revertBiggerFiles)
                                        {
                                            File.Copy(input, output, true);

                                            if (generateReport)
                                            {
                                                outputSize -= outputInfo.Length;
                                                outputSize += inputInfo.Length;
                                            }
                                        }

                                        if (generateReport)
                                        {
                                            nbRevertedFiles++;
                                            revertedFilesBuilder.AppendLine(output);
                                        }
                                    }
                                }

                                IncrementProgress();
                            }
                        }
                    }

                    switch (currentTab)
                    {
                        case 0:
                            EnablePlayButton(true);
                            break;
                        case 1:
                            if (generateReport)
                            {
                                if (revertBiggerFiles && nbRevertedFiles > 0)
                                    revertedFilesBuilder.Insert(0, "They were reverted back to the original.\n\n");
                                else
                                    revertedFilesBuilder.Insert(0, "\n");

                                TimeSpan span = chrono.Elapsed;
                                ShowReport(progressBar.Maximum, string.Format("{0}:{1:00}:{2:00}:{3:00}", span.Days, span.Hours, span.Minutes, span.Seconds), inputSize, outputSize, extraReportInfo, nbRevertedFiles, revertedFilesBuilder.ToString());
                            }
                            StopTimer();
                            EnableCompressButton(true);
                            break;
                    }

                    thread.Abort();
                });

                thread.IsBackground = true;
                thread.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Files Handling

        public static void SelectFiles(RichTextBox txtPaths, byte tab)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = GetFilters(false, tab)[0]
            };

            if (dialog.ShowDialog() == DialogResult.OK)
                SetPaths(txtPaths, dialog.FileNames);
        }

        public static void SelectFolders(RichTextBox txtPaths, bool subFolders, byte tab)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (subFolders)
                    SetPaths(txtPaths, GetSubFiles(dialog.SelectedPath, GetFilters(true, tab).ToArray()));
                else
                    SetPaths(txtPaths, Directory.EnumerateFiles(dialog.SelectedPath, "*.*", SearchOption.TopDirectoryOnly).Where(file => GetFilters(true, tab).Any(file.EndsWith)));
            }
        }

        private static void SetPaths(RichTextBox txtPaths, IEnumerable<string> fileNames)
        {
            txtPaths.Text = "";
            StringBuilder builder = new StringBuilder();

            foreach (string file in fileNames)
                builder.Append("\"" + file + "\"\n");

            if (builder.Length > 1)
                builder.Remove(builder.Length - 1, 1);

            txtPaths.Text = builder.ToString();
        }

        private static IEnumerable<string> GetSubFiles(string path, string[] filters)
        {
            Queue<string> pathQueue = new Queue<string>();
            pathQueue.Enqueue(path);

            while (pathQueue.Count > 0)
            {
                path = pathQueue.Dequeue();

                try
                {
                    foreach (string subFolder in Directory.GetDirectories(path))
                        pathQueue.Enqueue(subFolder);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                IEnumerable<string> files = null;

                try
                {
                    files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(file => filters.Any(file.ToLower().EndsWith));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (files != null)
                {
                    for (int i = 0; i < files.Count(); i++)
                    {
                        yield return files.ElementAt(i);
                    }
                }
            }
        }

        #endregion

        #region Other

        private static List<string> GetFilters(bool folderMode, byte tab)
        {
            if (folderMode)
            {
                if (tab == 0)
                {
                    List<string> filters = new List<string> { };
                    filters.AddRange(videoFolderFilters);
                    filters.AddRange(audioFolderFilters);
                    filters.AddRange(new List<string> { ".jpg", ".png", ".gif" });
                    return filters;
                }

                switch (compressMode)
                {
                    case 1:
                        return audioFolderFilters;
                    case 2:
                        return new List<string> { ".png" };
                    case 3:
                        return new List<string> { ".jpg" };
                    default:
                        return videoFolderFilters;
                }
            }
            else
            {
                if (tab == 0)
                {
                    List<string> filters = new List<string> { "Media Files|" };
                    filters[0] += videoFileFilters[0].Substring(videoFileFilters[0].IndexOf('|') + 1) + ";";
                    filters[0] += audioFileFilters[0].Substring(videoFileFilters[0].IndexOf('|') + 1);
                    filters[0] += ";*.jpg;*.png;*.gif";
                    return filters;
                }

                switch (compressMode)
                {
                    case 1:
                        return audioFileFilters;
                    case 2:
                        return new List<string> { "PNG Files|*.png;*.PNG" };
                    case 3:
                        return new List<string> { "JPG Files|*.jpg;*.JPG" };
                    default:
                        return videoFileFilters;
                }
            }
        }

        private static void EnablePlayButton(bool state)
        {
            playButton.BeginInvoke((Action)delegate ()
            {
                playButton.Enabled = state;
            });
        }

        private static void EnableCompressButton(bool state)
        {
            compressButton.BeginInvoke((Action)delegate ()
            {
                compressButton.Enabled = state;
            });
        }

        private static void IncrementProgress()
        {
            compressButton.BeginInvoke((Action)delegate ()
            {
                progressBar.Value++;
                lblNbCompressed.Text = progressBar.Value + lblNbCompressed.Text.Remove(0, lblNbCompressed.Text.IndexOf(" "));
                lblPercentCompressed.Text = Math.Floor((double)progressBar.Value / progressBar.Maximum * 100) + " %";
            });
        }

        private static void StopTimer()
        {
            compressButton.BeginInvoke((Action)delegate ()
            {
                timer.Stop();
                chrono.Reset();
            });
        }

        private static void ShowReport(int nbFiles, string duration, long inputSize, long outputSize, string extraReportInfo, uint nbRevertedFiles, string revertedFiles)
        {
            compressButton.BeginInvoke((Action)delegate ()
            {
                new FrmCompressionReport(nbFiles, duration, inputSize, outputSize, extraReportInfo, nbRevertedFiles, revertedFiles).Show();
            });
        }

        #endregion
    }
}