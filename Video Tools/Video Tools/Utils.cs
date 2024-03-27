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

        private static readonly Thread playThread;
        public static Button playButton;

        private static readonly Thread compressThread;
        public static byte compressMode = 0;
        public static Button compressButton;
        public static Label lblNbCompressed;
        public static Label lblProgressFile;
        public static Label lblPercentCompressed;
        public static ProgressBar progressBar;
        public static Stopwatch chrono;
        public static System.Windows.Forms.Timer timer;

        private static readonly string[] videoFileFilters = { "Video Files|*.mpeg;*.wmv;*.avi;*.mpg;*.mov;*.mp4" };
        private static readonly string[] audioFileFilters = { "Audio Files|*.aac;*.m4a;*.mp3;*.wav" };
        private static readonly string[] videoFolderFilters = { ".mpeg", ".wmv", ".avi", ".mpg", ".mov", ".mp4" };
        private static readonly string[] audioFolderFilters = { ".aac", ".m4a", ".mp3", ".wav" };

        #endregion

        #region Process Handling

        public static string GetExecutablePath(string exeName)
        {
            exeName += ".exe";
            string[] foundExecutables = Directory.GetFiles(Directory.GetCurrentDirectory(), exeName, SearchOption.AllDirectories);

            return foundExecutables.Length > 0 ? foundExecutables[0] : null;
        }

        public static void LaunchProcess(string arguments, string[] inputPaths,
            bool autoExit, bool simultaneousLaunch, bool shuffleFiles)
        {
            if (inputPaths.Length == 0 || arguments.Length == 0)
                return;

            if (shuffleFiles)
                Shuffle(inputPaths);

            EnablePlayButton(false);
            LaunchProcess(0, GetExecutablePath("ffplay"), arguments, inputPaths, " ", autoExit, false,
                simultaneousLaunch, false, " ", false, false, playThread);
        }

        public static void LaunchProcess(string arguments, string[] inputPaths, bool autoExit,bool autoOverwrite,
            string outputFolder, bool recreateDirTree, string dirTreeRoot, bool revertBiggerFiles, bool generateReport)
        {
            if (inputPaths.Length == 0 || outputFolder.Length == 0 || arguments.Length == 0)
                return;

            if (dirTreeRoot.Length == 0)
                dirTreeRoot = " ";

            EnableCompressButton(false);
            LaunchProcess(1, GetExecutablePath("ffmpeg"), arguments, inputPaths, outputFolder, autoExit,
                autoOverwrite, false, recreateDirTree, dirTreeRoot, revertBiggerFiles, generateReport, compressThread);
        }

        private static void LaunchProcess(byte currentTab, string exePath, string arguments, string[] inputPaths,
            string outputFolder, bool autoExit, bool autoOverwrite, bool simultaneousLaunch, bool recreateDirTree,
            string dirTreeRoot, bool revertBiggerFiles, bool generateReport, Thread thread)
        {
            string autoExitCommand = autoExit ? "& exit /b" : "";
            outputFolder = outputFolder.Remove(outputFolder.Length - 1);
            dirTreeRoot = dirTreeRoot.Remove(dirTreeRoot.Length - 1);
            ProcessStartInfo processInfo;
            string output = "";

            long inputSize = 0;
            long outputSize = 0;
            uint nbRevertedFiles = 0;
            StringBuilder revertedFilesBuilder = new StringBuilder();
            StringBuilder failedRevertsBuilder = new StringBuilder();
            string extraReportInfo = "";

            try
            {
                thread = new Thread(() =>
                {
                    foreach (string readOnlyInput in inputPaths)
                    {
                        if (string.IsNullOrWhiteSpace(readOnlyInput))
                            continue;

                        string input = readOnlyInput;

                        if (currentTab == 1)
                        {
                            if (recreateDirTree)
                            {
                                if (dirTreeRoot.Length > 0)
                                    output = outputFolder + input.Replace(dirTreeRoot, "");
                                else
                                    output = outputFolder + input.Remove(0, 3);

                                Directory.CreateDirectory(output.Replace("\"", "").Remove(output.LastIndexOf('\\') - 1));
                            }
                            else
                            {
                                output = outputFolder + input.Substring(input.LastIndexOf("\\"));
                            }
                        }

                        string compatibleOutput = output.Replace("%", "");
                        string command = arguments.Replace("\"input\"", input).Replace("\"output\"", compatibleOutput);
                        command = command.Remove(0, command.IndexOf(' ')).Insert(0, "\"" + exePath + "\"");

                        processInfo = new ProcessStartInfo("cmd.exe", $@"/k { "\"" + command + "\""} " + autoExitCommand);
                        processInfo.WindowStyle = ProcessWindowStyle.Minimized;

                        Process process = new Process();
                        process.StartInfo = processInfo;
                        process.Start();

                        if (currentTab == 1)
                            UpdateCurrentFile(Path.GetFileName(output.Replace("\"", "")));

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
                                            try {
                                                File.Copy(input, output, true);

                                                if (generateReport)
                                                {
                                                    outputSize -= outputInfo.Length;
                                                    outputSize += inputInfo.Length;
                                                    revertedFilesBuilder.AppendLine(output);
                                                }
                                            }
                                            catch {
                                                failedRevertsBuilder.AppendLine(output);
                                            }
                                            finally {
                                                nbRevertedFiles++;
                                            }
                                        }
                                        else if (generateReport)
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
                                {
                                    revertedFilesBuilder.Insert(0, "They were reverted back to the original.\n\n");

                                    if (failedRevertsBuilder.Length > 0)
                                        failedRevertsBuilder.Insert(0, "Some files could not be reverted.\n\n");
                                }
                                else
                                {
                                    revertedFilesBuilder.Insert(0, "\n");
                                }

                                TimeSpan span = chrono.Elapsed;

                                ShowReport(
                                    progressBar.Maximum,
                                    string.Format("{0}:{1:00}:{2:00}:{3:00}", span.Days, span.Hours, span.Minutes, span.Seconds),
                                    inputSize, outputSize, extraReportInfo, nbRevertedFiles,revertedFilesBuilder.ToString(),
                                    failedRevertsBuilder.ToString()
                                );
                            }

                            StopTimer();
                            UpdateCurrentFile("");
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
                MessageBox.Show(
                    "Critical error encountered\n" + exception.Message, 
                    "Process Error", MessageBoxButtons.OK, MessageBoxIcon.Error
               );
            }
        }

        #endregion

        #region Files Handling

        public static bool PathStartsWithSubPath(string path, string subPath)
        {
            return path.Replace("\"", "").StartsWith(subPath.Replace("\"", ""));
        }

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
                    MessageBox.Show(exception.Message, "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                IEnumerable<string> files = null;

                try
                {
                    files = Directory.EnumerateFiles(path, "*.*", SearchOption.TopDirectoryOnly).Where(file => filters.Any(file.ToLower().EndsWith));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private static string[] GetFilters(bool folderMode, byte tab)
        {
            if (folderMode)
            {
                if (tab == 0)
                {
                    List<string> filters = new List<string> { };
                    filters.AddRange(videoFolderFilters);
                    filters.AddRange(audioFolderFilters);
                    filters.AddRange(new List<string> { ".jpg", ".png", ".gif" });
                    return filters.ToArray();
                }

                switch (compressMode)
                {
                    case 1:
                        return audioFolderFilters;
                    case 2:
                        return new string[] { ".png" };
                    case 3:
                        return new string[] { ".jpg" };
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
                    return filters.ToArray();
                }

                switch (compressMode)
                {
                    case 1:
                        return audioFileFilters;
                    case 2:
                        return new string[] { "PNG Files|*.png;*.PNG" };
                    case 3:
                        return new string[] { "JPG Files|*.jpg;*.JPG" };
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

        private static void UpdateCurrentFile(string currentFile)
        {
            lblProgressFile.BeginInvoke((Action)delegate () {
                lblProgressFile.Text = currentFile;
            });
        }

        private static void IncrementProgress()
        {
            compressButton.BeginInvoke((Action)delegate ()
            {
                progressBar.Value++;
                lblNbCompressed.Text = progressBar.Value + lblNbCompressed.Text.Remove(0, lblNbCompressed.Text.IndexOf(" "));
                lblPercentCompressed.Text = Math.Floor((double)progressBar.Value / progressBar.Maximum * 100) + "%";
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

        private static void ShowReport(int nbFiles, string duration, long inputSize, long outputSize,
            string extraReportInfo, uint nbRevertedFiles, string revertedFiles, string failedReverts)
        {
            compressButton.BeginInvoke((Action)delegate ()
            {
                FrmCompressionReport compressionReport = new FrmCompressionReport(
                    nbFiles, duration, inputSize, outputSize, extraReportInfo,
                    nbRevertedFiles, revertedFiles, failedReverts
                );

                compressionReport.Show(Application.OpenForms[0]);
            });
        }

        private static void Shuffle<T>(T[] values)
        {
            Random random = new Random();
            int currentIndex = values.Length;

            while (currentIndex > 1)
            {
                int newIndex = random.Next(currentIndex--);
                (values[newIndex], values[currentIndex]) = (values[currentIndex], values[newIndex]);
            }
        }

        #endregion
    }
}