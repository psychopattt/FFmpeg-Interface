
namespace Video_Tools
{
    partial class frmVideoTools
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Generated Code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVideoTools));
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPlay = new System.Windows.Forms.TabPage();
            this.tblPlayMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlayKeybinds = new System.Windows.Forms.RichTextBox();
            this.tblPlayControls = new System.Windows.Forms.TableLayoutPanel();
            this.txtPlayFilePath = new System.Windows.Forms.RichTextBox();
            this.txtPlayCommand = new System.Windows.Forms.RichTextBox();
            this.pannelPlayOptions = new System.Windows.Forms.Panel();
            this.chkPlaySimultaneousLaunch = new System.Windows.Forms.CheckBox();
            this.chkPlaySearchSubfolders = new System.Windows.Forms.CheckBox();
            this.chkPlayDisableVideo = new System.Windows.Forms.CheckBox();
            this.chkPlayDisableAudio = new System.Windows.Forms.CheckBox();
            this.chkPlayVideoAutoExit = new System.Windows.Forms.CheckBox();
            this.chkPlayAlwaysTop = new System.Windows.Forms.CheckBox();
            this.chkPlayBorderlessWindow = new System.Windows.Forms.CheckBox();
            this.chkPlayStartFullscreen = new System.Windows.Forms.CheckBox();
            this.chkPlayCmdAutoExit = new System.Windows.Forms.CheckBox();
            this.tblPlaySelectVideos = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlaySelectFolder = new System.Windows.Forms.Button();
            this.btnPlaySelectVideos = new System.Windows.Forms.Button();
            this.tblPlayReset = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlayReset = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tabCompress = new System.Windows.Forms.TabPage();
            this.tblCompressMain = new System.Windows.Forms.TableLayoutPanel();
            this.txtCompressCommand = new System.Windows.Forms.RichTextBox();
            this.tblCompressInputsOutputs = new System.Windows.Forms.TableLayoutPanel();
            this.lblCompressDirTreeRoot = new System.Windows.Forms.Label();
            this.txtCompressDirTreeRoot = new System.Windows.Forms.RichTextBox();
            this.txtCompressInputFiles = new System.Windows.Forms.RichTextBox();
            this.txtCompressOutputFolder = new System.Windows.Forms.RichTextBox();
            this.btnCompressOutput = new System.Windows.Forms.Button();
            this.btnCompressInputFolder = new System.Windows.Forms.Button();
            this.btnCompressInputFiles = new System.Windows.Forms.Button();
            this.tblCompressOptions = new System.Windows.Forms.TableLayoutPanel();
            this.gbCompressCompression = new System.Windows.Forms.GroupBox();
            this.txtCompressCustomCrf = new System.Windows.Forms.NumericUpDown();
            this.rbtnCompressMax = new System.Windows.Forms.RadioButton();
            this.rbtnCompressCustomCrf = new System.Windows.Forms.RadioButton();
            this.rbtnCompressHigh = new System.Windows.Forms.RadioButton();
            this.rbtnCompressNormal = new System.Windows.Forms.RadioButton();
            this.rbtnCompressLossless = new System.Windows.Forms.RadioButton();
            this.gbCompressSpeed = new System.Windows.Forms.GroupBox();
            this.rbtnCompressVerySlow = new System.Windows.Forms.RadioButton();
            this.rbtnCompressSlower = new System.Windows.Forms.RadioButton();
            this.rbtnCompressSlow = new System.Windows.Forms.RadioButton();
            this.rbtnCompressMedium = new System.Windows.Forms.RadioButton();
            this.rbtnCompressFast = new System.Windows.Forms.RadioButton();
            this.rbtnCompressVeryFast = new System.Windows.Forms.RadioButton();
            this.rbtnCompressSuperFast = new System.Windows.Forms.RadioButton();
            this.rbtnCompressUltraFast = new System.Windows.Forms.RadioButton();
            this.gbCompressResolution = new System.Windows.Forms.GroupBox();
            this.txtCompressCustomRes = new System.Windows.Forms.NumericUpDown();
            this.rbtnCompress4K = new System.Windows.Forms.RadioButton();
            this.rbtnCompressCustomRes = new System.Windows.Forms.RadioButton();
            this.rbtnCompress2K = new System.Windows.Forms.RadioButton();
            this.rbtnCompress1080 = new System.Windows.Forms.RadioButton();
            this.rbtnCompress720 = new System.Windows.Forms.RadioButton();
            this.rbtnCompress360 = new System.Windows.Forms.RadioButton();
            this.tblCompress = new System.Windows.Forms.TableLayoutPanel();
            this.btnCompress = new System.Windows.Forms.Button();
            this.tblCompressCompletionStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblCompressProgressTimer = new System.Windows.Forms.Label();
            this.lblCompressNbFiles = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblCompressPercentFiles = new System.Windows.Forms.Label();
            this.tblCompressOther = new System.Windows.Forms.TableLayoutPanel();
            this.gbCompressMode = new System.Windows.Forms.GroupBox();
            this.chkCompressModeJpg = new System.Windows.Forms.RadioButton();
            this.chkCompressModePng = new System.Windows.Forms.RadioButton();
            this.chkCompressModeAudio = new System.Windows.Forms.RadioButton();
            this.chkCompressModeVideo = new System.Windows.Forms.RadioButton();
            this.btnCompressResetSettings = new System.Windows.Forms.Button();
            this.gbCompressOther = new System.Windows.Forms.GroupBox();
            this.chkCompressChangeRes = new System.Windows.Forms.CheckBox();
            this.chkCompressGenerateReport = new System.Windows.Forms.CheckBox();
            this.chkCompressRevertBigger = new System.Windows.Forms.CheckBox();
            this.chkCompressOutputTree = new System.Windows.Forms.CheckBox();
            this.chkCompressAudio = new System.Windows.Forms.CheckBox();
            this.chkCompressAutoOverwrite = new System.Windows.Forms.CheckBox();
            this.chkCompressCmdAutoExit = new System.Windows.Forms.CheckBox();
            this.chkCompressSubFolders = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabs.SuspendLayout();
            this.tabPlay.SuspendLayout();
            this.tblPlayMain.SuspendLayout();
            this.tblPlayControls.SuspendLayout();
            this.pannelPlayOptions.SuspendLayout();
            this.tblPlaySelectVideos.SuspendLayout();
            this.tblPlayReset.SuspendLayout();
            this.tabCompress.SuspendLayout();
            this.tblCompressMain.SuspendLayout();
            this.tblCompressInputsOutputs.SuspendLayout();
            this.tblCompressOptions.SuspendLayout();
            this.gbCompressCompression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompressCustomCrf)).BeginInit();
            this.gbCompressSpeed.SuspendLayout();
            this.gbCompressResolution.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompressCustomRes)).BeginInit();
            this.tblCompress.SuspendLayout();
            this.tblCompressCompletionStatus.SuspendLayout();
            this.tblCompressOther.SuspendLayout();
            this.gbCompressMode.SuspendLayout();
            this.gbCompressOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPlay);
            this.tabs.Controls.Add(this.tabCompress);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.ItemSize = new System.Drawing.Size(150, 30);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1264, 681);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 0;
            this.tabs.TabStop = false;
            this.tabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabs_DrawItem);
            // 
            // tabPlay
            // 
            this.tabPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabPlay.Controls.Add(this.tblPlayMain);
            this.tabPlay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabPlay.Location = new System.Drawing.Point(4, 34);
            this.tabPlay.Name = "tabPlay";
            this.tabPlay.Size = new System.Drawing.Size(1256, 643);
            this.tabPlay.TabIndex = 2;
            this.tabPlay.Text = "Play";
            // 
            // tblPlayMain
            // 
            this.tblPlayMain.ColumnCount = 2;
            this.tblPlayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 580F));
            this.tblPlayMain.Controls.Add(this.txtPlayKeybinds, 1, 0);
            this.tblPlayMain.Controls.Add(this.tblPlayControls, 0, 0);
            this.tblPlayMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlayMain.Location = new System.Drawing.Point(0, 0);
            this.tblPlayMain.Name = "tblPlayMain";
            this.tblPlayMain.RowCount = 1;
            this.tblPlayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayMain.Size = new System.Drawing.Size(1256, 643);
            this.tblPlayMain.TabIndex = 1;
            // 
            // txtPlayKeybinds
            // 
            this.txtPlayKeybinds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPlayKeybinds.DetectUrls = false;
            this.txtPlayKeybinds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayKeybinds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPlayKeybinds.Location = new System.Drawing.Point(676, 0);
            this.txtPlayKeybinds.Margin = new System.Windows.Forms.Padding(0);
            this.txtPlayKeybinds.Name = "txtPlayKeybinds";
            this.txtPlayKeybinds.ReadOnly = true;
            this.txtPlayKeybinds.Size = new System.Drawing.Size(580, 643);
            this.txtPlayKeybinds.TabIndex = 1;
            this.txtPlayKeybinds.TabStop = false;
            this.txtPlayKeybinds.Text = resources.GetString("txtPlayKeybinds.Text");
            // 
            // tblPlayControls
            // 
            this.tblPlayControls.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblPlayControls.ColumnCount = 1;
            this.tblPlayControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayControls.Controls.Add(this.txtPlayFilePath, 0, 1);
            this.tblPlayControls.Controls.Add(this.txtPlayCommand, 0, 3);
            this.tblPlayControls.Controls.Add(this.pannelPlayOptions, 0, 2);
            this.tblPlayControls.Controls.Add(this.tblPlaySelectVideos, 0, 0);
            this.tblPlayControls.Controls.Add(this.tblPlayReset, 0, 4);
            this.tblPlayControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlayControls.Location = new System.Drawing.Point(3, 3);
            this.tblPlayControls.Name = "tblPlayControls";
            this.tblPlayControls.RowCount = 5;
            this.tblPlayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblPlayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblPlayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblPlayControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblPlayControls.Size = new System.Drawing.Size(670, 637);
            this.tblPlayControls.TabIndex = 1;
            // 
            // txtPlayFilePath
            // 
            this.txtPlayFilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPlayFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayFilePath.DetectUrls = false;
            this.txtPlayFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPlayFilePath.Location = new System.Drawing.Point(4, 85);
            this.txtPlayFilePath.Name = "txtPlayFilePath";
            this.txtPlayFilePath.Size = new System.Drawing.Size(662, 185);
            this.txtPlayFilePath.TabIndex = 3;
            this.txtPlayFilePath.Text = "";
            // 
            // txtPlayCommand
            // 
            this.txtPlayCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPlayCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlayCommand.DetectUrls = false;
            this.txtPlayCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPlayCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPlayCommand.Location = new System.Drawing.Point(4, 418);
            this.txtPlayCommand.Name = "txtPlayCommand";
            this.txtPlayCommand.Size = new System.Drawing.Size(662, 114);
            this.txtPlayCommand.TabIndex = 13;
            this.txtPlayCommand.Text = "ffplay -i \"input\" -hide_banner";
            // 
            // pannelPlayOptions
            // 
            this.pannelPlayOptions.Controls.Add(this.chkPlaySimultaneousLaunch);
            this.pannelPlayOptions.Controls.Add(this.chkPlaySearchSubfolders);
            this.pannelPlayOptions.Controls.Add(this.chkPlayDisableVideo);
            this.pannelPlayOptions.Controls.Add(this.chkPlayDisableAudio);
            this.pannelPlayOptions.Controls.Add(this.chkPlayVideoAutoExit);
            this.pannelPlayOptions.Controls.Add(this.chkPlayAlwaysTop);
            this.pannelPlayOptions.Controls.Add(this.chkPlayBorderlessWindow);
            this.pannelPlayOptions.Controls.Add(this.chkPlayStartFullscreen);
            this.pannelPlayOptions.Controls.Add(this.chkPlayCmdAutoExit);
            this.pannelPlayOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pannelPlayOptions.Location = new System.Drawing.Point(4, 277);
            this.pannelPlayOptions.Name = "pannelPlayOptions";
            this.pannelPlayOptions.Size = new System.Drawing.Size(662, 134);
            this.pannelPlayOptions.TabIndex = 3;
            // 
            // chkPlaySimultaneousLaunch
            // 
            this.chkPlaySimultaneousLaunch.AutoSize = true;
            this.chkPlaySimultaneousLaunch.Location = new System.Drawing.Point(447, 96);
            this.chkPlaySimultaneousLaunch.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlaySimultaneousLaunch.Name = "chkPlaySimultaneousLaunch";
            this.chkPlaySimultaneousLaunch.Size = new System.Drawing.Size(199, 23);
            this.chkPlaySimultaneousLaunch.TabIndex = 12;
            this.chkPlaySimultaneousLaunch.Text = "Simultaneous Launch";
            this.toolTip.SetToolTip(this.chkPlaySimultaneousLaunch, "Open all files at the same time");
            this.chkPlaySimultaneousLaunch.UseVisualStyleBackColor = true;
            // 
            // chkPlaySearchSubfolders
            // 
            this.chkPlaySearchSubfolders.AutoSize = true;
            this.chkPlaySearchSubfolders.Checked = true;
            this.chkPlaySearchSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlaySearchSubfolders.Location = new System.Drawing.Point(447, 10);
            this.chkPlaySearchSubfolders.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlaySearchSubfolders.Name = "chkPlaySearchSubfolders";
            this.chkPlaySearchSubfolders.Size = new System.Drawing.Size(181, 23);
            this.chkPlaySearchSubfolders.TabIndex = 6;
            this.chkPlaySearchSubfolders.Text = "Search Subfolders";
            this.toolTip.SetToolTip(this.chkPlaySearchSubfolders, "Search all subfolders when using \"Select Folder\"");
            this.chkPlaySearchSubfolders.UseVisualStyleBackColor = true;
            // 
            // chkPlayDisableVideo
            // 
            this.chkPlayDisableVideo.AutoSize = true;
            this.chkPlayDisableVideo.Location = new System.Drawing.Point(10, 96);
            this.chkPlayDisableVideo.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlayDisableVideo.Name = "chkPlayDisableVideo";
            this.chkPlayDisableVideo.Size = new System.Drawing.Size(145, 23);
            this.chkPlayDisableVideo.TabIndex = 10;
            this.chkPlayDisableVideo.Text = "Disable Video";
            this.chkPlayDisableVideo.UseVisualStyleBackColor = true;
            this.chkPlayDisableVideo.CheckedChanged += new System.EventHandler(this.chkPlayDisableVideo_CheckedChanged);
            // 
            // chkPlayDisableAudio
            // 
            this.chkPlayDisableAudio.AutoSize = true;
            this.chkPlayDisableAudio.Location = new System.Drawing.Point(224, 96);
            this.chkPlayDisableAudio.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlayDisableAudio.Name = "chkPlayDisableAudio";
            this.chkPlayDisableAudio.Size = new System.Drawing.Size(145, 23);
            this.chkPlayDisableAudio.TabIndex = 11;
            this.chkPlayDisableAudio.Text = "Disable Audio";
            this.chkPlayDisableAudio.UseVisualStyleBackColor = true;
            this.chkPlayDisableAudio.CheckedChanged += new System.EventHandler(this.chkPlayDisableAudio_CheckedChanged);
            // 
            // chkPlayVideoAutoExit
            // 
            this.chkPlayVideoAutoExit.AutoSize = true;
            this.chkPlayVideoAutoExit.Location = new System.Drawing.Point(224, 10);
            this.chkPlayVideoAutoExit.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlayVideoAutoExit.Name = "chkPlayVideoAutoExit";
            this.chkPlayVideoAutoExit.Size = new System.Drawing.Size(163, 23);
            this.chkPlayVideoAutoExit.TabIndex = 5;
            this.chkPlayVideoAutoExit.Text = "Auto Exit Files";
            this.toolTip.SetToolTip(this.chkPlayVideoAutoExit, "Exit files as soon as they are done playing");
            this.chkPlayVideoAutoExit.UseVisualStyleBackColor = true;
            this.chkPlayVideoAutoExit.CheckedChanged += new System.EventHandler(this.chkPlayVideoAutoExit_CheckedChanged);
            // 
            // chkPlayAlwaysTop
            // 
            this.chkPlayAlwaysTop.AutoSize = true;
            this.chkPlayAlwaysTop.Location = new System.Drawing.Point(447, 53);
            this.chkPlayAlwaysTop.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlayAlwaysTop.Name = "chkPlayAlwaysTop";
            this.chkPlayAlwaysTop.Size = new System.Drawing.Size(145, 23);
            this.chkPlayAlwaysTop.TabIndex = 9;
            this.chkPlayAlwaysTop.Text = "Always On Top";
            this.chkPlayAlwaysTop.UseVisualStyleBackColor = true;
            this.chkPlayAlwaysTop.CheckedChanged += new System.EventHandler(this.chkPlayAlwaysTop_CheckedChanged);
            // 
            // chkPlayBorderlessWindow
            // 
            this.chkPlayBorderlessWindow.AutoSize = true;
            this.chkPlayBorderlessWindow.Location = new System.Drawing.Point(224, 53);
            this.chkPlayBorderlessWindow.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlayBorderlessWindow.Name = "chkPlayBorderlessWindow";
            this.chkPlayBorderlessWindow.Size = new System.Drawing.Size(181, 23);
            this.chkPlayBorderlessWindow.TabIndex = 8;
            this.chkPlayBorderlessWindow.Text = "Borderless Window";
            this.chkPlayBorderlessWindow.UseVisualStyleBackColor = true;
            this.chkPlayBorderlessWindow.CheckedChanged += new System.EventHandler(this.chkPlayBorderlessWindow_CheckedChanged);
            // 
            // chkPlayStartFullscreen
            // 
            this.chkPlayStartFullscreen.AutoSize = true;
            this.chkPlayStartFullscreen.Location = new System.Drawing.Point(10, 53);
            this.chkPlayStartFullscreen.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlayStartFullscreen.Name = "chkPlayStartFullscreen";
            this.chkPlayStartFullscreen.Size = new System.Drawing.Size(172, 23);
            this.chkPlayStartFullscreen.TabIndex = 7;
            this.chkPlayStartFullscreen.Text = "Start Fullscreen";
            this.chkPlayStartFullscreen.UseVisualStyleBackColor = true;
            this.chkPlayStartFullscreen.CheckedChanged += new System.EventHandler(this.chkPlayStartFullscreen_CheckedChanged);
            // 
            // chkPlayCmdAutoExit
            // 
            this.chkPlayCmdAutoExit.AutoSize = true;
            this.chkPlayCmdAutoExit.Checked = true;
            this.chkPlayCmdAutoExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayCmdAutoExit.Location = new System.Drawing.Point(10, 10);
            this.chkPlayCmdAutoExit.Margin = new System.Windows.Forms.Padding(10);
            this.chkPlayCmdAutoExit.Name = "chkPlayCmdAutoExit";
            this.chkPlayCmdAutoExit.Size = new System.Drawing.Size(145, 23);
            this.chkPlayCmdAutoExit.TabIndex = 4;
            this.chkPlayCmdAutoExit.Text = "Auto Exit CMD";
            this.toolTip.SetToolTip(this.chkPlayCmdAutoExit, "Close command prompts when their files are closed");
            this.chkPlayCmdAutoExit.UseVisualStyleBackColor = true;
            // 
            // tblPlaySelectVideos
            // 
            this.tblPlaySelectVideos.ColumnCount = 2;
            this.tblPlaySelectVideos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlaySelectVideos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPlaySelectVideos.Controls.Add(this.btnPlaySelectFolder, 0, 0);
            this.tblPlaySelectVideos.Controls.Add(this.btnPlaySelectVideos, 0, 0);
            this.tblPlaySelectVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlaySelectVideos.Location = new System.Drawing.Point(4, 4);
            this.tblPlaySelectVideos.Name = "tblPlaySelectVideos";
            this.tblPlaySelectVideos.RowCount = 1;
            this.tblPlaySelectVideos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblPlaySelectVideos.Size = new System.Drawing.Size(662, 74);
            this.tblPlaySelectVideos.TabIndex = 2;
            // 
            // btnPlaySelectFolder
            // 
            this.btnPlaySelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPlaySelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlaySelectFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPlaySelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaySelectFolder.Location = new System.Drawing.Point(334, 3);
            this.btnPlaySelectFolder.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnPlaySelectFolder.Name = "btnPlaySelectFolder";
            this.btnPlaySelectFolder.Size = new System.Drawing.Size(325, 69);
            this.btnPlaySelectFolder.TabIndex = 2;
            this.btnPlaySelectFolder.Text = "Select Folder";
            this.btnPlaySelectFolder.UseVisualStyleBackColor = false;
            this.btnPlaySelectFolder.Click += new System.EventHandler(this.btnPlaySelectFolders_Click);
            // 
            // btnPlaySelectVideos
            // 
            this.btnPlaySelectVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPlaySelectVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlaySelectVideos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPlaySelectVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaySelectVideos.Location = new System.Drawing.Point(3, 3);
            this.btnPlaySelectVideos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.btnPlaySelectVideos.Name = "btnPlaySelectVideos";
            this.btnPlaySelectVideos.Size = new System.Drawing.Size(325, 69);
            this.btnPlaySelectVideos.TabIndex = 1;
            this.btnPlaySelectVideos.Text = "Select File(s)";
            this.btnPlaySelectVideos.UseVisualStyleBackColor = false;
            this.btnPlaySelectVideos.Click += new System.EventHandler(this.btnPlaySelectVideos_Click);
            // 
            // tblPlayReset
            // 
            this.tblPlayReset.ColumnCount = 2;
            this.tblPlayReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblPlayReset.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblPlayReset.Controls.Add(this.btnPlayReset, 0, 0);
            this.tblPlayReset.Controls.Add(this.btnPlay, 0, 0);
            this.tblPlayReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlayReset.Location = new System.Drawing.Point(4, 539);
            this.tblPlayReset.Name = "tblPlayReset";
            this.tblPlayReset.RowCount = 1;
            this.tblPlayReset.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayReset.Size = new System.Drawing.Size(662, 94);
            this.tblPlayReset.TabIndex = 14;
            // 
            // btnPlayReset
            // 
            this.btnPlayReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPlayReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlayReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPlayReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayReset.Location = new System.Drawing.Point(466, 3);
            this.btnPlayReset.Name = "btnPlayReset";
            this.btnPlayReset.Size = new System.Drawing.Size(193, 88);
            this.btnPlayReset.TabIndex = 15;
            this.btnPlayReset.Text = "Reset Settings";
            this.btnPlayReset.UseVisualStyleBackColor = false;
            this.btnPlayReset.Click += new System.EventHandler(this.btnPlayReset_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(457, 88);
            this.btnPlay.TabIndex = 14;
            this.btnPlay.Text = "Play File(s)";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tabCompress
            // 
            this.tabCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tabCompress.Controls.Add(this.tblCompressMain);
            this.tabCompress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabCompress.Location = new System.Drawing.Point(4, 34);
            this.tabCompress.Name = "tabCompress";
            this.tabCompress.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompress.Size = new System.Drawing.Size(1256, 643);
            this.tabCompress.TabIndex = 0;
            this.tabCompress.Text = "Compress";
            // 
            // tblCompressMain
            // 
            this.tblCompressMain.ColumnCount = 1;
            this.tblCompressMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCompressMain.Controls.Add(this.txtCompressCommand, 0, 3);
            this.tblCompressMain.Controls.Add(this.tblCompressInputsOutputs, 0, 0);
            this.tblCompressMain.Controls.Add(this.tblCompressOptions, 0, 1);
            this.tblCompressMain.Controls.Add(this.tblCompress, 0, 4);
            this.tblCompressMain.Controls.Add(this.tblCompressOther, 0, 2);
            this.tblCompressMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCompressMain.Location = new System.Drawing.Point(3, 3);
            this.tblCompressMain.Name = "tblCompressMain";
            this.tblCompressMain.RowCount = 5;
            this.tblCompressMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblCompressMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblCompressMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblCompressMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCompressMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tblCompressMain.Size = new System.Drawing.Size(1250, 637);
            this.tblCompressMain.TabIndex = 0;
            // 
            // txtCompressCommand
            // 
            this.txtCompressCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCompressCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblCompressMain.SetColumnSpan(this.txtCompressCommand, 2);
            this.txtCompressCommand.DetectUrls = false;
            this.txtCompressCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompressCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCompressCommand.Location = new System.Drawing.Point(6, 460);
            this.txtCompressCommand.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.txtCompressCommand.Name = "txtCompressCommand";
            this.txtCompressCommand.Size = new System.Drawing.Size(1238, 68);
            this.txtCompressCommand.TabIndex = 11;
            this.txtCompressCommand.Text = "ffmpeg -i \"input\" -c:v libx265 -preset \"slow\" -crf \"25\" -vf \"scale=-1:1080\" -c:a " +
    "copy -hide_banner -nostdin \"output\"";
            // 
            // tblCompressInputsOutputs
            // 
            this.tblCompressInputsOutputs.ColumnCount = 3;
            this.tblCompressInputsOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tblCompressInputsOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tblCompressInputsOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.tblCompressInputsOutputs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCompressInputsOutputs.Controls.Add(this.lblCompressDirTreeRoot, 0, 2);
            this.tblCompressInputsOutputs.Controls.Add(this.txtCompressDirTreeRoot, 0, 3);
            this.tblCompressInputsOutputs.Controls.Add(this.txtCompressInputFiles, 0, 1);
            this.tblCompressInputsOutputs.Controls.Add(this.txtCompressOutputFolder, 2, 1);
            this.tblCompressInputsOutputs.Controls.Add(this.btnCompressOutput, 2, 0);
            this.tblCompressInputsOutputs.Controls.Add(this.btnCompressInputFolder, 1, 0);
            this.tblCompressInputsOutputs.Controls.Add(this.btnCompressInputFiles, 0, 0);
            this.tblCompressInputsOutputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCompressInputsOutputs.Location = new System.Drawing.Point(3, 3);
            this.tblCompressInputsOutputs.Name = "tblCompressInputsOutputs";
            this.tblCompressInputsOutputs.RowCount = 4;
            this.tblCompressInputsOutputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblCompressInputsOutputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tblCompressInputsOutputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCompressInputsOutputs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblCompressInputsOutputs.Size = new System.Drawing.Size(1244, 246);
            this.tblCompressInputsOutputs.TabIndex = 1;
            // 
            // lblCompressDirTreeRoot
            // 
            this.lblCompressDirTreeRoot.AutoSize = true;
            this.lblCompressDirTreeRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompressDirTreeRoot.Location = new System.Drawing.Point(799, 160);
            this.lblCompressDirTreeRoot.Name = "lblCompressDirTreeRoot";
            this.lblCompressDirTreeRoot.Size = new System.Drawing.Size(442, 20);
            this.lblCompressDirTreeRoot.TabIndex = 9;
            this.lblCompressDirTreeRoot.Text = "Directory Tree Root:";
            this.lblCompressDirTreeRoot.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip.SetToolTip(this.lblCompressDirTreeRoot, "Remove this string from all file paths when using \"Recreate Dir Tree\"");
            // 
            // txtCompressDirTreeRoot
            // 
            this.txtCompressDirTreeRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCompressDirTreeRoot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompressDirTreeRoot.DetectUrls = false;
            this.txtCompressDirTreeRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompressDirTreeRoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCompressDirTreeRoot.Location = new System.Drawing.Point(799, 182);
            this.txtCompressDirTreeRoot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.txtCompressDirTreeRoot.Name = "txtCompressDirTreeRoot";
            this.txtCompressDirTreeRoot.Size = new System.Drawing.Size(442, 61);
            this.txtCompressDirTreeRoot.TabIndex = 6;
            this.txtCompressDirTreeRoot.Text = "";
            this.toolTip.SetToolTip(this.txtCompressDirTreeRoot, "Remove this string from all file paths when using \"Recreate Dir Tree\"");
            this.txtCompressDirTreeRoot.TextChanged += new System.EventHandler(this.txtCompressDirTreeRoot_TextChanged);
            // 
            // txtCompressInputFiles
            // 
            this.txtCompressInputFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCompressInputFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tblCompressInputsOutputs.SetColumnSpan(this.txtCompressInputFiles, 2);
            this.txtCompressInputFiles.DetectUrls = false;
            this.txtCompressInputFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompressInputFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCompressInputFiles.Location = new System.Drawing.Point(3, 83);
            this.txtCompressInputFiles.Name = "txtCompressInputFiles";
            this.tblCompressInputsOutputs.SetRowSpan(this.txtCompressInputFiles, 3);
            this.txtCompressInputFiles.Size = new System.Drawing.Size(790, 160);
            this.txtCompressInputFiles.TabIndex = 4;
            this.txtCompressInputFiles.Text = "";
            this.txtCompressInputFiles.TextChanged += new System.EventHandler(this.txtCompressInputFiles_TextChanged);
            // 
            // txtCompressOutputFolder
            // 
            this.txtCompressOutputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCompressOutputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompressOutputFolder.DetectUrls = false;
            this.txtCompressOutputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCompressOutputFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCompressOutputFolder.Location = new System.Drawing.Point(799, 83);
            this.txtCompressOutputFolder.Name = "txtCompressOutputFolder";
            this.txtCompressOutputFolder.Size = new System.Drawing.Size(442, 74);
            this.txtCompressOutputFolder.TabIndex = 5;
            this.txtCompressOutputFolder.Text = "";
            // 
            // btnCompressOutput
            // 
            this.btnCompressOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCompressOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompressOutput.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCompressOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompressOutput.Location = new System.Drawing.Point(799, 3);
            this.btnCompressOutput.Name = "btnCompressOutput";
            this.btnCompressOutput.Size = new System.Drawing.Size(442, 74);
            this.btnCompressOutput.TabIndex = 3;
            this.btnCompressOutput.Text = "Output Folder";
            this.btnCompressOutput.UseVisualStyleBackColor = false;
            this.btnCompressOutput.Click += new System.EventHandler(this.btnCompressOutput_Click);
            // 
            // btnCompressInputFolder
            // 
            this.btnCompressInputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCompressInputFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompressInputFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCompressInputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompressInputFolder.Location = new System.Drawing.Point(401, 3);
            this.btnCompressInputFolder.Name = "btnCompressInputFolder";
            this.btnCompressInputFolder.Size = new System.Drawing.Size(392, 74);
            this.btnCompressInputFolder.TabIndex = 2;
            this.btnCompressInputFolder.Text = "Input Folder";
            this.btnCompressInputFolder.UseVisualStyleBackColor = false;
            this.btnCompressInputFolder.Click += new System.EventHandler(this.btnCompressInputFolder_Click);
            // 
            // btnCompressInputFiles
            // 
            this.btnCompressInputFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCompressInputFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompressInputFiles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCompressInputFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompressInputFiles.Location = new System.Drawing.Point(3, 3);
            this.btnCompressInputFiles.Name = "btnCompressInputFiles";
            this.btnCompressInputFiles.Size = new System.Drawing.Size(392, 74);
            this.btnCompressInputFiles.TabIndex = 1;
            this.btnCompressInputFiles.Text = "Input File(s)";
            this.btnCompressInputFiles.UseVisualStyleBackColor = false;
            this.btnCompressInputFiles.Click += new System.EventHandler(this.btnCompressInputFiles_Click);
            // 
            // tblCompressOptions
            // 
            this.tblCompressOptions.ColumnCount = 3;
            this.tblCompressOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tblCompressOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31F));
            this.tblCompressOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCompressOptions.Controls.Add(this.gbCompressCompression, 0, 0);
            this.tblCompressOptions.Controls.Add(this.gbCompressSpeed, 0, 0);
            this.tblCompressOptions.Controls.Add(this.gbCompressResolution, 1, 0);
            this.tblCompressOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCompressOptions.Location = new System.Drawing.Point(0, 252);
            this.tblCompressOptions.Margin = new System.Windows.Forms.Padding(0);
            this.tblCompressOptions.Name = "tblCompressOptions";
            this.tblCompressOptions.RowCount = 1;
            this.tblCompressOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCompressOptions.Size = new System.Drawing.Size(1250, 100);
            this.tblCompressOptions.TabIndex = 7;
            // 
            // gbCompressCompression
            // 
            this.gbCompressCompression.Controls.Add(this.txtCompressCustomCrf);
            this.gbCompressCompression.Controls.Add(this.rbtnCompressMax);
            this.gbCompressCompression.Controls.Add(this.rbtnCompressCustomCrf);
            this.gbCompressCompression.Controls.Add(this.rbtnCompressHigh);
            this.gbCompressCompression.Controls.Add(this.rbtnCompressNormal);
            this.gbCompressCompression.Controls.Add(this.rbtnCompressLossless);
            this.gbCompressCompression.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCompressCompression.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCompressCompression.Location = new System.Drawing.Point(553, 3);
            this.gbCompressCompression.Name = "gbCompressCompression";
            this.gbCompressCompression.Size = new System.Drawing.Size(381, 94);
            this.gbCompressCompression.TabIndex = 8;
            this.gbCompressCompression.TabStop = false;
            this.gbCompressCompression.Text = "Compression";
            this.toolTip.SetToolTip(this.gbCompressCompression, "Low compression means better quality, but larger file sizes");
            // 
            // txtCompressCustomCrf
            // 
            this.txtCompressCustomCrf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCompressCustomCrf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompressCustomCrf.Enabled = false;
            this.txtCompressCustomCrf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCompressCustomCrf.Location = new System.Drawing.Point(172, 59);
            this.txtCompressCustomCrf.Maximum = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.txtCompressCustomCrf.Name = "txtCompressCustomCrf";
            this.txtCompressCustomCrf.Size = new System.Drawing.Size(74, 26);
            this.txtCompressCustomCrf.TabIndex = 5;
            this.txtCompressCustomCrf.ValueChanged += new System.EventHandler(this.rbtnCompressCrf_CheckedChanged);
            // 
            // rbtnCompressMax
            // 
            this.rbtnCompressMax.AutoSize = true;
            this.rbtnCompressMax.Location = new System.Drawing.Point(318, 25);
            this.rbtnCompressMax.Name = "rbtnCompressMax";
            this.rbtnCompressMax.Size = new System.Drawing.Size(54, 23);
            this.rbtnCompressMax.TabIndex = 3;
            this.rbtnCompressMax.Text = "Max";
            this.rbtnCompressMax.UseVisualStyleBackColor = true;
            this.rbtnCompressMax.CheckedChanged += new System.EventHandler(this.rbtnCompressCrf_CheckedChanged);
            // 
            // rbtnCompressCustomCrf
            // 
            this.rbtnCompressCustomCrf.AutoSize = true;
            this.rbtnCompressCustomCrf.Location = new System.Drawing.Point(15, 59);
            this.rbtnCompressCustomCrf.Name = "rbtnCompressCustomCrf";
            this.rbtnCompressCustomCrf.Size = new System.Drawing.Size(162, 23);
            this.rbtnCompressCustomCrf.TabIndex = 4;
            this.rbtnCompressCustomCrf.Text = "Custom (0-51): ";
            this.rbtnCompressCustomCrf.UseVisualStyleBackColor = true;
            this.rbtnCompressCustomCrf.CheckedChanged += new System.EventHandler(this.rbtnCompressCrf_CheckedChanged);
            // 
            // rbtnCompressHigh
            // 
            this.rbtnCompressHigh.AutoSize = true;
            this.rbtnCompressHigh.Location = new System.Drawing.Point(235, 25);
            this.rbtnCompressHigh.Name = "rbtnCompressHigh";
            this.rbtnCompressHigh.Size = new System.Drawing.Size(63, 23);
            this.rbtnCompressHigh.TabIndex = 2;
            this.rbtnCompressHigh.Text = "High";
            this.rbtnCompressHigh.UseVisualStyleBackColor = true;
            this.rbtnCompressHigh.CheckedChanged += new System.EventHandler(this.rbtnCompressCrf_CheckedChanged);
            // 
            // rbtnCompressNormal
            // 
            this.rbtnCompressNormal.AutoSize = true;
            this.rbtnCompressNormal.Checked = true;
            this.rbtnCompressNormal.Location = new System.Drawing.Point(134, 25);
            this.rbtnCompressNormal.Name = "rbtnCompressNormal";
            this.rbtnCompressNormal.Size = new System.Drawing.Size(81, 23);
            this.rbtnCompressNormal.TabIndex = 1;
            this.rbtnCompressNormal.TabStop = true;
            this.rbtnCompressNormal.Text = "Normal";
            this.rbtnCompressNormal.UseVisualStyleBackColor = true;
            this.rbtnCompressNormal.CheckedChanged += new System.EventHandler(this.rbtnCompressCrf_CheckedChanged);
            // 
            // rbtnCompressLossless
            // 
            this.rbtnCompressLossless.AutoSize = true;
            this.rbtnCompressLossless.Location = new System.Drawing.Point(15, 25);
            this.rbtnCompressLossless.Name = "rbtnCompressLossless";
            this.rbtnCompressLossless.Size = new System.Drawing.Size(99, 23);
            this.rbtnCompressLossless.TabIndex = 0;
            this.rbtnCompressLossless.Text = "Lossless";
            this.rbtnCompressLossless.UseVisualStyleBackColor = true;
            this.rbtnCompressLossless.CheckedChanged += new System.EventHandler(this.rbtnCompressCrf_CheckedChanged);
            // 
            // gbCompressSpeed
            // 
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressVerySlow);
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressSlower);
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressSlow);
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressMedium);
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressFast);
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressVeryFast);
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressSuperFast);
            this.gbCompressSpeed.Controls.Add(this.rbtnCompressUltraFast);
            this.gbCompressSpeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCompressSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCompressSpeed.Location = new System.Drawing.Point(6, 3);
            this.gbCompressSpeed.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.gbCompressSpeed.Name = "gbCompressSpeed";
            this.gbCompressSpeed.Size = new System.Drawing.Size(541, 94);
            this.gbCompressSpeed.TabIndex = 7;
            this.gbCompressSpeed.TabStop = false;
            this.gbCompressSpeed.Text = "Speed";
            this.toolTip.SetToolTip(this.gbCompressSpeed, "Slow compression speed means better quality for the same file size");
            // 
            // rbtnCompressVerySlow
            // 
            this.rbtnCompressVerySlow.AutoSize = true;
            this.rbtnCompressVerySlow.Location = new System.Drawing.Point(417, 59);
            this.rbtnCompressVerySlow.Name = "rbtnCompressVerySlow";
            this.rbtnCompressVerySlow.Size = new System.Drawing.Size(108, 23);
            this.rbtnCompressVerySlow.TabIndex = 7;
            this.rbtnCompressVerySlow.Text = "Very Slow";
            this.rbtnCompressVerySlow.UseVisualStyleBackColor = true;
            this.rbtnCompressVerySlow.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // rbtnCompressSlower
            // 
            this.rbtnCompressSlower.AutoSize = true;
            this.rbtnCompressSlower.Location = new System.Drawing.Point(289, 59);
            this.rbtnCompressSlower.Name = "rbtnCompressSlower";
            this.rbtnCompressSlower.Size = new System.Drawing.Size(81, 23);
            this.rbtnCompressSlower.TabIndex = 6;
            this.rbtnCompressSlower.Text = "Slower";
            this.rbtnCompressSlower.UseVisualStyleBackColor = true;
            this.rbtnCompressSlower.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // rbtnCompressSlow
            // 
            this.rbtnCompressSlow.AutoSize = true;
            this.rbtnCompressSlow.Checked = true;
            this.rbtnCompressSlow.Location = new System.Drawing.Point(152, 59);
            this.rbtnCompressSlow.Name = "rbtnCompressSlow";
            this.rbtnCompressSlow.Size = new System.Drawing.Size(63, 23);
            this.rbtnCompressSlow.TabIndex = 5;
            this.rbtnCompressSlow.TabStop = true;
            this.rbtnCompressSlow.Text = "Slow";
            this.rbtnCompressSlow.UseVisualStyleBackColor = true;
            this.rbtnCompressSlow.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // rbtnCompressMedium
            // 
            this.rbtnCompressMedium.AutoSize = true;
            this.rbtnCompressMedium.Location = new System.Drawing.Point(15, 59);
            this.rbtnCompressMedium.Name = "rbtnCompressMedium";
            this.rbtnCompressMedium.Size = new System.Drawing.Size(81, 23);
            this.rbtnCompressMedium.TabIndex = 4;
            this.rbtnCompressMedium.Text = "Medium";
            this.rbtnCompressMedium.UseVisualStyleBackColor = true;
            this.rbtnCompressMedium.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // rbtnCompressFast
            // 
            this.rbtnCompressFast.AutoSize = true;
            this.rbtnCompressFast.Location = new System.Drawing.Point(417, 25);
            this.rbtnCompressFast.Name = "rbtnCompressFast";
            this.rbtnCompressFast.Size = new System.Drawing.Size(63, 23);
            this.rbtnCompressFast.TabIndex = 3;
            this.rbtnCompressFast.Text = "Fast";
            this.rbtnCompressFast.UseVisualStyleBackColor = true;
            this.rbtnCompressFast.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // rbtnCompressVeryFast
            // 
            this.rbtnCompressVeryFast.AutoSize = true;
            this.rbtnCompressVeryFast.Location = new System.Drawing.Point(289, 25);
            this.rbtnCompressVeryFast.Name = "rbtnCompressVeryFast";
            this.rbtnCompressVeryFast.Size = new System.Drawing.Size(108, 23);
            this.rbtnCompressVeryFast.TabIndex = 2;
            this.rbtnCompressVeryFast.Text = "Very Fast";
            this.rbtnCompressVeryFast.UseVisualStyleBackColor = true;
            this.rbtnCompressVeryFast.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // rbtnCompressSuperFast
            // 
            this.rbtnCompressSuperFast.AutoSize = true;
            this.rbtnCompressSuperFast.Location = new System.Drawing.Point(152, 25);
            this.rbtnCompressSuperFast.Name = "rbtnCompressSuperFast";
            this.rbtnCompressSuperFast.Size = new System.Drawing.Size(117, 23);
            this.rbtnCompressSuperFast.TabIndex = 1;
            this.rbtnCompressSuperFast.Text = "Super Fast";
            this.rbtnCompressSuperFast.UseVisualStyleBackColor = true;
            this.rbtnCompressSuperFast.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // rbtnCompressUltraFast
            // 
            this.rbtnCompressUltraFast.AutoSize = true;
            this.rbtnCompressUltraFast.Location = new System.Drawing.Point(15, 25);
            this.rbtnCompressUltraFast.Name = "rbtnCompressUltraFast";
            this.rbtnCompressUltraFast.Size = new System.Drawing.Size(117, 23);
            this.rbtnCompressUltraFast.TabIndex = 0;
            this.rbtnCompressUltraFast.Text = "Ultra Fast";
            this.rbtnCompressUltraFast.UseVisualStyleBackColor = true;
            this.rbtnCompressUltraFast.CheckedChanged += new System.EventHandler(this.rbtnCompressSpeed_CheckedChanged);
            // 
            // gbCompressResolution
            // 
            this.gbCompressResolution.Controls.Add(this.txtCompressCustomRes);
            this.gbCompressResolution.Controls.Add(this.rbtnCompress4K);
            this.gbCompressResolution.Controls.Add(this.rbtnCompressCustomRes);
            this.gbCompressResolution.Controls.Add(this.rbtnCompress2K);
            this.gbCompressResolution.Controls.Add(this.rbtnCompress1080);
            this.gbCompressResolution.Controls.Add(this.rbtnCompress720);
            this.gbCompressResolution.Controls.Add(this.rbtnCompress360);
            this.gbCompressResolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCompressResolution.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCompressResolution.Location = new System.Drawing.Point(940, 3);
            this.gbCompressResolution.Margin = new System.Windows.Forms.Padding(3, 3, 6, 3);
            this.gbCompressResolution.Name = "gbCompressResolution";
            this.gbCompressResolution.Size = new System.Drawing.Size(304, 94);
            this.gbCompressResolution.TabIndex = 9;
            this.gbCompressResolution.TabStop = false;
            this.gbCompressResolution.Text = "Resolution";
            this.toolTip.SetToolTip(this.gbCompressResolution, "Resolution of the output file if the \"Change Resolution\" option is selected");
            // 
            // txtCompressCustomRes
            // 
            this.txtCompressCustomRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtCompressCustomRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompressCustomRes.Enabled = false;
            this.txtCompressCustomRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCompressCustomRes.Location = new System.Drawing.Point(184, 59);
            this.txtCompressCustomRes.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtCompressCustomRes.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.txtCompressCustomRes.Name = "txtCompressCustomRes";
            this.txtCompressCustomRes.Size = new System.Drawing.Size(100, 26);
            this.txtCompressCustomRes.TabIndex = 16;
            this.txtCompressCustomRes.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.txtCompressCustomRes.ValueChanged += new System.EventHandler(this.rbtnCompressResolution_CheckedChanged);
            // 
            // rbtnCompress4K
            // 
            this.rbtnCompress4K.AutoSize = true;
            this.rbtnCompress4K.Location = new System.Drawing.Point(15, 59);
            this.rbtnCompress4K.Name = "rbtnCompress4K";
            this.rbtnCompress4K.Size = new System.Drawing.Size(45, 23);
            this.rbtnCompress4K.TabIndex = 4;
            this.rbtnCompress4K.Text = "4K";
            this.rbtnCompress4K.UseVisualStyleBackColor = true;
            this.rbtnCompress4K.CheckedChanged += new System.EventHandler(this.rbtnCompressResolution_CheckedChanged);
            // 
            // rbtnCompressCustomRes
            // 
            this.rbtnCompressCustomRes.AutoSize = true;
            this.rbtnCompressCustomRes.Location = new System.Drawing.Point(89, 59);
            this.rbtnCompressCustomRes.Name = "rbtnCompressCustomRes";
            this.rbtnCompressCustomRes.Size = new System.Drawing.Size(99, 23);
            this.rbtnCompressCustomRes.TabIndex = 5;
            this.rbtnCompressCustomRes.Text = "Custom: ";
            this.rbtnCompressCustomRes.UseVisualStyleBackColor = true;
            this.rbtnCompressCustomRes.CheckedChanged += new System.EventHandler(this.rbtnCompressResolution_CheckedChanged);
            // 
            // rbtnCompress2K
            // 
            this.rbtnCompress2K.AutoSize = true;
            this.rbtnCompress2K.Location = new System.Drawing.Point(246, 25);
            this.rbtnCompress2K.Name = "rbtnCompress2K";
            this.rbtnCompress2K.Size = new System.Drawing.Size(45, 23);
            this.rbtnCompress2K.TabIndex = 3;
            this.rbtnCompress2K.Text = "2K";
            this.rbtnCompress2K.UseVisualStyleBackColor = true;
            this.rbtnCompress2K.CheckedChanged += new System.EventHandler(this.rbtnCompressResolution_CheckedChanged);
            // 
            // rbtnCompress1080
            // 
            this.rbtnCompress1080.AutoSize = true;
            this.rbtnCompress1080.Checked = true;
            this.rbtnCompress1080.Location = new System.Drawing.Point(163, 25);
            this.rbtnCompress1080.Name = "rbtnCompress1080";
            this.rbtnCompress1080.Size = new System.Drawing.Size(63, 23);
            this.rbtnCompress1080.TabIndex = 2;
            this.rbtnCompress1080.TabStop = true;
            this.rbtnCompress1080.Text = "1080";
            this.rbtnCompress1080.UseVisualStyleBackColor = true;
            this.rbtnCompress1080.CheckedChanged += new System.EventHandler(this.rbtnCompressResolution_CheckedChanged);
            // 
            // rbtnCompress720
            // 
            this.rbtnCompress720.AutoSize = true;
            this.rbtnCompress720.Location = new System.Drawing.Point(89, 25);
            this.rbtnCompress720.Name = "rbtnCompress720";
            this.rbtnCompress720.Size = new System.Drawing.Size(54, 23);
            this.rbtnCompress720.TabIndex = 1;
            this.rbtnCompress720.Text = "720";
            this.rbtnCompress720.UseVisualStyleBackColor = true;
            this.rbtnCompress720.CheckedChanged += new System.EventHandler(this.rbtnCompressResolution_CheckedChanged);
            // 
            // rbtnCompress360
            // 
            this.rbtnCompress360.AutoSize = true;
            this.rbtnCompress360.Location = new System.Drawing.Point(15, 25);
            this.rbtnCompress360.Name = "rbtnCompress360";
            this.rbtnCompress360.Size = new System.Drawing.Size(54, 23);
            this.rbtnCompress360.TabIndex = 0;
            this.rbtnCompress360.Text = "360";
            this.rbtnCompress360.UseVisualStyleBackColor = true;
            this.rbtnCompress360.CheckedChanged += new System.EventHandler(this.rbtnCompressResolution_CheckedChanged);
            // 
            // tblCompress
            // 
            this.tblCompress.ColumnCount = 2;
            this.tblCompress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tblCompress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCompress.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblCompress.Controls.Add(this.btnCompress, 0, 0);
            this.tblCompress.Controls.Add(this.tblCompressCompletionStatus, 1, 0);
            this.tblCompress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCompress.Location = new System.Drawing.Point(3, 539);
            this.tblCompress.Name = "tblCompress";
            this.tblCompress.RowCount = 1;
            this.tblCompress.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCompress.Size = new System.Drawing.Size(1244, 95);
            this.tblCompress.TabIndex = 12;
            // 
            // btnCompress
            // 
            this.btnCompress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCompress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompress.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCompress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompress.Location = new System.Drawing.Point(3, 2);
            this.btnCompress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(294, 90);
            this.btnCompress.TabIndex = 14;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = false;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // tblCompressCompletionStatus
            // 
            this.tblCompressCompletionStatus.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblCompressCompletionStatus.ColumnCount = 3;
            this.tblCompressCompletionStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCompressCompletionStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tblCompressCompletionStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tblCompressCompletionStatus.Controls.Add(this.lblCompressProgressTimer, 1, 0);
            this.tblCompressCompletionStatus.Controls.Add(this.lblCompressNbFiles, 0, 0);
            this.tblCompressCompletionStatus.Controls.Add(this.progressBar, 0, 1);
            this.tblCompressCompletionStatus.Controls.Add(this.lblCompressPercentFiles, 2, 0);
            this.tblCompressCompletionStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCompressCompletionStatus.Location = new System.Drawing.Point(303, 3);
            this.tblCompressCompletionStatus.Name = "tblCompressCompletionStatus";
            this.tblCompressCompletionStatus.RowCount = 2;
            this.tblCompressCompletionStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblCompressCompletionStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblCompressCompletionStatus.Size = new System.Drawing.Size(938, 89);
            this.tblCompressCompletionStatus.TabIndex = 0;
            // 
            // lblCompressProgressTimer
            // 
            this.lblCompressProgressTimer.AutoSize = true;
            this.lblCompressProgressTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompressProgressTimer.Location = new System.Drawing.Point(716, 1);
            this.lblCompressProgressTimer.Name = "lblCompressProgressTimer";
            this.lblCompressProgressTimer.Size = new System.Drawing.Size(124, 34);
            this.lblCompressProgressTimer.TabIndex = 3;
            this.lblCompressProgressTimer.Text = "0:00:00:00";
            this.lblCompressProgressTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCompressNbFiles
            // 
            this.lblCompressNbFiles.AutoSize = true;
            this.lblCompressNbFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompressNbFiles.Location = new System.Drawing.Point(4, 1);
            this.lblCompressNbFiles.Name = "lblCompressNbFiles";
            this.lblCompressNbFiles.Size = new System.Drawing.Size(705, 34);
            this.lblCompressNbFiles.TabIndex = 0;
            this.lblCompressNbFiles.Text = "0 / 0 files";
            this.lblCompressNbFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.DimGray;
            this.tblCompressCompletionStatus.SetColumnSpan(this.progressBar, 3);
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.ForeColor = System.Drawing.Color.DarkGreen;
            this.progressBar.Location = new System.Drawing.Point(4, 39);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(930, 46);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 2;
            // 
            // lblCompressPercentFiles
            // 
            this.lblCompressPercentFiles.AutoSize = true;
            this.lblCompressPercentFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCompressPercentFiles.Location = new System.Drawing.Point(847, 1);
            this.lblCompressPercentFiles.Name = "lblCompressPercentFiles";
            this.lblCompressPercentFiles.Size = new System.Drawing.Size(87, 34);
            this.lblCompressPercentFiles.TabIndex = 1;
            this.lblCompressPercentFiles.Text = "0%";
            this.lblCompressPercentFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblCompressOther
            // 
            this.tblCompressOther.ColumnCount = 3;
            this.tblCompressOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tblCompressOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tblCompressOther.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tblCompressOther.Controls.Add(this.gbCompressMode, 0, 0);
            this.tblCompressOther.Controls.Add(this.btnCompressResetSettings, 2, 0);
            this.tblCompressOther.Controls.Add(this.gbCompressOther, 0, 0);
            this.tblCompressOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCompressOther.Location = new System.Drawing.Point(0, 352);
            this.tblCompressOther.Margin = new System.Windows.Forms.Padding(0);
            this.tblCompressOther.Name = "tblCompressOther";
            this.tblCompressOther.RowCount = 1;
            this.tblCompressOther.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCompressOther.Size = new System.Drawing.Size(1250, 100);
            this.tblCompressOther.TabIndex = 10;
            // 
            // gbCompressMode
            // 
            this.gbCompressMode.Controls.Add(this.chkCompressModeJpg);
            this.gbCompressMode.Controls.Add(this.chkCompressModePng);
            this.gbCompressMode.Controls.Add(this.chkCompressModeAudio);
            this.gbCompressMode.Controls.Add(this.chkCompressModeVideo);
            this.gbCompressMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCompressMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCompressMode.Location = new System.Drawing.Point(790, 3);
            this.gbCompressMode.Name = "gbCompressMode";
            this.gbCompressMode.Size = new System.Drawing.Size(194, 94);
            this.gbCompressMode.TabIndex = 11;
            this.gbCompressMode.TabStop = false;
            this.gbCompressMode.Text = "Mode";
            this.toolTip.SetToolTip(this.gbCompressMode, "Type of the files to compress");
            // 
            // chkCompressModeJpg
            // 
            this.chkCompressModeJpg.AutoSize = true;
            this.chkCompressModeJpg.Location = new System.Drawing.Point(114, 57);
            this.chkCompressModeJpg.Name = "chkCompressModeJpg";
            this.chkCompressModeJpg.Size = new System.Drawing.Size(63, 23);
            this.chkCompressModeJpg.TabIndex = 3;
            this.chkCompressModeJpg.Text = ".jpg";
            this.chkCompressModeJpg.UseVisualStyleBackColor = true;
            this.chkCompressModeJpg.CheckedChanged += new System.EventHandler(this.chkCompressMode_CheckedChanged);
            // 
            // chkCompressModePng
            // 
            this.chkCompressModePng.AutoSize = true;
            this.chkCompressModePng.Location = new System.Drawing.Point(114, 25);
            this.chkCompressModePng.Name = "chkCompressModePng";
            this.chkCompressModePng.Size = new System.Drawing.Size(63, 23);
            this.chkCompressModePng.TabIndex = 1;
            this.chkCompressModePng.Text = ".png";
            this.chkCompressModePng.UseVisualStyleBackColor = true;
            this.chkCompressModePng.CheckedChanged += new System.EventHandler(this.chkCompressMode_CheckedChanged);
            // 
            // chkCompressModeAudio
            // 
            this.chkCompressModeAudio.AutoSize = true;
            this.chkCompressModeAudio.Location = new System.Drawing.Point(17, 57);
            this.chkCompressModeAudio.Name = "chkCompressModeAudio";
            this.chkCompressModeAudio.Size = new System.Drawing.Size(72, 23);
            this.chkCompressModeAudio.TabIndex = 2;
            this.chkCompressModeAudio.Text = "Audio";
            this.chkCompressModeAudio.UseVisualStyleBackColor = true;
            this.chkCompressModeAudio.CheckedChanged += new System.EventHandler(this.chkCompressMode_CheckedChanged);
            // 
            // chkCompressModeVideo
            // 
            this.chkCompressModeVideo.AutoSize = true;
            this.chkCompressModeVideo.Checked = true;
            this.chkCompressModeVideo.Location = new System.Drawing.Point(17, 24);
            this.chkCompressModeVideo.Name = "chkCompressModeVideo";
            this.chkCompressModeVideo.Size = new System.Drawing.Size(72, 23);
            this.chkCompressModeVideo.TabIndex = 0;
            this.chkCompressModeVideo.TabStop = true;
            this.chkCompressModeVideo.Text = "Video";
            this.chkCompressModeVideo.UseVisualStyleBackColor = true;
            this.chkCompressModeVideo.CheckedChanged += new System.EventHandler(this.chkCompressMode_CheckedChanged);
            // 
            // btnCompressResetSettings
            // 
            this.btnCompressResetSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnCompressResetSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompressResetSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCompressResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompressResetSettings.Location = new System.Drawing.Point(990, 12);
            this.btnCompressResetSettings.Margin = new System.Windows.Forms.Padding(3, 12, 6, 4);
            this.btnCompressResetSettings.Name = "btnCompressResetSettings";
            this.btnCompressResetSettings.Size = new System.Drawing.Size(254, 84);
            this.btnCompressResetSettings.TabIndex = 12;
            this.btnCompressResetSettings.Text = "Reset Settings";
            this.btnCompressResetSettings.UseVisualStyleBackColor = false;
            this.btnCompressResetSettings.Click += new System.EventHandler(this.btnCompressResetSettings_Click);
            // 
            // gbCompressOther
            // 
            this.gbCompressOther.Controls.Add(this.chkCompressChangeRes);
            this.gbCompressOther.Controls.Add(this.chkCompressGenerateReport);
            this.gbCompressOther.Controls.Add(this.chkCompressRevertBigger);
            this.gbCompressOther.Controls.Add(this.chkCompressOutputTree);
            this.gbCompressOther.Controls.Add(this.chkCompressAudio);
            this.gbCompressOther.Controls.Add(this.chkCompressAutoOverwrite);
            this.gbCompressOther.Controls.Add(this.chkCompressCmdAutoExit);
            this.gbCompressOther.Controls.Add(this.chkCompressSubFolders);
            this.gbCompressOther.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCompressOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbCompressOther.Location = new System.Drawing.Point(6, 3);
            this.gbCompressOther.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.gbCompressOther.Name = "gbCompressOther";
            this.gbCompressOther.Size = new System.Drawing.Size(778, 94);
            this.gbCompressOther.TabIndex = 10;
            this.gbCompressOther.TabStop = false;
            this.gbCompressOther.Text = "Other";
            // 
            // chkCompressChangeRes
            // 
            this.chkCompressChangeRes.AutoSize = true;
            this.chkCompressChangeRes.Checked = true;
            this.chkCompressChangeRes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompressChangeRes.Location = new System.Drawing.Point(549, 25);
            this.chkCompressChangeRes.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressChangeRes.Name = "chkCompressChangeRes";
            this.chkCompressChangeRes.Size = new System.Drawing.Size(181, 23);
            this.chkCompressChangeRes.TabIndex = 3;
            this.chkCompressChangeRes.Text = "Change Resolution";
            this.toolTip.SetToolTip(this.chkCompressChangeRes, "Scale the video to the selected resolution");
            this.chkCompressChangeRes.UseVisualStyleBackColor = true;
            this.chkCompressChangeRes.CheckedChanged += new System.EventHandler(this.chkCompressChangeRes_CheckedChanged);
            // 
            // chkCompressGenerateReport
            // 
            this.chkCompressGenerateReport.AutoSize = true;
            this.chkCompressGenerateReport.Checked = true;
            this.chkCompressGenerateReport.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompressGenerateReport.Location = new System.Drawing.Point(371, 25);
            this.chkCompressGenerateReport.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressGenerateReport.Name = "chkCompressGenerateReport";
            this.chkCompressGenerateReport.Size = new System.Drawing.Size(163, 23);
            this.chkCompressGenerateReport.TabIndex = 2;
            this.chkCompressGenerateReport.Text = "Generate Report";
            this.toolTip.SetToolTip(this.chkCompressGenerateReport, "Generate a compression report");
            this.chkCompressGenerateReport.UseVisualStyleBackColor = true;
            // 
            // chkCompressRevertBigger
            // 
            this.chkCompressRevertBigger.AutoSize = true;
            this.chkCompressRevertBigger.Checked = true;
            this.chkCompressRevertBigger.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompressRevertBigger.Location = new System.Drawing.Point(15, 58);
            this.chkCompressRevertBigger.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressRevertBigger.Name = "chkCompressRevertBigger";
            this.chkCompressRevertBigger.Size = new System.Drawing.Size(217, 23);
            this.chkCompressRevertBigger.TabIndex = 4;
            this.chkCompressRevertBigger.Text = "Revert Bigger Outputs";
            this.toolTip.SetToolTip(this.chkCompressRevertBigger, "Replace output files by their input if the input is smaller");
            this.chkCompressRevertBigger.UseVisualStyleBackColor = true;
            // 
            // chkCompressOutputTree
            // 
            this.chkCompressOutputTree.AutoSize = true;
            this.chkCompressOutputTree.Checked = true;
            this.chkCompressOutputTree.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompressOutputTree.Location = new System.Drawing.Point(247, 58);
            this.chkCompressOutputTree.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressOutputTree.Name = "chkCompressOutputTree";
            this.chkCompressOutputTree.Size = new System.Drawing.Size(181, 23);
            this.chkCompressOutputTree.TabIndex = 5;
            this.chkCompressOutputTree.Text = "Recreate Dir Tree";
            this.toolTip.SetToolTip(this.chkCompressOutputTree, "Recreate the directory tree of the input files in the output folder");
            this.chkCompressOutputTree.UseVisualStyleBackColor = true;
            this.chkCompressOutputTree.CheckedChanged += new System.EventHandler(this.chkCompressOutputTree_CheckedChanged);
            // 
            // chkCompressAudio
            // 
            this.chkCompressAudio.AutoSize = true;
            this.chkCompressAudio.Location = new System.Drawing.Point(612, 57);
            this.chkCompressAudio.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressAudio.Name = "chkCompressAudio";
            this.chkCompressAudio.Size = new System.Drawing.Size(154, 23);
            this.chkCompressAudio.TabIndex = 7;
            this.chkCompressAudio.Text = "Compress Audio";
            this.toolTip.SetToolTip(this.chkCompressAudio, "Compress the audio instead of copying the original");
            this.chkCompressAudio.UseVisualStyleBackColor = true;
            this.chkCompressAudio.CheckedChanged += new System.EventHandler(this.chkCompressAudio_CheckedChanged);
            // 
            // chkCompressAutoOverwrite
            // 
            this.chkCompressAutoOverwrite.AutoSize = true;
            this.chkCompressAutoOverwrite.Location = new System.Drawing.Point(443, 58);
            this.chkCompressAutoOverwrite.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressAutoOverwrite.Name = "chkCompressAutoOverwrite";
            this.chkCompressAutoOverwrite.Size = new System.Drawing.Size(154, 23);
            this.chkCompressAutoOverwrite.TabIndex = 6;
            this.chkCompressAutoOverwrite.Text = "Auto Overwrite";
            this.toolTip.SetToolTip(this.chkCompressAutoOverwrite, "Overwrite files automatically ");
            this.chkCompressAutoOverwrite.UseVisualStyleBackColor = true;
            this.chkCompressAutoOverwrite.CheckedChanged += new System.EventHandler(this.chkCompressAutoOverwrite_CheckedChanged);
            // 
            // chkCompressCmdAutoExit
            // 
            this.chkCompressCmdAutoExit.AutoSize = true;
            this.chkCompressCmdAutoExit.Checked = true;
            this.chkCompressCmdAutoExit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompressCmdAutoExit.Location = new System.Drawing.Point(15, 25);
            this.chkCompressCmdAutoExit.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressCmdAutoExit.Name = "chkCompressCmdAutoExit";
            this.chkCompressCmdAutoExit.Size = new System.Drawing.Size(145, 23);
            this.chkCompressCmdAutoExit.TabIndex = 0;
            this.chkCompressCmdAutoExit.Text = "Auto Exit CMD";
            this.toolTip.SetToolTip(this.chkCompressCmdAutoExit, "Close command prompts after their files are compressed");
            this.chkCompressCmdAutoExit.UseVisualStyleBackColor = true;
            // 
            // chkCompressSubFolders
            // 
            this.chkCompressSubFolders.AutoSize = true;
            this.chkCompressSubFolders.Checked = true;
            this.chkCompressSubFolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCompressSubFolders.Location = new System.Drawing.Point(175, 25);
            this.chkCompressSubFolders.Margin = new System.Windows.Forms.Padding(10);
            this.chkCompressSubFolders.Name = "chkCompressSubFolders";
            this.chkCompressSubFolders.Size = new System.Drawing.Size(181, 23);
            this.chkCompressSubFolders.TabIndex = 1;
            this.chkCompressSubFolders.Text = "Search Subfolders";
            this.toolTip.SetToolTip(this.chkCompressSubFolders, "Search all subfolders when selecting \"Input Folder\"");
            this.chkCompressSubFolders.UseVisualStyleBackColor = true;
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 10000;
            this.toolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.toolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmVideoTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmVideoTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Tools 1.0.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.Resize += new System.EventHandler(this.frmVideoTools_Resize);
            this.tabs.ResumeLayout(false);
            this.tabPlay.ResumeLayout(false);
            this.tblPlayMain.ResumeLayout(false);
            this.tblPlayControls.ResumeLayout(false);
            this.pannelPlayOptions.ResumeLayout(false);
            this.pannelPlayOptions.PerformLayout();
            this.tblPlaySelectVideos.ResumeLayout(false);
            this.tblPlayReset.ResumeLayout(false);
            this.tabCompress.ResumeLayout(false);
            this.tblCompressMain.ResumeLayout(false);
            this.tblCompressInputsOutputs.ResumeLayout(false);
            this.tblCompressInputsOutputs.PerformLayout();
            this.tblCompressOptions.ResumeLayout(false);
            this.gbCompressCompression.ResumeLayout(false);
            this.gbCompressCompression.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompressCustomCrf)).EndInit();
            this.gbCompressSpeed.ResumeLayout(false);
            this.gbCompressSpeed.PerformLayout();
            this.gbCompressResolution.ResumeLayout(false);
            this.gbCompressResolution.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompressCustomRes)).EndInit();
            this.tblCompress.ResumeLayout(false);
            this.tblCompressCompletionStatus.ResumeLayout(false);
            this.tblCompressCompletionStatus.PerformLayout();
            this.tblCompressOther.ResumeLayout(false);
            this.gbCompressMode.ResumeLayout(false);
            this.gbCompressMode.PerformLayout();
            this.gbCompressOther.ResumeLayout(false);
            this.gbCompressOther.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCompress;
        private System.Windows.Forms.TabPage tabPlay;
        private System.Windows.Forms.TableLayoutPanel tblPlayMain;
        private System.Windows.Forms.RichTextBox txtPlayKeybinds;
        private System.Windows.Forms.TableLayoutPanel tblPlayControls;
        private System.Windows.Forms.RichTextBox txtPlayCommand;
        private System.Windows.Forms.RichTextBox txtPlayFilePath;
        private System.Windows.Forms.Panel pannelPlayOptions;
        private System.Windows.Forms.CheckBox chkPlayCmdAutoExit;
        private System.Windows.Forms.CheckBox chkPlayStartFullscreen;
        private System.Windows.Forms.CheckBox chkPlayBorderlessWindow;
        private System.Windows.Forms.CheckBox chkPlayAlwaysTop;
        private System.Windows.Forms.CheckBox chkPlayVideoAutoExit;
        private System.Windows.Forms.CheckBox chkPlayDisableAudio;
        private System.Windows.Forms.CheckBox chkPlayDisableVideo;
        private System.Windows.Forms.CheckBox chkPlaySearchSubfolders;
        private System.Windows.Forms.TableLayoutPanel tblPlaySelectVideos;
        private System.Windows.Forms.Button btnPlaySelectVideos;
        private System.Windows.Forms.Button btnPlaySelectFolder;
        private System.Windows.Forms.CheckBox chkPlaySimultaneousLaunch;
        private System.Windows.Forms.TableLayoutPanel tblPlayReset;
        private System.Windows.Forms.Button btnPlayReset;
        public System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TableLayoutPanel tblCompressMain;
        private System.Windows.Forms.Button btnCompressOutput;
        private System.Windows.Forms.Button btnCompressInputFolder;
        private System.Windows.Forms.Button btnCompressInputFiles;
        private System.Windows.Forms.RichTextBox txtCompressInputFiles;
        private System.Windows.Forms.RichTextBox txtCompressOutputFolder;
        private System.Windows.Forms.TableLayoutPanel tblCompressInputsOutputs;
        private System.Windows.Forms.TableLayoutPanel tblCompressOptions;
        private System.Windows.Forms.GroupBox gbCompressSpeed;
        private System.Windows.Forms.GroupBox gbCompressResolution;
        private System.Windows.Forms.RichTextBox txtCompressCommand;
        private System.Windows.Forms.TableLayoutPanel tblCompress;
        private System.Windows.Forms.TableLayoutPanel tblCompressCompletionStatus;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.RadioButton rbtnCompressUltraFast;
        private System.Windows.Forms.RadioButton rbtnCompressFast;
        private System.Windows.Forms.RadioButton rbtnCompressVeryFast;
        private System.Windows.Forms.RadioButton rbtnCompressSuperFast;
        private System.Windows.Forms.RadioButton rbtnCompressVerySlow;
        private System.Windows.Forms.RadioButton rbtnCompressSlower;
        private System.Windows.Forms.RadioButton rbtnCompressSlow;
        private System.Windows.Forms.RadioButton rbtnCompressMedium;
        private System.Windows.Forms.TableLayoutPanel tblCompressOther;
        private System.Windows.Forms.GroupBox gbCompressOther;
        private System.Windows.Forms.CheckBox chkCompressOutputTree;
        private System.Windows.Forms.CheckBox chkCompressAudio;
        private System.Windows.Forms.CheckBox chkCompressAutoOverwrite;
        private System.Windows.Forms.CheckBox chkCompressCmdAutoExit;
        private System.Windows.Forms.CheckBox chkCompressSubFolders;
        private System.Windows.Forms.RichTextBox txtCompressDirTreeRoot;
        private System.Windows.Forms.Label lblCompressDirTreeRoot;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label lblCompressNbFiles;
        private System.Windows.Forms.Label lblCompressPercentFiles;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button btnCompressResetSettings;
        private System.Windows.Forms.GroupBox gbCompressMode;
        private System.Windows.Forms.RadioButton chkCompressModeVideo;
        private System.Windows.Forms.RadioButton chkCompressModeAudio;
        private System.Windows.Forms.RadioButton chkCompressModeJpg;
        private System.Windows.Forms.RadioButton chkCompressModePng;
        private System.Windows.Forms.CheckBox chkCompressRevertBigger;
        private System.Windows.Forms.CheckBox chkCompressGenerateReport;
        private System.Windows.Forms.Label lblCompressProgressTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox gbCompressCompression;
        private System.Windows.Forms.NumericUpDown txtCompressCustomCrf;
        private System.Windows.Forms.RadioButton rbtnCompressMax;
        private System.Windows.Forms.RadioButton rbtnCompressCustomCrf;
        private System.Windows.Forms.RadioButton rbtnCompressHigh;
        private System.Windows.Forms.RadioButton rbtnCompressNormal;
        private System.Windows.Forms.RadioButton rbtnCompressLossless;
        private System.Windows.Forms.RadioButton rbtnCompress360;
        private System.Windows.Forms.RadioButton rbtnCompress1080;
        private System.Windows.Forms.RadioButton rbtnCompress720;
        private System.Windows.Forms.RadioButton rbtnCompress2K;
        private System.Windows.Forms.RadioButton rbtnCompress4K;
        private System.Windows.Forms.NumericUpDown txtCompressCustomRes;
        private System.Windows.Forms.RadioButton rbtnCompressCustomRes;
        private System.Windows.Forms.CheckBox chkCompressChangeRes;
    }
}

