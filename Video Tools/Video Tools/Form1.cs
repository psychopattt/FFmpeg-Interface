using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Video_Tools
{
    public partial class frmVideoTools : Form
    {
        #region General

        int lastFormWidth = 0;
        const string ffmpegPath = "./ffmpeg/ffmpeg.exe";
        const string ffplayPath = "./ffmpeg/ffplay.exe";

        public frmVideoTools()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            Resize_Form();
            Utils.playButton = btnPlay;
            chkCompressOutputTree.Checked = false;
            Utils.compressButton = btnCompress;
            Utils.lblNbCompressed = lblCompressNbFiles;
            Utils.lblPercentCompressed = lblCompressPercentFiles;
            Utils.progressBar = progressBar;
            Utils.chrono = chrono;
            Utils.timer = timer;

            txtPlayKeybinds.Select(1, 26);
            txtPlayKeybinds.SelectionAlignment = HorizontalAlignment.Center;
            txtPlayKeybinds.SelectionFont = new Font(txtPlayKeybinds.Font.FontFamily, 15, FontStyle.Bold);
            txtPlayKeybinds.Select(0, 0);
        }

        private void Form1_ResizeEnd(object sender, System.EventArgs e)
        {
            Resize_Form();
        }

        private void tabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabs.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(page.BackColor), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, e.Font, paddedBounds, page.ForeColor);
        }

        private void Resize_Form()
        {
            if (lastFormWidth != Width)
            {
                tabs.ItemSize = new Size(tabs.Width / tabs.TabCount - 2, tabs.ItemSize.Height);
                lastFormWidth = Width;
            }
        }

        public static void SetOption(RichTextBox textBox, bool state, string option, string nextOption = "")
        {
            int insertPos;

            if (nextOption == "" || !textBox.Text.Contains(nextOption))
                insertPos = textBox.Text.Length;
            else
                insertPos = textBox.Text.IndexOf(nextOption);

            if (state && !textBox.Text.Contains(" " + option))
                textBox.Text = textBox.Text.Insert(insertPos, " " + option);
            else if (!state)
                textBox.Text = textBox.Text.Replace(" " + option, "");
        }

        private bool FFmpegInstalled(bool ffmpeg)
        {
            string exeName = ffmpeg ? "FFmpeg" : "FFplay";

            if (ffmpeg && !File.Exists(ffmpegPath) || !ffmpeg && !File.Exists(ffplayPath))
            {
                MessageBox.Show(exeName + " needs to be installed in:\n\"exe_folder\\ffmpeg\\" + exeName.ToLower() + ".exe\"", exeName + " missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #endregion

        #region Play

        private void btnPlaySelectVideos_Click(object sender, EventArgs e)
        {
            Utils.SelectFiles(txtPlayFilePath, 0);
        }

        private void btnPlaySelectFolders_Click(object sender, EventArgs e)
        {
            Utils.SelectFolders(txtPlayFilePath, chkPlaySearchSubfolders.Checked, 0);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!FFmpegInstalled(false))
                return;

            Utils.LaunchProcess(txtPlayCommand.Text, txtPlayFilePath.Lines, chkPlayCmdAutoExit.Checked, chkPlaySimultaneousLaunch.Checked);
        }

        private void chkPlayStartFullscreen_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtPlayCommand, ((CheckBox)sender).Checked, "-fs");
        }

        private void chkPlayBorderlessWindow_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtPlayCommand, ((CheckBox)sender).Checked, "-noborder");
        }

        private void chkPlayVideoAutoExit_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtPlayCommand, ((CheckBox)sender).Checked, "-autoexit");
        }

        private void chkPlayAlwaysTop_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtPlayCommand, ((CheckBox)sender).Checked, "-alwaysontop");
        }

        private void chkPlayDisableAudio_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtPlayCommand, ((CheckBox)sender).Checked, "-an");
        }

        private void chkPlayDisableVideo_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtPlayCommand, ((CheckBox)sender).Checked, "-vn");
        }

        private void btnPlayReset_Click(object sender, EventArgs e)
        {
            txtPlayCommand.Text = "ffplay -i \"input\" -hide_banner";
            txtPlayFilePath.Text = "";
            chkPlayCmdAutoExit.Checked = true;
            chkPlayStartFullscreen.Checked = false;
            chkPlayBorderlessWindow.Checked = false;
            chkPlayVideoAutoExit.Checked = false;
            chkPlayAlwaysTop.Checked = false;
            chkPlayDisableAudio.Checked = false;
            chkPlayDisableVideo.Checked = false;
            chkPlaySearchSubfolders.Checked = true;
            chkPlaySimultaneousLaunch.Checked = false;
        }

        #endregion

        #region Compress

        byte mode = 0;
        string lastCompressSpeed = "\"slow\"";
        string lastCompressCrf = "\"25\"";
        string lastCompressRes = "\"scale=-1:1080\"";
        Stopwatch chrono = new Stopwatch();

        private void btnCompressInputFiles_Click(object sender, EventArgs e)
        {
            Utils.SelectFiles(txtCompressInputFiles, 1);
        }

        private void btnCompressInputFolder_Click(object sender, EventArgs e)
        {
            Utils.SelectFolders(txtCompressInputFiles, chkCompressSubFolders.Checked, 1);
        }

        private void btnCompressOutput_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtCompressOutputFolder.Text = "\"" + dialog.SelectedPath + "\"";
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            if (!FFmpegInstalled(true))
                return;

            if (txtCompressDirTreeRoot.Enabled && txtCompressDirTreeRoot.Text.Length > 0)
            {
                if (!txtCompressDirTreeRoot.Text.StartsWith("\""))
                    txtCompressDirTreeRoot.Text = txtCompressDirTreeRoot.Text.Insert(0, "\"");

                if (!txtCompressDirTreeRoot.Text.EndsWith("\""))
                    txtCompressDirTreeRoot.Text = txtCompressDirTreeRoot.Text.Insert(txtCompressDirTreeRoot.Text.Length, "\"");

                txtCompressDirTreeRoot.Text = txtCompressDirTreeRoot.Text.Replace("\\\"", "\"");
            }

            InitProgressStatus(txtCompressInputFiles.Lines.Length);
            Utils.LaunchProcess(txtCompressCommand.Text, txtCompressInputFiles.Lines, chkCompressCmdAutoExit.Checked, chkCompressAutoOverwrite.Checked, txtCompressOutputFolder.Text, chkCompressOutputTree.Checked, txtCompressDirTreeRoot.Text, chkCompressRevertBigger.Checked, chkCompressGenerateReport.Checked);
        }

        private void rbtnCompressSpeed_CheckedChanged(object sender, EventArgs e)
        {
            string newCompressSpeed = '"' + ((RadioButton)sender).Text.ToLower().Replace(" ", "") + '"';
            txtCompressCommand.Text = txtCompressCommand.Text.Replace(lastCompressSpeed, newCompressSpeed);
            lastCompressSpeed = newCompressSpeed;
        }

        private void rbtnCompressCrf_CheckedChanged(object sender, EventArgs e)
        {
            string newCompressCrf;
            txtCompressCustomCrf.Enabled = false;
            Control control = (Control)sender;

            switch (control.Text.ToLower())
            {
                case "lossless":
                    newCompressCrf = "\"18\"";
                    break;
                case "normal":
                    newCompressCrf = "\"25\"";
                    break;
                case "high":
                    newCompressCrf = "\"35\"";
                    break;
                case "max":
                    newCompressCrf = "\"51\"";
                    break;
                default:
                    txtCompressCustomCrf.Enabled = true;
                    newCompressCrf = "\"" + txtCompressCustomCrf.Value + "\"";
                    break;
            }

            txtCompressCommand.Text = txtCompressCommand.Text.Replace(lastCompressCrf, newCompressCrf);
            lastCompressCrf = newCompressCrf;
        }

        private void rbtnCompressResolution_CheckedChanged(object sender, EventArgs e)
        {
            string newCompressRes;
            txtCompressCustomRes.Enabled = false;
            Control control = (Control)sender;

            switch (control.Text.ToLower())
            {
                case "360":
                case "720":
                case "1080":
                    newCompressRes = control.Text;
                    break;
                case "2k":
                    newCompressRes = "1440";
                    break;
                case "4k":
                    newCompressRes = "2160";
                    break;
                default:
                    txtCompressCustomRes.Enabled = true;
                    newCompressRes = txtCompressCustomRes.Value.ToString();
                    break;
            }

            newCompressRes = "\"scale=-1:" + newCompressRes + "\"";
            
            if (chkCompressChangeRes.Checked)
                txtCompressCommand.Text = txtCompressCommand.Text.Replace(lastCompressRes, newCompressRes);
            
            lastCompressRes = newCompressRes;
        }

        private void chkCompressAutoOverwrite_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtCompressCommand, chkCompressAutoOverwrite.Checked, "-y", " \"output\"");
        }

        private void chkCompressAudio_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtCompressCommand, !chkCompressAudio.Checked, "-c:a copy", " \"output\"");
        }

        private void chkCompressChangeRes_CheckedChanged(object sender, EventArgs e)
        {
            SetOption(txtCompressCommand, chkCompressChangeRes.Checked, "-vf " + lastCompressRes, " \"output\"");
        }

        private void chkCompressOutputTree_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                lblCompressDirTreeRoot.Enabled = true;
                txtCompressDirTreeRoot.ReadOnly = false;
                txtCompressDirTreeRoot.ForeColor = Color.FromArgb(224, 224, 224);
            }
            else
            {
                lblCompressDirTreeRoot.Enabled = false;
                txtCompressDirTreeRoot.ReadOnly = true;
                txtCompressDirTreeRoot.ForeColor = Color.Black;
            }
        }

        private void btnCompressResetSettings_Click(object sender, EventArgs e)
        {
            txtCompressInputFiles.Text = "";
            txtCompressOutputFolder.Text = "";
            txtCompressDirTreeRoot.Text = "";
            chkCompressCmdAutoExit.Checked = true;
            chkCompressSubFolders.Checked = true;
            chkCompressOutputTree.Checked = false;
            chkCompressAutoOverwrite.Checked = false;
            chkCompressGenerateReport.Checked = true;
            chkCompressRevertBigger.Checked = true;

            if (mode == 0)
            {
                rbtnCompressNormal.Checked = true;
                rbtnCompressSlow.Checked = true;
                chkCompressAudio.Checked = false;
            }

            if (mode == 0 || mode == 2 || mode == 3)
            {
                chkCompressChangeRes.Checked = true;
                rbtnCompress1080.Checked = true;
            }

            SetCommand();
        }

        private void txtCompressDirTreeRoot_TextChanged(object sender, EventArgs e)
        {
            if (!txtCompressDirTreeRoot.ReadOnly)
            {
                if (txtCompressInputFiles.Text.Length > 0)
                {
                    if (!txtCompressInputFiles.Lines[0].Replace("\"", "").StartsWith(txtCompressDirTreeRoot.Text.Replace("\"", "")))
                        txtCompressDirTreeRoot.ForeColor = Color.Red;
                    else
                        txtCompressDirTreeRoot.ForeColor = Color.FromArgb(224, 224, 224);
                }
                else
                    txtCompressDirTreeRoot.ForeColor = Color.FromArgb(224, 224, 224);
            }
            else
                txtCompressDirTreeRoot.ForeColor = Color.Black;
        }

        private void chkCompressMode_CheckedChanged(object sender, EventArgs e)
        {
            string controlName = ((Control)sender).Text;

            gbCompressResolution.Enabled = true;
            chkCompressChangeRes.Enabled = true;

            if (controlName == "Video")
            {
                mode = 0;
                gbCompressSpeed.Enabled = true;
                gbCompressCompression.Enabled = true;
                chkCompressAudio.Enabled = true;
            }
            else
            {
                gbCompressSpeed.Enabled = false;
                gbCompressCompression.Enabled = false;
                chkCompressAudio.Enabled = false;

                switch (controlName)
                {
                    case "Audio":
                        mode = 1;
                        gbCompressResolution.Enabled = false;
                        chkCompressChangeRes.Enabled = false;
                        break;
                    case ".png":
                        mode = 2;
                        break;
                    case ".jpg":
                        mode = 3;
                        break;
                }
            }

            SetCommand();
            Utils.compressMode = mode;
        }

        private void InitProgressStatus(int nbFiles)
        {
            lblCompressNbFiles.Text = "0 / " + nbFiles + " files";
            lblCompressProgressTimer.Text = "0:00:00:00";
            lblCompressPercentFiles.Text = "0 %";
            progressBar.Value = 0;
            progressBar.Maximum = nbFiles;
            chrono.Start();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan span = chrono.Elapsed;
            lblCompressProgressTimer.Text = string.Format("{0}:{1:00}:{2:00}:{3:00}", span.Days, span.Hours, span.Minutes, span.Seconds);
        }

        private void SetCommand()
        {
            switch (mode)
            {
                case 0: // Video
                    txtCompressCommand.Text = "ffmpeg -i \"input\" -c:v libx265 -preset " + lastCompressSpeed + " -crf " + lastCompressCrf + " -vf " + lastCompressRes + " -c:a copy -hide_banner -nostdin \"output\"";
                    break;
                case 1: // Audio
                    txtCompressCommand.Text = "ffmpeg -i \"input\" -map 0:a:0 -b:a 96k \"output\"";
                    break;
                case 2: // .png
                    txtCompressCommand.Text = "ffmpeg -i \"input\" -vf " + lastCompressRes + " \"output\""; // Automatically compressed as much as possible (lossless)
                    break;
                case 3: // .jpg
                    txtCompressCommand.Text = "ffmpeg -i \"input\" -vf " + lastCompressRes + " -q:v 1 \"output\"";
                    break;
            }

            SetOption(txtCompressCommand, chkCompressAutoOverwrite.Checked, "-y", " \"output\"");
        }

        #endregion
    }
}