
namespace ReactStudio
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMainClass = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.treeFolder = new System.Windows.Forms.TreeView();
            this.imageListTree = new System.Windows.Forms.ImageList(this.components);
            this.treeFiles = new System.Windows.Forms.TreeView();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnConfig = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            this.btnRun = new Guna.UI2.WinForms.Guna2Button();
            this.btnWrap = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangeFont = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenOutputFolder = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnOpenTextInputFile = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.flowLayoutError = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.progressLoad = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextOutput = new System.Windows.Forms.RichTextBox();
            this.timerToShowFiles = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.guna2GradientPanel3.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.guna2Panel1.Controls.Add(this.lblMainClass);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1481, 104);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblMainClass
            // 
            this.lblMainClass.AllowDrop = true;
            this.lblMainClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainClass.AutoEllipsis = true;
            this.lblMainClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.lblMainClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ReactStudio.Properties.Settings.Default, "MAIN_CLASS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblMainClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainClass.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblMainClass.Location = new System.Drawing.Point(572, 65);
            this.lblMainClass.Name = "lblMainClass";
            this.lblMainClass.Size = new System.Drawing.Size(662, 22);
            this.lblMainClass.TabIndex = 23;
            this.lblMainClass.Text = global::ReactStudio.Properties.Settings.Default.MAIN_CLASS;
            this.lblMainClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(417, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Java Main Class:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnAbout);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.pictureBoxIcon);
            this.guna2Panel2.Controls.Add(this.btnMinimize);
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1481, 49);
            this.guna2Panel2.TabIndex = 4;
            this.guna2Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.guna2Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.guna2Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // btnAbout
            // 
            this.btnAbout.Animated = true;
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAbout.FillColor = System.Drawing.Color.Transparent;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = global::ReactStudio.Properties.Resources.Info_52px;
            this.btnAbout.Location = new System.Drawing.Point(1277, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(68, 49);
            this.btnAbout.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnAbout, "About");
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 49);
            this.label5.TabIndex = 12;
            this.label5.Text = "ReactStudio Software";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.label5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBoxIcon.Image = global::ReactStudio.Properties.Resources.icons8_Source_Code;
            this.pictureBoxIcon.ImageRotate = 0F;
            this.pictureBoxIcon.Location = new System.Drawing.Point(14, 3);
            this.pictureBoxIcon.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Padding = new System.Windows.Forms.Padding(7);
            this.pictureBoxIcon.Size = new System.Drawing.Size(50, 49);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIcon.TabIndex = 11;
            this.pictureBoxIcon.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Animated = true;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::ReactStudio.Properties.Resources.Minimize_Window_50px;
            this.btnMinimize.Location = new System.Drawing.Point(1345, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(68, 49);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Animated = true;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnExit.Image = global::ReactStudio.Properties.Resources.Delete_52px;
            this.btnExit.Location = new System.Drawing.Point(1413, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(68, 49);
            this.btnExit.TabIndex = 2;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 842);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1481, 29);
            this.guna2Panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Consolas", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Version: 1.0.0.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.guna2GradientPanel3.Controls.Add(this.treeFolder);
            this.guna2GradientPanel3.Controls.Add(this.treeFiles);
            this.guna2GradientPanel3.Controls.Add(this.guna2Panel6);
            this.guna2GradientPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(0, 104);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.guna2GradientPanel3.Size = new System.Drawing.Size(293, 738);
            this.guna2GradientPanel3.TabIndex = 11;
            // 
            // treeFolder
            // 
            this.treeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.treeFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFolder.ForeColor = System.Drawing.Color.White;
            this.treeFolder.ImageKey = "Folder_16px.png";
            this.treeFolder.ImageList = this.imageListTree;
            this.treeFolder.LineColor = System.Drawing.Color.White;
            this.treeFolder.Location = new System.Drawing.Point(14, 383);
            this.treeFolder.Name = "treeFolder";
            this.treeFolder.SelectedImageIndex = 0;
            this.treeFolder.Size = new System.Drawing.Size(266, 342);
            this.treeFolder.TabIndex = 2;
            this.treeFolder.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeFolder_AfterSelect);
            // 
            // imageListTree
            // 
            this.imageListTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTree.ImageStream")));
            this.imageListTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTree.Images.SetKeyName(0, "Folder_16px.png");
            this.imageListTree.Images.SetKeyName(1, "HTML Filetype_16px.png");
            this.imageListTree.Images.SetKeyName(2, "Bug_16.png");
            // 
            // treeFiles
            // 
            this.treeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.treeFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeFiles.ForeColor = System.Drawing.Color.White;
            this.treeFiles.ImageIndex = 1;
            this.treeFiles.ImageList = this.imageListTree;
            this.treeFiles.LineColor = System.Drawing.Color.White;
            this.treeFiles.Location = new System.Drawing.Point(14, 70);
            this.treeFiles.Name = "treeFiles";
            this.treeFiles.SelectedImageIndex = 1;
            this.treeFiles.Size = new System.Drawing.Size(266, 295);
            this.treeFiles.TabIndex = 1;
            this.treeFiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.Controls.Add(this.btnConfig);
            this.guna2Panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel6.Location = new System.Drawing.Point(10, 10);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.Size = new System.Drawing.Size(273, 51);
            this.guna2Panel6.TabIndex = 0;
            // 
            // btnConfig
            // 
            this.btnConfig.Animated = true;
            this.btnConfig.BorderRadius = 8;
            this.btnConfig.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfig.ForeColor = System.Drawing.Color.White;
            this.btnConfig.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnConfig.Image = global::ReactStudio.Properties.Resources.Settings_48px;
            this.btnConfig.ImageSize = new System.Drawing.Size(25, 25);
            this.btnConfig.Location = new System.Drawing.Point(11, 5);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(45, 40);
            this.btnConfig.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnConfig, "Configuration");
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click_1);
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.guna2Panel5.Controls.Add(this.btnReset);
            this.guna2Panel5.Controls.Add(this.btnRun);
            this.guna2Panel5.Controls.Add(this.btnWrap);
            this.guna2Panel5.Controls.Add(this.btnChangeFont);
            this.guna2Panel5.Controls.Add(this.btnOpenOutputFolder);
            this.guna2Panel5.Controls.Add(this.btnStart);
            this.guna2Panel5.Controls.Add(this.btnOpenTextInputFile);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.guna2Panel5.Location = new System.Drawing.Point(293, 104);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(1188, 69);
            this.guna2Panel5.TabIndex = 14;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Animated = true;
            this.btnReset.BorderRadius = 6;
            this.btnReset.FillColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = global::ReactStudio.Properties.Resources.Reset_35px;
            this.btnReset.ImageSize = new System.Drawing.Size(34, 34);
            this.btnReset.Location = new System.Drawing.Point(460, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(45, 40);
            this.btnReset.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnReset, "Reset Font Default");
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.Animated = true;
            this.btnRun.BorderRadius = 6;
            this.btnRun.FillColor = System.Drawing.Color.Transparent;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRun.ForeColor = System.Drawing.Color.White;
            this.btnRun.Image = global::ReactStudio.Properties.Resources.Website_40px;
            this.btnRun.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRun.Location = new System.Drawing.Point(792, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(45, 40);
            this.btnRun.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnRun, "Render");
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnWrap
            // 
            this.btnWrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWrap.Animated = true;
            this.btnWrap.BorderRadius = 6;
            this.btnWrap.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnWrap.Checked = global::ReactStudio.Properties.Settings.Default.TEXT_WRAP;
            this.btnWrap.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::ReactStudio.Properties.Settings.Default, "TEXT_WRAP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.btnWrap.FillColor = System.Drawing.Color.Transparent;
            this.btnWrap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWrap.ForeColor = System.Drawing.Color.White;
            this.btnWrap.Image = global::ReactStudio.Properties.Resources.Text_Width_35px;
            this.btnWrap.ImageSize = new System.Drawing.Size(35, 35);
            this.btnWrap.Location = new System.Drawing.Point(678, 12);
            this.btnWrap.Name = "btnWrap";
            this.btnWrap.Size = new System.Drawing.Size(45, 40);
            this.btnWrap.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnWrap, "Wrap Text");
            this.btnWrap.Click += new System.EventHandler(this.btnWrap_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeFont.Animated = true;
            this.btnChangeFont.BorderRadius = 6;
            this.btnChangeFont.FillColor = System.Drawing.Color.Transparent;
            this.btnChangeFont.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChangeFont.ForeColor = System.Drawing.Color.White;
            this.btnChangeFont.Image = global::ReactStudio.Properties.Resources.Font_Style_Formatting_35px;
            this.btnChangeFont.ImageSize = new System.Drawing.Size(32, 32);
            this.btnChangeFont.Location = new System.Drawing.Point(569, 12);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(45, 40);
            this.btnChangeFont.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnChangeFont, "Change Font");
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnOpenOutputFolder
            // 
            this.btnOpenOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenOutputFolder.Animated = true;
            this.btnOpenOutputFolder.BorderRadius = 6;
            this.btnOpenOutputFolder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnOpenOutputFolder.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOutputFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenOutputFolder.Image = global::ReactStudio.Properties.Resources.Open_52px;
            this.btnOpenOutputFolder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnOpenOutputFolder.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOpenOutputFolder.Location = new System.Drawing.Point(933, 12);
            this.btnOpenOutputFolder.Name = "btnOpenOutputFolder";
            this.btnOpenOutputFolder.Size = new System.Drawing.Size(236, 40);
            this.btnOpenOutputFolder.TabIndex = 3;
            this.btnOpenOutputFolder.Text = "Open Output Folder";
            this.btnOpenOutputFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.btnOpenOutputFolder, "Open Output Folder");
            this.btnOpenOutputFolder.Click += new System.EventHandler(this.btnOpenOutputFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.BorderRadius = 6;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnStart.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnStart.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStart.Location = new System.Drawing.Point(17, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(225, 40);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Processing";
            this.btnStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.toolTip1.SetToolTip(this.btnStart, "Start Converting Input To React");
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnOpenTextInputFile
            // 
            this.btnOpenTextInputFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenTextInputFile.Animated = true;
            this.btnOpenTextInputFile.BorderRadius = 6;
            this.btnOpenTextInputFile.FillColor = System.Drawing.Color.Transparent;
            this.btnOpenTextInputFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOpenTextInputFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenTextInputFile.Image = global::ReactStudio.Properties.Resources.Code_File_35px;
            this.btnOpenTextInputFile.ImageSize = new System.Drawing.Size(35, 35);
            this.btnOpenTextInputFile.Location = new System.Drawing.Point(351, 12);
            this.btnOpenTextInputFile.Name = "btnOpenTextInputFile";
            this.btnOpenTextInputFile.Size = new System.Drawing.Size(45, 40);
            this.btnOpenTextInputFile.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnOpenTextInputFile, "Open Input File");
            this.btnOpenTextInputFile.Click += new System.EventHandler(this.btnOpenTextInputFile_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.flowLayoutError);
            this.guna2Panel4.Controls.Add(this.label4);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel4.Location = new System.Drawing.Point(293, 648);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(1);
            this.guna2Panel4.Size = new System.Drawing.Size(1188, 194);
            this.guna2Panel4.TabIndex = 15;
            // 
            // flowLayoutError
            // 
            this.flowLayoutError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutError.AutoScroll = true;
            this.flowLayoutError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flowLayoutError.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutError.Location = new System.Drawing.Point(6, 47);
            this.flowLayoutError.Name = "flowLayoutError";
            this.flowLayoutError.Size = new System.Drawing.Size(1177, 135);
            this.flowLayoutError.TabIndex = 5;
            this.flowLayoutError.WrapContents = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 4);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.label4.Size = new System.Drawing.Size(139, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exceptions:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(293, 173);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextInput);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 350;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressLoad);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.richTextOutput);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(1188, 475);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.SplitterWidth = 10;
            this.splitContainer1.TabIndex = 16;
            // 
            // richTextInput
            // 
            this.richTextInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.richTextInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextInput.DataBindings.Add(new System.Windows.Forms.Binding("WordWrap", global::ReactStudio.Properties.Settings.Default, "TEXT_WRAP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richTextInput.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::ReactStudio.Properties.Settings.Default, "FONT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richTextInput.Font = global::ReactStudio.Properties.Settings.Default.FONT;
            this.richTextInput.ForeColor = System.Drawing.Color.White;
            this.richTextInput.Location = new System.Drawing.Point(14, 62);
            this.richTextInput.Name = "richTextInput";
            this.richTextInput.Size = new System.Drawing.Size(562, 405);
            this.richTextInput.TabIndex = 4;
            this.richTextInput.Text = "";
            this.richTextInput.WordWrap = global::ReactStudio.Properties.Settings.Default.TEXT_WRAP;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressLoad
            // 
            this.progressLoad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressLoad.AutoStart = true;
            this.progressLoad.CircleSize = 1F;
            this.progressLoad.Location = new System.Drawing.Point(243, 189);
            this.progressLoad.Name = "progressLoad";
            this.progressLoad.ProgressColor = System.Drawing.Color.White;
            this.progressLoad.Size = new System.Drawing.Size(96, 96);
            this.progressLoad.TabIndex = 1;
            this.progressLoad.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(579, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selected Output";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextOutput
            // 
            this.richTextOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.richTextOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextOutput.DataBindings.Add(new System.Windows.Forms.Binding("WordWrap", global::ReactStudio.Properties.Settings.Default, "TEXT_WRAP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richTextOutput.DataBindings.Add(new System.Windows.Forms.Binding("Font", global::ReactStudio.Properties.Settings.Default, "FONT", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.richTextOutput.Font = global::ReactStudio.Properties.Settings.Default.FONT;
            this.richTextOutput.ForeColor = System.Drawing.Color.White;
            this.richTextOutput.Location = new System.Drawing.Point(10, 62);
            this.richTextOutput.Name = "richTextOutput";
            this.richTextOutput.Size = new System.Drawing.Size(562, 405);
            this.richTextOutput.TabIndex = 5;
            this.richTextOutput.Text = "";
            this.richTextOutput.WordWrap = global::ReactStudio.Properties.Settings.Default.TEXT_WRAP;
            // 
            // timerToShowFiles
            // 
            this.timerToShowFiles.Interval = 1000;
            this.timerToShowFiles.Tick += new System.EventHandler(this.timerToShowFiles_Tick);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1481, 871);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel5);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReactStudio Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2GradientPanel3.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxIcon;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Button btnConfig;
        private Guna.UI2.WinForms.Guna2Button btnReset;
        private Guna.UI2.WinForms.Guna2Button btnWrap;
        private Guna.UI2.WinForms.Guna2Button btnChangeFont;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.TreeView treeFiles;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextInput;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator progressLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutError;
        private System.Windows.Forms.RichTextBox richTextOutput;
        private Guna.UI2.WinForms.Guna2Button btnOpenOutputFolder;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnOpenTextInputFile;
        private System.Windows.Forms.TreeView treeFolder;
        private System.Windows.Forms.Timer timerToShowFiles;
        private System.Windows.Forms.ImageList imageListTree;
        private System.Windows.Forms.Label lblMainClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnRun;
    }
}

