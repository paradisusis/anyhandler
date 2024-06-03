
namespace AnyHandler
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
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.addquotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.moreReleasesParadisusisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadDonationCodercomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
        	this.statusTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.statusValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
        	this.dllTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.dllValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.moveProgramTextBox = new System.Windows.Forms.TextBox();
        	this.moveArgumentsTextBox = new System.Windows.Forms.TextBox();
        	this.moveBrowseButton = new System.Windows.Forms.Button();
        	this.moveHandlerLabel = new System.Windows.Forms.Label();
        	this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.renameProgramTextBox = new System.Windows.Forms.TextBox();
        	this.renameArgumentsTextBox = new System.Windows.Forms.TextBox();
        	this.renameBrowseButton = new System.Windows.Forms.Button();
        	this.renameHandlerLabel = new System.Windows.Forms.Label();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.deleteProgramLabel = new System.Windows.Forms.Label();
        	this.deleteArgumentsLabel = new System.Windows.Forms.Label();
        	this.deleteProgramTextBox = new System.Windows.Forms.TextBox();
        	this.deleteArgumentsTextBox = new System.Windows.Forms.TextBox();
        	this.deleteBrowseButton = new System.Windows.Forms.Button();
        	this.deleteHandlerLabel = new System.Windows.Forms.Label();
        	this.copyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
        	this.copyProgramLabel = new System.Windows.Forms.Label();
        	this.copyArgumentsLabel = new System.Windows.Forms.Label();
        	this.copyProgramTextBox = new System.Windows.Forms.TextBox();
        	this.copyArgumentsTextBox = new System.Windows.Forms.TextBox();
        	this.copyBrowseButton = new System.Windows.Forms.Button();
        	this.copyHandlerLabel = new System.Windows.Forms.Label();
        	this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
        	this.addButton = new System.Windows.Forms.Button();
        	this.removeButton = new System.Windows.Forms.Button();
        	this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        	this.copyHandlerHideCheckBox = new System.Windows.Forms.CheckBox();
        	this.deleteHandlerHideCheckBox = new System.Windows.Forms.CheckBox();
        	this.moveHandlerHideCheckBox = new System.Windows.Forms.CheckBox();
        	this.renameHandlerHideCheckBox = new System.Windows.Forms.CheckBox();
        	this.mainMenuStrip.SuspendLayout();
        	this.mainStatusStrip.SuspendLayout();
        	this.mainTableLayoutPanel.SuspendLayout();
        	this.tableLayoutPanel2.SuspendLayout();
        	this.tableLayoutPanel3.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.copyTableLayoutPanel.SuspendLayout();
        	this.tableLayoutPanel4.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// mainMenuStrip
        	// 
        	this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.optionsToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
        	this.mainMenuStrip.Name = "mainMenuStrip";
        	this.mainMenuStrip.Size = new System.Drawing.Size(404, 24);
        	this.mainMenuStrip.TabIndex = 49;
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem,
        	        	        	this.toolStripSeparator,
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// newToolStripMenuItem
        	// 
        	this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
        	this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(138, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// optionsToolStripMenuItem
        	// 
        	this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.alwaysOnTopToolStripMenuItem,
        	        	        	this.addquotesToolStripMenuItem});
        	this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        	this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
        	this.optionsToolStripMenuItem.Text = "&Options";
        	this.optionsToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnOptionsToolStripMenuItemDropDownItemClicked);
        	// 
        	// alwaysOnTopToolStripMenuItem
        	// 
        	this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
        	this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
        	// 
        	// addquotesToolStripMenuItem
        	// 
        	this.addquotesToolStripMenuItem.Checked = true;
        	this.addquotesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
        	this.addquotesToolStripMenuItem.Name = "addquotesToolStripMenuItem";
        	this.addquotesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.addquotesToolStripMenuItem.Text = "Add &quotes";
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.moreReleasesParadisusisToolStripMenuItem,
        	        	        	this.originalThreadDonationCodercomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// moreReleasesParadisusisToolStripMenuItem
        	// 
        	this.moreReleasesParadisusisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("moreReleasesParadisusisToolStripMenuItem.Image")));
        	this.moreReleasesParadisusisToolStripMenuItem.Name = "moreReleasesParadisusisToolStripMenuItem";
        	this.moreReleasesParadisusisToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
        	this.moreReleasesParadisusisToolStripMenuItem.Text = "More releases @ Paradisus.is";
        	this.moreReleasesParadisusisToolStripMenuItem.Click += new System.EventHandler(this.OnMoreReleasesParadisusisToolStripMenuItemClick);
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
        	        	        	this.statusTextToolStripStatusLabel,
        	        	        	this.statusValueToolStripStatusLabel,
        	        	        	this.toolStripStatusLabel2,
        	        	        	this.dllTextToolStripStatusLabel,
        	        	        	this.dllValueToolStripStatusLabel});
        	this.mainStatusStrip.Location = new System.Drawing.Point(0, 440);
        	this.mainStatusStrip.Name = "mainStatusStrip";
        	this.mainStatusStrip.Size = new System.Drawing.Size(404, 22);
        	this.mainStatusStrip.SizingGrip = false;
        	this.mainStatusStrip.TabIndex = 48;
        	// 
        	// statusTextToolStripStatusLabel
        	// 
        	this.statusTextToolStripStatusLabel.Name = "statusTextToolStripStatusLabel";
        	this.statusTextToolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
        	this.statusTextToolStripStatusLabel.Text = "Status:";
        	// 
        	// statusValueToolStripStatusLabel
        	// 
        	this.statusValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.statusValueToolStripStatusLabel.Name = "statusValueToolStripStatusLabel";
        	this.statusValueToolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
        	this.statusValueToolStripStatusLabel.Text = "checking";
        	// 
        	// toolStripStatusLabel2
        	// 
        	this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
        	this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
        	this.toolStripStatusLabel2.Text = "/";
        	// 
        	// dllTextToolStripStatusLabel
        	// 
        	this.dllTextToolStripStatusLabel.Name = "dllTextToolStripStatusLabel";
        	this.dllTextToolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
        	this.dllTextToolStripStatusLabel.Text = "AnyHandlerHook.dll:";
        	// 
        	// dllValueToolStripStatusLabel
        	// 
        	this.dllValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.dllValueToolStripStatusLabel.Name = "dllValueToolStripStatusLabel";
        	this.dllValueToolStripStatusLabel.Size = new System.Drawing.Size(57, 17);
        	this.dllValueToolStripStatusLabel.Text = "checking";
        	// 
        	// mainTableLayoutPanel
        	// 
        	this.mainTableLayoutPanel.ColumnCount = 1;
        	this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
        	this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 3);
        	this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
        	this.mainTableLayoutPanel.Controls.Add(this.copyTableLayoutPanel, 0, 0);
        	this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 4);
        	this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 24);
        	this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
        	this.mainTableLayoutPanel.RowCount = 5;
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
        	this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.mainTableLayoutPanel.Size = new System.Drawing.Size(404, 416);
        	this.mainTableLayoutPanel.TabIndex = 50;
        	// 
        	// tableLayoutPanel2
        	// 
        	this.tableLayoutPanel2.ColumnCount = 3;
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
        	this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
        	this.tableLayoutPanel2.Controls.Add(this.moveProgramTextBox, 1, 1);
        	this.tableLayoutPanel2.Controls.Add(this.moveArgumentsTextBox, 1, 2);
        	this.tableLayoutPanel2.Controls.Add(this.moveBrowseButton, 2, 1);
        	this.tableLayoutPanel2.Controls.Add(this.moveHandlerLabel, 0, 0);
        	this.tableLayoutPanel2.Controls.Add(this.moveHandlerHideCheckBox, 2, 2);
        	this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 191);
        	this.tableLayoutPanel2.Name = "tableLayoutPanel2";
        	this.tableLayoutPanel2.RowCount = 3;
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 88);
        	this.tableLayoutPanel2.TabIndex = 6;
        	// 
        	// label3
        	// 
        	this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label3.Location = new System.Drawing.Point(3, 30);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(94, 29);
        	this.label3.TabIndex = 1;
        	this.label3.Text = "Program:";
        	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// label4
        	// 
        	this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label4.Location = new System.Drawing.Point(3, 59);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(94, 29);
        	this.label4.TabIndex = 2;
        	this.label4.Text = "Arguments:";
        	this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// moveProgramTextBox
        	// 
        	this.moveProgramTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.moveProgramTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.moveProgramTextBox.Location = new System.Drawing.Point(103, 33);
        	this.moveProgramTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
        	this.moveProgramTextBox.Name = "moveProgramTextBox";
        	this.moveProgramTextBox.Size = new System.Drawing.Size(265, 24);
        	this.moveProgramTextBox.TabIndex = 10;
        	// 
        	// moveArgumentsTextBox
        	// 
        	this.moveArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.moveArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.moveArgumentsTextBox.Location = new System.Drawing.Point(103, 62);
        	this.moveArgumentsTextBox.Name = "moveArgumentsTextBox";
        	this.moveArgumentsTextBox.Size = new System.Drawing.Size(262, 24);
        	this.moveArgumentsTextBox.TabIndex = 12;
        	// 
        	// moveBrowseButton
        	// 
        	this.moveBrowseButton.Location = new System.Drawing.Point(371, 33);
        	this.moveBrowseButton.Name = "moveBrowseButton";
        	this.moveBrowseButton.Size = new System.Drawing.Size(24, 20);
        	this.moveBrowseButton.TabIndex = 11;
        	this.moveBrowseButton.Text = "...";
        	this.moveBrowseButton.UseVisualStyleBackColor = true;
        	this.moveBrowseButton.Click += new System.EventHandler(this.OnMoveBrowseButtonClick);
        	// 
        	// moveHandlerLabel
        	// 
        	this.tableLayoutPanel2.SetColumnSpan(this.moveHandlerLabel, 3);
        	this.moveHandlerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.moveHandlerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.moveHandlerLabel.Location = new System.Drawing.Point(3, 0);
        	this.moveHandlerLabel.Name = "moveHandlerLabel";
        	this.moveHandlerLabel.Size = new System.Drawing.Size(392, 30);
        	this.moveHandlerLabel.TabIndex = 13;
        	this.moveHandlerLabel.Text = "&Move handler:";
        	this.moveHandlerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// tableLayoutPanel3
        	// 
        	this.tableLayoutPanel3.ColumnCount = 3;
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
        	this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
        	this.tableLayoutPanel3.Controls.Add(this.renameProgramTextBox, 1, 1);
        	this.tableLayoutPanel3.Controls.Add(this.renameArgumentsTextBox, 1, 2);
        	this.tableLayoutPanel3.Controls.Add(this.renameBrowseButton, 2, 1);
        	this.tableLayoutPanel3.Controls.Add(this.renameHandlerLabel, 0, 0);
        	this.tableLayoutPanel3.Controls.Add(this.renameHandlerHideCheckBox, 2, 2);
        	this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 285);
        	this.tableLayoutPanel3.Name = "tableLayoutPanel3";
        	this.tableLayoutPanel3.RowCount = 3;
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 88);
        	this.tableLayoutPanel3.TabIndex = 5;
        	// 
        	// label1
        	// 
        	this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(3, 30);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(94, 29);
        	this.label1.TabIndex = 1;
        	this.label1.Text = "Program:";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// label2
        	// 
        	this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label2.Location = new System.Drawing.Point(3, 59);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(94, 29);
        	this.label2.TabIndex = 2;
        	this.label2.Text = "Arguments:";
        	this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// renameProgramTextBox
        	// 
        	this.renameProgramTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.renameProgramTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.renameProgramTextBox.Location = new System.Drawing.Point(103, 33);
        	this.renameProgramTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
        	this.renameProgramTextBox.Name = "renameProgramTextBox";
        	this.renameProgramTextBox.Size = new System.Drawing.Size(265, 24);
        	this.renameProgramTextBox.TabIndex = 14;
        	// 
        	// renameArgumentsTextBox
        	// 
        	this.renameArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.renameArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.renameArgumentsTextBox.Location = new System.Drawing.Point(103, 62);
        	this.renameArgumentsTextBox.Name = "renameArgumentsTextBox";
        	this.renameArgumentsTextBox.Size = new System.Drawing.Size(262, 24);
        	this.renameArgumentsTextBox.TabIndex = 16;
        	// 
        	// renameBrowseButton
        	// 
        	this.renameBrowseButton.Location = new System.Drawing.Point(371, 33);
        	this.renameBrowseButton.Name = "renameBrowseButton";
        	this.renameBrowseButton.Size = new System.Drawing.Size(24, 20);
        	this.renameBrowseButton.TabIndex = 15;
        	this.renameBrowseButton.Text = "...";
        	this.renameBrowseButton.UseVisualStyleBackColor = true;
        	this.renameBrowseButton.Click += new System.EventHandler(this.OnRenameBrowseButtonClick);
        	// 
        	// renameHandlerLabel
        	// 
        	this.tableLayoutPanel3.SetColumnSpan(this.renameHandlerLabel, 3);
        	this.renameHandlerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.renameHandlerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.renameHandlerLabel.Location = new System.Drawing.Point(3, 0);
        	this.renameHandlerLabel.Name = "renameHandlerLabel";
        	this.renameHandlerLabel.Size = new System.Drawing.Size(392, 30);
        	this.renameHandlerLabel.TabIndex = 17;
        	this.renameHandlerLabel.Text = "&Rename handler:";
        	this.renameHandlerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 3;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tableLayoutPanel1.Controls.Add(this.deleteProgramLabel, 0, 1);
        	this.tableLayoutPanel1.Controls.Add(this.deleteArgumentsLabel, 0, 2);
        	this.tableLayoutPanel1.Controls.Add(this.deleteProgramTextBox, 1, 1);
        	this.tableLayoutPanel1.Controls.Add(this.deleteArgumentsTextBox, 1, 2);
        	this.tableLayoutPanel1.Controls.Add(this.deleteBrowseButton, 2, 1);
        	this.tableLayoutPanel1.Controls.Add(this.deleteHandlerLabel, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.deleteHandlerHideCheckBox, 2, 2);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 97);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 3;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 88);
        	this.tableLayoutPanel1.TabIndex = 3;
        	// 
        	// deleteProgramLabel
        	// 
        	this.deleteProgramLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.deleteProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deleteProgramLabel.Location = new System.Drawing.Point(3, 30);
        	this.deleteProgramLabel.Name = "deleteProgramLabel";
        	this.deleteProgramLabel.Size = new System.Drawing.Size(94, 29);
        	this.deleteProgramLabel.TabIndex = 1;
        	this.deleteProgramLabel.Text = "Program:";
        	this.deleteProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// deleteArgumentsLabel
        	// 
        	this.deleteArgumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.deleteArgumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deleteArgumentsLabel.Location = new System.Drawing.Point(3, 59);
        	this.deleteArgumentsLabel.Name = "deleteArgumentsLabel";
        	this.deleteArgumentsLabel.Size = new System.Drawing.Size(94, 29);
        	this.deleteArgumentsLabel.TabIndex = 2;
        	this.deleteArgumentsLabel.Text = "Arguments:";
        	this.deleteArgumentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// deleteProgramTextBox
        	// 
        	this.deleteProgramTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.deleteProgramTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deleteProgramTextBox.Location = new System.Drawing.Point(103, 33);
        	this.deleteProgramTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
        	this.deleteProgramTextBox.Name = "deleteProgramTextBox";
        	this.deleteProgramTextBox.Size = new System.Drawing.Size(265, 24);
        	this.deleteProgramTextBox.TabIndex = 6;
        	// 
        	// deleteArgumentsTextBox
        	// 
        	this.deleteArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.deleteArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.deleteArgumentsTextBox.Location = new System.Drawing.Point(103, 62);
        	this.deleteArgumentsTextBox.Name = "deleteArgumentsTextBox";
        	this.deleteArgumentsTextBox.Size = new System.Drawing.Size(262, 24);
        	this.deleteArgumentsTextBox.TabIndex = 8;
        	// 
        	// deleteBrowseButton
        	// 
        	this.deleteBrowseButton.Location = new System.Drawing.Point(371, 33);
        	this.deleteBrowseButton.Name = "deleteBrowseButton";
        	this.deleteBrowseButton.Size = new System.Drawing.Size(24, 20);
        	this.deleteBrowseButton.TabIndex = 7;
        	this.deleteBrowseButton.Text = "...";
        	this.deleteBrowseButton.UseVisualStyleBackColor = true;
        	this.deleteBrowseButton.Click += new System.EventHandler(this.OnDeleteBrowseButtonClick);
        	// 
        	// deleteHandlerLabel
        	// 
        	this.tableLayoutPanel1.SetColumnSpan(this.deleteHandlerLabel, 3);
        	this.deleteHandlerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.deleteHandlerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.deleteHandlerLabel.Location = new System.Drawing.Point(3, 0);
        	this.deleteHandlerLabel.Name = "deleteHandlerLabel";
        	this.deleteHandlerLabel.Size = new System.Drawing.Size(392, 30);
        	this.deleteHandlerLabel.TabIndex = 9;
        	this.deleteHandlerLabel.Text = "&Delete handler:";
        	this.deleteHandlerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// copyTableLayoutPanel
        	// 
        	this.copyTableLayoutPanel.ColumnCount = 3;
        	this.copyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
        	this.copyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.copyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.copyTableLayoutPanel.Controls.Add(this.copyProgramLabel, 0, 1);
        	this.copyTableLayoutPanel.Controls.Add(this.copyArgumentsLabel, 0, 2);
        	this.copyTableLayoutPanel.Controls.Add(this.copyProgramTextBox, 1, 1);
        	this.copyTableLayoutPanel.Controls.Add(this.copyArgumentsTextBox, 1, 2);
        	this.copyTableLayoutPanel.Controls.Add(this.copyBrowseButton, 2, 1);
        	this.copyTableLayoutPanel.Controls.Add(this.copyHandlerLabel, 0, 0);
        	this.copyTableLayoutPanel.Controls.Add(this.copyHandlerHideCheckBox, 2, 2);
        	this.copyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
        	this.copyTableLayoutPanel.Name = "copyTableLayoutPanel";
        	this.copyTableLayoutPanel.RowCount = 3;
        	this.copyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.copyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.copyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.copyTableLayoutPanel.Size = new System.Drawing.Size(398, 88);
        	this.copyTableLayoutPanel.TabIndex = 0;
        	// 
        	// copyProgramLabel
        	// 
        	this.copyProgramLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.copyProgramLabel.Location = new System.Drawing.Point(3, 30);
        	this.copyProgramLabel.Name = "copyProgramLabel";
        	this.copyProgramLabel.Size = new System.Drawing.Size(94, 29);
        	this.copyProgramLabel.TabIndex = 1;
        	this.copyProgramLabel.Text = "Program:";
        	this.copyProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// copyArgumentsLabel
        	// 
        	this.copyArgumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyArgumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.copyArgumentsLabel.Location = new System.Drawing.Point(3, 59);
        	this.copyArgumentsLabel.Name = "copyArgumentsLabel";
        	this.copyArgumentsLabel.Size = new System.Drawing.Size(94, 29);
        	this.copyArgumentsLabel.TabIndex = 2;
        	this.copyArgumentsLabel.Text = "Arguments:";
        	this.copyArgumentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        	// 
        	// copyProgramTextBox
        	// 
        	this.copyProgramTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyProgramTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.copyProgramTextBox.Location = new System.Drawing.Point(103, 33);
        	this.copyProgramTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
        	this.copyProgramTextBox.Name = "copyProgramTextBox";
        	this.copyProgramTextBox.Size = new System.Drawing.Size(265, 24);
        	this.copyProgramTextBox.TabIndex = 2;
        	// 
        	// copyArgumentsTextBox
        	// 
        	this.copyArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.copyArgumentsTextBox.Location = new System.Drawing.Point(103, 62);
        	this.copyArgumentsTextBox.Name = "copyArgumentsTextBox";
        	this.copyArgumentsTextBox.Size = new System.Drawing.Size(262, 24);
        	this.copyArgumentsTextBox.TabIndex = 4;
        	// 
        	// copyBrowseButton
        	// 
        	this.copyBrowseButton.Location = new System.Drawing.Point(371, 33);
        	this.copyBrowseButton.Name = "copyBrowseButton";
        	this.copyBrowseButton.Size = new System.Drawing.Size(24, 20);
        	this.copyBrowseButton.TabIndex = 3;
        	this.copyBrowseButton.Text = "...";
        	this.copyBrowseButton.UseVisualStyleBackColor = true;
        	this.copyBrowseButton.Click += new System.EventHandler(this.OnCopyBrowseButtonClick);
        	// 
        	// copyHandlerLabel
        	// 
        	this.copyTableLayoutPanel.SetColumnSpan(this.copyHandlerLabel, 3);
        	this.copyHandlerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.copyHandlerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.copyHandlerLabel.Location = new System.Drawing.Point(3, 0);
        	this.copyHandlerLabel.Name = "copyHandlerLabel";
        	this.copyHandlerLabel.Size = new System.Drawing.Size(392, 30);
        	this.copyHandlerLabel.TabIndex = 5;
        	this.copyHandlerLabel.Text = "&Copy handler:";
        	this.copyHandlerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// tableLayoutPanel4
        	// 
        	this.tableLayoutPanel4.ColumnCount = 2;
        	this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel4.Controls.Add(this.addButton, 0, 0);
        	this.tableLayoutPanel4.Controls.Add(this.removeButton, 1, 0);
        	this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 379);
        	this.tableLayoutPanel4.Name = "tableLayoutPanel4";
        	this.tableLayoutPanel4.RowCount = 1;
        	this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel4.Size = new System.Drawing.Size(398, 34);
        	this.tableLayoutPanel4.TabIndex = 7;
        	// 
        	// addButton
        	// 
        	this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.addButton.Location = new System.Drawing.Point(3, 1);
        	this.addButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
        	this.addButton.Name = "addButton";
        	this.addButton.Size = new System.Drawing.Size(193, 32);
        	this.addButton.TabIndex = 0;
        	this.addButton.Text = "&Add to Explorer";
        	this.addButton.UseVisualStyleBackColor = true;
        	this.addButton.Click += new System.EventHandler(this.OnAddButtonClick);
        	// 
        	// removeButton
        	// 
        	this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
        	this.removeButton.Location = new System.Drawing.Point(202, 1);
        	this.removeButton.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
        	this.removeButton.Name = "removeButton";
        	this.removeButton.Size = new System.Drawing.Size(193, 32);
        	this.removeButton.TabIndex = 1;
        	this.removeButton.Text = "&Remove";
        	this.removeButton.UseVisualStyleBackColor = true;
        	this.removeButton.Click += new System.EventHandler(this.OnRemoveButtonClick);
        	// 
        	// openFileDialog
        	// 
        	this.openFileDialog.DefaultExt = "exe";
        	this.openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
        	// 
        	// copyHandlerHideCheckBox
        	// 
        	this.copyHandlerHideCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
        	this.copyHandlerHideCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("copyHandlerHideCheckBox.Image")));
        	this.copyHandlerHideCheckBox.Location = new System.Drawing.Point(371, 62);
        	this.copyHandlerHideCheckBox.Name = "copyHandlerHideCheckBox";
        	this.copyHandlerHideCheckBox.Size = new System.Drawing.Size(24, 23);
        	this.copyHandlerHideCheckBox.TabIndex = 6;
        	this.copyHandlerHideCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// deleteHandlerHideCheckBox
        	// 
        	this.deleteHandlerHideCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
        	this.deleteHandlerHideCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("deleteHandlerHideCheckBox.Image")));
        	this.deleteHandlerHideCheckBox.Location = new System.Drawing.Point(371, 62);
        	this.deleteHandlerHideCheckBox.Name = "deleteHandlerHideCheckBox";
        	this.deleteHandlerHideCheckBox.Size = new System.Drawing.Size(24, 23);
        	this.deleteHandlerHideCheckBox.TabIndex = 10;
        	this.deleteHandlerHideCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// moveHandlerHideCheckBox
        	// 
        	this.moveHandlerHideCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
        	this.moveHandlerHideCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("moveHandlerHideCheckBox.Image")));
        	this.moveHandlerHideCheckBox.Location = new System.Drawing.Point(371, 62);
        	this.moveHandlerHideCheckBox.Name = "moveHandlerHideCheckBox";
        	this.moveHandlerHideCheckBox.Size = new System.Drawing.Size(24, 23);
        	this.moveHandlerHideCheckBox.TabIndex = 14;
        	this.moveHandlerHideCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// renameHandlerHideCheckBox
        	// 
        	this.renameHandlerHideCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
        	this.renameHandlerHideCheckBox.Image = ((System.Drawing.Image)(resources.GetObject("renameHandlerHideCheckBox.Image")));
        	this.renameHandlerHideCheckBox.Location = new System.Drawing.Point(371, 62);
        	this.renameHandlerHideCheckBox.Name = "renameHandlerHideCheckBox";
        	this.renameHandlerHideCheckBox.Size = new System.Drawing.Size(24, 23);
        	this.renameHandlerHideCheckBox.TabIndex = 18;
        	this.renameHandlerHideCheckBox.UseVisualStyleBackColor = true;
        	// 
        	// MainForm
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(404, 462);
        	this.Controls.Add(this.mainTableLayoutPanel);
        	this.Controls.Add(this.mainMenuStrip);
        	this.Controls.Add(this.mainStatusStrip);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "AnyHandler";
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnMainFormFormClosing);
        	this.Load += new System.EventHandler(this.OnMainFormLoad);
        	this.mainMenuStrip.ResumeLayout(false);
        	this.mainMenuStrip.PerformLayout();
        	this.mainStatusStrip.ResumeLayout(false);
        	this.mainStatusStrip.PerformLayout();
        	this.mainTableLayoutPanel.ResumeLayout(false);
        	this.tableLayoutPanel2.ResumeLayout(false);
        	this.tableLayoutPanel2.PerformLayout();
        	this.tableLayoutPanel3.ResumeLayout(false);
        	this.tableLayoutPanel3.PerformLayout();
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel1.PerformLayout();
        	this.copyTableLayoutPanel.ResumeLayout(false);
        	this.copyTableLayoutPanel.PerformLayout();
        	this.tableLayoutPanel4.ResumeLayout(false);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.CheckBox copyHandlerHideCheckBox;
        private System.Windows.Forms.CheckBox deleteHandlerHideCheckBox;
        private System.Windows.Forms.CheckBox renameHandlerHideCheckBox;
        private System.Windows.Forms.CheckBox moveHandlerHideCheckBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label renameHandlerLabel;
        private System.Windows.Forms.Label deleteHandlerLabel;
        private System.Windows.Forms.Label moveHandlerLabel;
        private System.Windows.Forms.Label copyHandlerLabel;
        private System.Windows.Forms.ToolStripMenuItem addquotesToolStripMenuItem;
        private System.Windows.Forms.Button renameBrowseButton;
        private System.Windows.Forms.TextBox renameArgumentsTextBox;
        private System.Windows.Forms.TextBox renameProgramTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button moveBrowseButton;
        private System.Windows.Forms.TextBox moveArgumentsTextBox;
        private System.Windows.Forms.TextBox moveProgramTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button copyBrowseButton;
        private System.Windows.Forms.TextBox copyArgumentsTextBox;
        private System.Windows.Forms.TextBox copyProgramTextBox;
        private System.Windows.Forms.Label copyArgumentsLabel;
        private System.Windows.Forms.Label copyProgramLabel;
        private System.Windows.Forms.TableLayoutPanel copyTableLayoutPanel;
        private System.Windows.Forms.Button deleteBrowseButton;
        private System.Windows.Forms.TextBox deleteArgumentsTextBox;
        private System.Windows.Forms.TextBox deleteProgramTextBox;
        private System.Windows.Forms.Label deleteArgumentsLabel;
        private System.Windows.Forms.Label deleteProgramLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel dllValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dllTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel statusTextToolStripStatusLabel;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originalThreadDonationCodercomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreReleasesParadisusisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
