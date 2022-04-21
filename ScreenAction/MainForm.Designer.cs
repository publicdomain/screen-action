
namespace ScreenAction
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skipEvensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeReleasesPublicDomainisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.samplesInLIstToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.samplesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eligibleSamplesToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.eligibleSamplesCountToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.screenLabel = new System.Windows.Forms.Label();
            this.actionLabel = new System.Windows.Forms.Label();
            this.desktopButton = new System.Windows.Forms.Button();
            this.cameraButton = new System.Windows.Forms.Button();
            this.logRadioButton = new System.Windows.Forms.RadioButton();
            this.soundRadioButton = new System.Windows.Forms.RadioButton();
            this.commandRadioButton = new System.Windows.Forms.RadioButton();
            this.logButton = new System.Windows.Forms.Button();
            this.soundButton = new System.Windows.Forms.Button();
            this.commandButton = new System.Windows.Forms.Button();
            this.startStopButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.configLabel = new System.Windows.Forms.Label();
            this.differenceLabel = new System.Windows.Forms.Label();
            this.differenceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.desktopRadioButton = new System.Windows.Forms.RadioButton();
            this.windowRadioButton = new System.Windows.Forms.RadioButton();
            this.cameraRadioButton = new System.Windows.Forms.RadioButton();
            this.windowPictureBox = new System.Windows.Forms.PictureBox();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceNumericUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.fileToolStripMenuItem1,
                                    this.optionsToolStripMenuItem,
                                    this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(294, 24);
            this.mainMenuStrip.TabIndex = 49;
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.newToolStripMenuItem1,
                                    this.toolStripSeparator3,
                                    this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem1.Image")));
            this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.newToolStripMenuItem1.Text = "&New";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.alwaysOnTopToolStripMenuItem,
                                    this.skipEvensToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // skipEvensToolStripMenuItem
            // 
            this.skipEvensToolStripMenuItem.Name = "skipEvensToolStripMenuItem";
            this.skipEvensToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.skipEvensToolStripMenuItem.Text = "&Skip evens";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.freeReleasesPublicDomainisToolStripMenuItem,
                                    this.originalThreadDonationCodercomToolStripMenuItem,
                                    this.sourceCodeGithubcomToolStripMenuItem,
                                    this.toolStripSeparator2,
                                    this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // freeReleasesPublicDomainisToolStripMenuItem
            // 
            this.freeReleasesPublicDomainisToolStripMenuItem.Name = "freeReleasesPublicDomainisToolStripMenuItem";
            this.freeReleasesPublicDomainisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.freeReleasesPublicDomainisToolStripMenuItem.Text = "&Free Releases @ PublicDomain.is";
            this.freeReleasesPublicDomainisToolStripMenuItem.Click += new System.EventHandler(this.OnFreeReleasesPublicDomainisToolStripMenuItemClick);
            // 
            // originalThreadDonationCodercomToolStripMenuItem
            // 
            this.originalThreadDonationCodercomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadDonationCodercomToolStripMenuItem.Image")));
            this.originalThreadDonationCodercomToolStripMenuItem.Name = "originalThreadDonationCodercomToolStripMenuItem";
            this.originalThreadDonationCodercomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.originalThreadDonationCodercomToolStripMenuItem.Text = "&Original thread @ DonationCoder.com";
            this.originalThreadDonationCodercomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadDonationCodercomToolStripMenuItemClick);
            // 
            // sourceCodeGithubcomToolStripMenuItem
            // 
            this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
            this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
            this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.sourceCodeGithubcomToolStripMenuItem.Text = "&Source code @ Github.com";
            this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(275, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                                    this.samplesInLIstToolStripStatusLabel,
                                    this.samplesCountToolStripStatusLabel,
                                    this.eligibleSamplesToolStripStatusLabel,
                                    this.eligibleSamplesCountToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 310);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(294, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 48;
            // 
            // samplesInLIstToolStripStatusLabel
            // 
            this.samplesInLIstToolStripStatusLabel.Name = "samplesInLIstToolStripStatusLabel";
            this.samplesInLIstToolStripStatusLabel.Size = new System.Drawing.Size(47, 17);
            this.samplesInLIstToolStripStatusLabel.Text = "Next in:";
            // 
            // samplesCountToolStripStatusLabel
            // 
            this.samplesCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.samplesCountToolStripStatusLabel.Name = "samplesCountToolStripStatusLabel";
            this.samplesCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.samplesCountToolStripStatusLabel.Text = "0";
            // 
            // eligibleSamplesToolStripStatusLabel
            // 
            this.eligibleSamplesToolStripStatusLabel.Name = "eligibleSamplesToolStripStatusLabel";
            this.eligibleSamplesToolStripStatusLabel.Size = new System.Drawing.Size(50, 17);
            this.eligibleSamplesToolStripStatusLabel.Text = "Actions:";
            // 
            // eligibleSamplesCountToolStripStatusLabel
            // 
            this.eligibleSamplesCountToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.eligibleSamplesCountToolStripStatusLabel.Name = "eligibleSamplesCountToolStripStatusLabel";
            this.eligibleSamplesCountToolStripStatusLabel.Size = new System.Drawing.Size(14, 17);
            this.eligibleSamplesCountToolStripStatusLabel.Text = "0";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 3;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.mainTableLayoutPanel.Controls.Add(this.screenLabel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.actionLabel, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.desktopButton, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.cameraButton, 2, 2);
            this.mainTableLayoutPanel.Controls.Add(this.logRadioButton, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.soundRadioButton, 1, 4);
            this.mainTableLayoutPanel.Controls.Add(this.commandRadioButton, 2, 4);
            this.mainTableLayoutPanel.Controls.Add(this.logButton, 0, 5);
            this.mainTableLayoutPanel.Controls.Add(this.soundButton, 1, 5);
            this.mainTableLayoutPanel.Controls.Add(this.commandButton, 2, 5);
            this.mainTableLayoutPanel.Controls.Add(this.startStopButton, 0, 9);
            this.mainTableLayoutPanel.Controls.Add(this.intervalLabel, 0, 7);
            this.mainTableLayoutPanel.Controls.Add(this.intervalNumericUpDown, 0, 8);
            this.mainTableLayoutPanel.Controls.Add(this.configLabel, 0, 6);
            this.mainTableLayoutPanel.Controls.Add(this.differenceLabel, 1, 7);
            this.mainTableLayoutPanel.Controls.Add(this.differenceNumericUpDown, 1, 8);
            this.mainTableLayoutPanel.Controls.Add(this.colorLabel, 2, 7);
            this.mainTableLayoutPanel.Controls.Add(this.colorComboBox, 2, 8);
            this.mainTableLayoutPanel.Controls.Add(this.panel1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.windowPictureBox, 1, 2);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 10;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(294, 286);
            this.mainTableLayoutPanel.TabIndex = 50;
            // 
            // screenLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.screenLabel, 3);
            this.screenLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenLabel.Location = new System.Drawing.Point(3, 0);
            this.screenLabel.Name = "screenLabel";
            this.screenLabel.Size = new System.Drawing.Size(288, 25);
            this.screenLabel.TabIndex = 0;
            this.screenLabel.Text = "&Screen:";
            this.screenLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.actionLabel, 3);
            this.actionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.actionLabel.Location = new System.Drawing.Point(3, 88);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(288, 25);
            this.actionLabel.TabIndex = 6;
            this.actionLabel.Text = "&Action:";
            this.actionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desktopButton
            // 
            this.desktopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopButton.Location = new System.Drawing.Point(3, 53);
            this.desktopButton.Name = "desktopButton";
            this.desktopButton.Size = new System.Drawing.Size(91, 32);
            this.desktopButton.TabIndex = 3;
            this.desktopButton.Text = "&Set area";
            this.desktopButton.UseVisualStyleBackColor = true;
            this.desktopButton.Click += new System.EventHandler(this.OnDesktopButtonClick);
            // 
            // cameraButton
            // 
            this.cameraButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cameraButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraButton.Location = new System.Drawing.Point(198, 53);
            this.cameraButton.Name = "cameraButton";
            this.cameraButton.Size = new System.Drawing.Size(93, 32);
            this.cameraButton.TabIndex = 5;
            this.cameraButton.Text = "&Choose";
            this.cameraButton.UseVisualStyleBackColor = true;
            this.cameraButton.Click += new System.EventHandler(this.OnCameraButtonClick);
            // 
            // logRadioButton
            // 
            this.logRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRadioButton.Location = new System.Drawing.Point(3, 116);
            this.logRadioButton.Name = "logRadioButton";
            this.logRadioButton.Size = new System.Drawing.Size(91, 19);
            this.logRadioButton.TabIndex = 7;
            this.logRadioButton.TabStop = true;
            this.logRadioButton.Text = "&Log";
            this.logRadioButton.UseVisualStyleBackColor = true;
            // 
            // soundRadioButton
            // 
            this.soundRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundRadioButton.Location = new System.Drawing.Point(100, 116);
            this.soundRadioButton.Name = "soundRadioButton";
            this.soundRadioButton.Size = new System.Drawing.Size(92, 19);
            this.soundRadioButton.TabIndex = 8;
            this.soundRadioButton.TabStop = true;
            this.soundRadioButton.Text = "&Sound";
            this.soundRadioButton.UseVisualStyleBackColor = true;
            // 
            // commandRadioButton
            // 
            this.commandRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandRadioButton.Location = new System.Drawing.Point(198, 116);
            this.commandRadioButton.Name = "commandRadioButton";
            this.commandRadioButton.Size = new System.Drawing.Size(93, 19);
            this.commandRadioButton.TabIndex = 9;
            this.commandRadioButton.TabStop = true;
            this.commandRadioButton.Text = "&Command";
            this.commandRadioButton.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            this.logButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logButton.Location = new System.Drawing.Point(3, 141);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(91, 32);
            this.logButton.TabIndex = 10;
            this.logButton.Text = "&Browse";
            this.logButton.UseVisualStyleBackColor = true;
            this.logButton.Click += new System.EventHandler(this.OnLogButtonClick);
            // 
            // soundButton
            // 
            this.soundButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.soundButton.Location = new System.Drawing.Point(100, 141);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(92, 32);
            this.soundButton.TabIndex = 11;
            this.soundButton.Text = "&Browse";
            this.soundButton.UseVisualStyleBackColor = true;
            this.soundButton.Click += new System.EventHandler(this.OnSoundButtonClick);
            // 
            // commandButton
            // 
            this.commandButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandButton.Location = new System.Drawing.Point(198, 141);
            this.commandButton.Name = "commandButton";
            this.commandButton.Size = new System.Drawing.Size(93, 32);
            this.commandButton.TabIndex = 12;
            this.commandButton.Text = "&Set with args";
            this.commandButton.UseVisualStyleBackColor = true;
            this.commandButton.Click += new System.EventHandler(this.OnCommandButtonClick);
            // 
            // startStopButton
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.startStopButton, 3);
            this.startStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startStopButton.ForeColor = System.Drawing.Color.Green;
            this.startStopButton.Location = new System.Drawing.Point(3, 249);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(288, 34);
            this.startStopButton.TabIndex = 20;
            this.startStopButton.Text = "&Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.OnStartStopButtonClick);
            // 
            // intervalLabel
            // 
            this.intervalLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intervalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalLabel.Location = new System.Drawing.Point(3, 201);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(91, 20);
            this.intervalLabel.TabIndex = 14;
            this.intervalLabel.Text = "&Interval (ms):";
            this.intervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // intervalNumericUpDown
            // 
            this.intervalNumericUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intervalNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intervalNumericUpDown.Location = new System.Drawing.Point(3, 224);
            this.intervalNumericUpDown.Maximum = new decimal(new int[] {
                                    100000,
                                    0,
                                    0,
                                    0});
            this.intervalNumericUpDown.Name = "intervalNumericUpDown";
            this.intervalNumericUpDown.Size = new System.Drawing.Size(91, 22);
            this.intervalNumericUpDown.TabIndex = 15;
            this.intervalNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intervalNumericUpDown.Value = new decimal(new int[] {
                                    1000,
                                    0,
                                    0,
                                    0});
            // 
            // configLabel
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.configLabel, 3);
            this.configLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.configLabel.Location = new System.Drawing.Point(3, 176);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(288, 25);
            this.configLabel.TabIndex = 13;
            this.configLabel.Text = "&Config:";
            this.configLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // differenceLabel
            // 
            this.differenceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.differenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceLabel.Location = new System.Drawing.Point(100, 201);
            this.differenceLabel.Name = "differenceLabel";
            this.differenceLabel.Size = new System.Drawing.Size(92, 20);
            this.differenceLabel.TabIndex = 16;
            this.differenceLabel.Text = "% &difference:";
            this.differenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // differenceNumericUpDown
            // 
            this.differenceNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differenceNumericUpDown.Location = new System.Drawing.Point(100, 224);
            this.differenceNumericUpDown.Name = "differenceNumericUpDown";
            this.differenceNumericUpDown.Size = new System.Drawing.Size(92, 22);
            this.differenceNumericUpDown.TabIndex = 17;
            this.differenceNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.differenceNumericUpDown.Value = new decimal(new int[] {
                                    50,
                                    0,
                                    0,
                                    0});
            // 
            // colorLabel
            // 
            this.colorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(198, 201);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(93, 20);
            this.colorLabel.TabIndex = 18;
            this.colorLabel.Text = "&Color:";
            this.colorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorComboBox
            // 
            this.colorComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
                                    "Full color",
                                    "Grayscale",
                                    "Black & white"});
            this.colorComboBox.Location = new System.Drawing.Point(198, 224);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(93, 24);
            this.colorComboBox.TabIndex = 19;
            // 
            // panel1
            // 
            this.mainTableLayoutPanel.SetColumnSpan(this.panel1, 3);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 25);
            this.panel1.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.desktopRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.windowRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cameraRadioButton, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(294, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // desktopRadioButton
            // 
            this.desktopRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopRadioButton.Location = new System.Drawing.Point(3, 3);
            this.desktopRadioButton.Name = "desktopRadioButton";
            this.desktopRadioButton.Size = new System.Drawing.Size(91, 19);
            this.desktopRadioButton.TabIndex = 0;
            this.desktopRadioButton.TabStop = true;
            this.desktopRadioButton.Text = "&Desktop";
            this.desktopRadioButton.UseVisualStyleBackColor = true;
            // 
            // windowRadioButton
            // 
            this.windowRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowRadioButton.Location = new System.Drawing.Point(101, 3);
            this.windowRadioButton.Name = "windowRadioButton";
            this.windowRadioButton.Size = new System.Drawing.Size(91, 19);
            this.windowRadioButton.TabIndex = 1;
            this.windowRadioButton.TabStop = true;
            this.windowRadioButton.Text = "&Window";
            this.windowRadioButton.UseVisualStyleBackColor = true;
            // 
            // cameraRadioButton
            // 
            this.cameraRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cameraRadioButton.Location = new System.Drawing.Point(199, 3);
            this.cameraRadioButton.Name = "cameraRadioButton";
            this.cameraRadioButton.Size = new System.Drawing.Size(92, 19);
            this.cameraRadioButton.TabIndex = 2;
            this.cameraRadioButton.TabStop = true;
            this.cameraRadioButton.Text = "&Camera";
            this.cameraRadioButton.UseVisualStyleBackColor = true;
            // 
            // windowPictureBox
            // 
            this.windowPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("windowPictureBox.Image")));
            this.windowPictureBox.Location = new System.Drawing.Point(100, 53);
            this.windowPictureBox.Name = "windowPictureBox";
            this.windowPictureBox.Size = new System.Drawing.Size(92, 32);
            this.windowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.windowPictureBox.TabIndex = 23;
            this.windowPictureBox.TabStop = false;
            this.windowPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnWindowPictureBoxMouseDown);
            this.windowPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnWindowPictureBoxMouseMove);
            this.windowPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnWindowPictureBoxMouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 332);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.mainStatusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScreenAction";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.differenceNumericUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.windowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem skipEvensToolStripMenuItem;
        private System.Windows.Forms.PictureBox windowPictureBox;
        private System.Windows.Forms.RadioButton cameraRadioButton;
        private System.Windows.Forms.RadioButton windowRadioButton;
        private System.Windows.Forms.RadioButton desktopRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.NumericUpDown differenceNumericUpDown;
        private System.Windows.Forms.Label differenceLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.NumericUpDown intervalNumericUpDown;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Button startStopButton;
        private System.Windows.Forms.Button commandButton;
        private System.Windows.Forms.Button soundButton;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.RadioButton commandRadioButton;
        private System.Windows.Forms.RadioButton soundRadioButton;
        private System.Windows.Forms.RadioButton logRadioButton;
        private System.Windows.Forms.Button cameraButton;
        private System.Windows.Forms.Button desktopButton;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label screenLabel;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel eligibleSamplesCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel eligibleSamplesToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel samplesCountToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel samplesInLIstToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeReleasesPublicDomainisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
