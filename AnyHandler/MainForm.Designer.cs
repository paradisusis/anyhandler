
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
            this.removeHandlersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.copyTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.copyValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.deleteTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.deletecopyValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.moveTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.movecopyValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.renameTextToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.renamecopyValueToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.moveHandlerCheckBox = new System.Windows.Forms.CheckBox();
            this.moveProgramTextBox = new System.Windows.Forms.TextBox();
            this.moveArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.moveBrowseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.renameHandlerCheckBox = new System.Windows.Forms.CheckBox();
            this.renameProgramTextBox = new System.Windows.Forms.TextBox();
            this.renameArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.renameBrowseButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.deleteProgramLabel = new System.Windows.Forms.Label();
            this.deleteArgumentsLabel = new System.Windows.Forms.Label();
            this.deleteHandlerCheckBox = new System.Windows.Forms.CheckBox();
            this.deleteProgramTextBox = new System.Windows.Forms.TextBox();
            this.deleteArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.deleteBrowseButton = new System.Windows.Forms.Button();
            this.copyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.copyProgramLabel = new System.Windows.Forms.Label();
            this.copyArgumentsLabel = new System.Windows.Forms.Label();
            this.copyHandlerCheckBox = new System.Windows.Forms.CheckBox();
            this.copyProgramTextBox = new System.Windows.Forms.TextBox();
            this.copyArgumentsTextBox = new System.Windows.Forms.TextBox();
            this.copyBrowseButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.copyTableLayoutPanel.SuspendLayout();
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
                                    this.removeHandlersToolStripMenuItem,
                                    this.toolStripSeparator1,
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
            this.newToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(162, 6);
            // 
            // removeHandlersToolStripMenuItem
            // 
            this.removeHandlersToolStripMenuItem.Name = "removeHandlersToolStripMenuItem";
            this.removeHandlersToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.removeHandlersToolStripMenuItem.Text = "&Remove handlers";
            this.removeHandlersToolStripMenuItem.Click += new System.EventHandler(this.OnRemoveHandlersToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
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
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always on top";
            // 
            // addquotesToolStripMenuItem
            // 
            this.addquotesToolStripMenuItem.Checked = true;
            this.addquotesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.addquotesToolStripMenuItem.Name = "addquotesToolStripMenuItem";
            this.addquotesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
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
                                    this.copyTextToolStripStatusLabel,
                                    this.copyValueToolStripStatusLabel,
                                    this.toolStripStatusLabel2,
                                    this.deleteTextToolStripStatusLabel,
                                    this.deletecopyValueToolStripStatusLabel,
                                    this.toolStripStatusLabel3,
                                    this.moveTextToolStripStatusLabel,
                                    this.movecopyValueToolStripStatusLabel,
                                    this.toolStripStatusLabel8,
                                    this.renameTextToolStripStatusLabel,
                                    this.renamecopyValueToolStripStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 435);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(404, 22);
            this.mainStatusStrip.SizingGrip = false;
            this.mainStatusStrip.TabIndex = 48;
            // 
            // copyTextToolStripStatusLabel
            // 
            this.copyTextToolStripStatusLabel.Name = "copyTextToolStripStatusLabel";
            this.copyTextToolStripStatusLabel.Size = new System.Drawing.Size(38, 17);
            this.copyTextToolStripStatusLabel.Text = "Copy:";
            // 
            // copyValueToolStripStatusLabel
            // 
            this.copyValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyValueToolStripStatusLabel.Name = "copyValueToolStripStatusLabel";
            this.copyValueToolStripStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.copyValueToolStripStatusLabel.Text = "false";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel2.Text = "/";
            // 
            // deleteTextToolStripStatusLabel
            // 
            this.deleteTextToolStripStatusLabel.Name = "deleteTextToolStripStatusLabel";
            this.deleteTextToolStripStatusLabel.Size = new System.Drawing.Size(43, 17);
            this.deleteTextToolStripStatusLabel.Text = "Delete:";
            // 
            // deletecopyValueToolStripStatusLabel
            // 
            this.deletecopyValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecopyValueToolStripStatusLabel.Name = "deletecopyValueToolStripStatusLabel";
            this.deletecopyValueToolStripStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.deletecopyValueToolStripStatusLabel.Text = "false";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel3.Text = "/";
            // 
            // moveTextToolStripStatusLabel
            // 
            this.moveTextToolStripStatusLabel.Name = "moveTextToolStripStatusLabel";
            this.moveTextToolStripStatusLabel.Size = new System.Drawing.Size(40, 17);
            this.moveTextToolStripStatusLabel.Text = "Move:";
            // 
            // movecopyValueToolStripStatusLabel
            // 
            this.movecopyValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movecopyValueToolStripStatusLabel.Name = "movecopyValueToolStripStatusLabel";
            this.movecopyValueToolStripStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.movecopyValueToolStripStatusLabel.Text = "false";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel8.Text = "/";
            // 
            // renameTextToolStripStatusLabel
            // 
            this.renameTextToolStripStatusLabel.Name = "renameTextToolStripStatusLabel";
            this.renameTextToolStripStatusLabel.Size = new System.Drawing.Size(53, 17);
            this.renameTextToolStripStatusLabel.Text = "Rename:";
            // 
            // renamecopyValueToolStripStatusLabel
            // 
            this.renamecopyValueToolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renamecopyValueToolStripStatusLabel.Name = "renamecopyValueToolStripStatusLabel";
            this.renamecopyValueToolStripStatusLabel.Size = new System.Drawing.Size(33, 17);
            this.renamecopyValueToolStripStatusLabel.Text = "false";
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.copyTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.processButton, 0, 4);
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
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(404, 411);
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
            this.tableLayoutPanel2.Controls.Add(this.moveHandlerCheckBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.moveProgramTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.moveArgumentsTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.moveBrowseButton, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 187);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(398, 86);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Program:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Arguments:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // moveHandlerCheckBox
            // 
            this.moveHandlerCheckBox.Checked = true;
            this.moveHandlerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel2.SetColumnSpan(this.moveHandlerCheckBox, 3);
            this.moveHandlerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveHandlerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveHandlerCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.moveHandlerCheckBox.Location = new System.Drawing.Point(3, 3);
            this.moveHandlerCheckBox.Name = "moveHandlerCheckBox";
            this.moveHandlerCheckBox.Size = new System.Drawing.Size(392, 24);
            this.moveHandlerCheckBox.TabIndex = 9;
            this.moveHandlerCheckBox.Text = "&Move handler:";
            this.moveHandlerCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.moveHandlerCheckBox.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.SetColumnSpan(this.moveArgumentsTextBox, 2);
            this.moveArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moveArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveArgumentsTextBox.Location = new System.Drawing.Point(103, 61);
            this.moveArgumentsTextBox.Name = "moveArgumentsTextBox";
            this.moveArgumentsTextBox.Size = new System.Drawing.Size(292, 24);
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.renameHandlerCheckBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.renameProgramTextBox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.renameArgumentsTextBox, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.renameBrowseButton, 2, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 279);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(398, 86);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arguments:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // renameHandlerCheckBox
            // 
            this.renameHandlerCheckBox.Checked = true;
            this.renameHandlerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel3.SetColumnSpan(this.renameHandlerCheckBox, 3);
            this.renameHandlerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renameHandlerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameHandlerCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.renameHandlerCheckBox.Location = new System.Drawing.Point(3, 3);
            this.renameHandlerCheckBox.Name = "renameHandlerCheckBox";
            this.renameHandlerCheckBox.Size = new System.Drawing.Size(392, 24);
            this.renameHandlerCheckBox.TabIndex = 13;
            this.renameHandlerCheckBox.Text = "&Rename handler:";
            this.renameHandlerCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.renameHandlerCheckBox.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel3.SetColumnSpan(this.renameArgumentsTextBox, 2);
            this.renameArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.renameArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameArgumentsTextBox.Location = new System.Drawing.Point(103, 61);
            this.renameArgumentsTextBox.Name = "renameArgumentsTextBox";
            this.renameArgumentsTextBox.Size = new System.Drawing.Size(292, 24);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Controls.Add(this.deleteProgramLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteArgumentsLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.deleteHandlerCheckBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.deleteProgramTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteArgumentsTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.deleteBrowseButton, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 86);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // deleteProgramLabel
            // 
            this.deleteProgramLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProgramLabel.Location = new System.Drawing.Point(3, 30);
            this.deleteProgramLabel.Name = "deleteProgramLabel";
            this.deleteProgramLabel.Size = new System.Drawing.Size(94, 28);
            this.deleteProgramLabel.TabIndex = 1;
            this.deleteProgramLabel.Text = "Program:";
            this.deleteProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteArgumentsLabel
            // 
            this.deleteArgumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteArgumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteArgumentsLabel.Location = new System.Drawing.Point(3, 58);
            this.deleteArgumentsLabel.Name = "deleteArgumentsLabel";
            this.deleteArgumentsLabel.Size = new System.Drawing.Size(94, 28);
            this.deleteArgumentsLabel.TabIndex = 2;
            this.deleteArgumentsLabel.Text = "Arguments:";
            this.deleteArgumentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // deleteHandlerCheckBox
            // 
            this.deleteHandlerCheckBox.Checked = true;
            this.deleteHandlerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel1.SetColumnSpan(this.deleteHandlerCheckBox, 3);
            this.deleteHandlerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteHandlerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteHandlerCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteHandlerCheckBox.Location = new System.Drawing.Point(3, 3);
            this.deleteHandlerCheckBox.Name = "deleteHandlerCheckBox";
            this.deleteHandlerCheckBox.Size = new System.Drawing.Size(392, 24);
            this.deleteHandlerCheckBox.TabIndex = 5;
            this.deleteHandlerCheckBox.Text = "&Delete handler:";
            this.deleteHandlerCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteHandlerCheckBox.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.SetColumnSpan(this.deleteArgumentsTextBox, 2);
            this.deleteArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteArgumentsTextBox.Location = new System.Drawing.Point(103, 61);
            this.deleteArgumentsTextBox.Name = "deleteArgumentsTextBox";
            this.deleteArgumentsTextBox.Size = new System.Drawing.Size(292, 24);
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
            // copyTableLayoutPanel
            // 
            this.copyTableLayoutPanel.ColumnCount = 3;
            this.copyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.copyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.copyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.copyTableLayoutPanel.Controls.Add(this.copyProgramLabel, 0, 1);
            this.copyTableLayoutPanel.Controls.Add(this.copyArgumentsLabel, 0, 2);
            this.copyTableLayoutPanel.Controls.Add(this.copyHandlerCheckBox, 0, 0);
            this.copyTableLayoutPanel.Controls.Add(this.copyProgramTextBox, 1, 1);
            this.copyTableLayoutPanel.Controls.Add(this.copyArgumentsTextBox, 1, 2);
            this.copyTableLayoutPanel.Controls.Add(this.copyBrowseButton, 2, 1);
            this.copyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.copyTableLayoutPanel.Name = "copyTableLayoutPanel";
            this.copyTableLayoutPanel.RowCount = 3;
            this.copyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.copyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.copyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.copyTableLayoutPanel.Size = new System.Drawing.Size(398, 86);
            this.copyTableLayoutPanel.TabIndex = 0;
            // 
            // copyProgramLabel
            // 
            this.copyProgramLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyProgramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyProgramLabel.Location = new System.Drawing.Point(3, 30);
            this.copyProgramLabel.Name = "copyProgramLabel";
            this.copyProgramLabel.Size = new System.Drawing.Size(94, 28);
            this.copyProgramLabel.TabIndex = 1;
            this.copyProgramLabel.Text = "Program:";
            this.copyProgramLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // copyArgumentsLabel
            // 
            this.copyArgumentsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyArgumentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyArgumentsLabel.Location = new System.Drawing.Point(3, 58);
            this.copyArgumentsLabel.Name = "copyArgumentsLabel";
            this.copyArgumentsLabel.Size = new System.Drawing.Size(94, 28);
            this.copyArgumentsLabel.TabIndex = 2;
            this.copyArgumentsLabel.Text = "Arguments:";
            this.copyArgumentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // copyHandlerCheckBox
            // 
            this.copyHandlerCheckBox.Checked = true;
            this.copyHandlerCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyTableLayoutPanel.SetColumnSpan(this.copyHandlerCheckBox, 3);
            this.copyHandlerCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyHandlerCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyHandlerCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.copyHandlerCheckBox.Location = new System.Drawing.Point(3, 3);
            this.copyHandlerCheckBox.Name = "copyHandlerCheckBox";
            this.copyHandlerCheckBox.Size = new System.Drawing.Size(392, 24);
            this.copyHandlerCheckBox.TabIndex = 1;
            this.copyHandlerCheckBox.Text = "&Copy handler:";
            this.copyHandlerCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.copyHandlerCheckBox.UseVisualStyleBackColor = true;
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
            this.copyTableLayoutPanel.SetColumnSpan(this.copyArgumentsTextBox, 2);
            this.copyArgumentsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyArgumentsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyArgumentsTextBox.Location = new System.Drawing.Point(103, 61);
            this.copyArgumentsTextBox.Name = "copyArgumentsTextBox";
            this.copyArgumentsTextBox.Size = new System.Drawing.Size(292, 24);
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
            // processButton
            // 
            this.processButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processButton.Location = new System.Drawing.Point(3, 371);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(398, 37);
            this.processButton.TabIndex = 0;
            this.processButton.Text = "&Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.OnProcessButtonClick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "exe";
            this.openFileDialog.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 457);
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
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.ToolStripMenuItem addquotesToolStripMenuItem;
        private System.Windows.Forms.Button renameBrowseButton;
        private System.Windows.Forms.TextBox renameArgumentsTextBox;
        private System.Windows.Forms.TextBox renameProgramTextBox;
        private System.Windows.Forms.CheckBox renameHandlerCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button moveBrowseButton;
        private System.Windows.Forms.TextBox moveArgumentsTextBox;
        private System.Windows.Forms.TextBox moveProgramTextBox;
        private System.Windows.Forms.CheckBox moveHandlerCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ToolStripStatusLabel renamecopyValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel renameTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel movecopyValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel moveTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Button copyBrowseButton;
        private System.Windows.Forms.TextBox copyArgumentsTextBox;
        private System.Windows.Forms.TextBox copyProgramTextBox;
        private System.Windows.Forms.CheckBox copyHandlerCheckBox;
        private System.Windows.Forms.Label copyArgumentsLabel;
        private System.Windows.Forms.Label copyProgramLabel;
        private System.Windows.Forms.TableLayoutPanel copyTableLayoutPanel;
        private System.Windows.Forms.Button deleteBrowseButton;
        private System.Windows.Forms.TextBox deleteArgumentsTextBox;
        private System.Windows.Forms.TextBox deleteProgramTextBox;
        private System.Windows.Forms.CheckBox deleteHandlerCheckBox;
        private System.Windows.Forms.Label deleteArgumentsLabel;
        private System.Windows.Forms.Label deleteProgramLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.ToolStripStatusLabel deletecopyValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel deleteTextToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel copyValueToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel copyTextToolStripStatusLabel;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeHandlersToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
    }
}
