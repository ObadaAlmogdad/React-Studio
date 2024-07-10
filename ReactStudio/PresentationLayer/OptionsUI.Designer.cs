
namespace ReactStudio.PresentationLayer
{
    partial class OptionsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsUI));
            this.label3 = new System.Windows.Forms.Label();
            this.btnChange = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnAntlr = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnJava = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnMainClass = new Guna.UI2.WinForms.Guna2Button();
            this.lblMainClass = new System.Windows.Forms.Label();
            this.lblJava = new System.Windows.Forms.Label();
            this.lblAntlr = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(20, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Default Output Folder:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Animated = true;
            this.btnChange.AutoRoundedCorners = true;
            this.btnChange.BorderRadius = 15;
            this.btnChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(789, 364);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(101, 33);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Change";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.btnClose);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(908, 52);
            this.guna2Panel1.TabIndex = 17;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 52);
            this.label5.TabIndex = 19;
            this.label5.Text = "Configuration";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.Image = global::ReactStudio.Properties.Resources.Delete_52px;
            this.btnClose.Location = new System.Drawing.Point(847, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(61, 52);
            this.btnClose.TabIndex = 18;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAntlr
            // 
            this.btnAntlr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAntlr.Animated = true;
            this.btnAntlr.AutoRoundedCorners = true;
            this.btnAntlr.BorderRadius = 15;
            this.btnAntlr.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnAntlr.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAntlr.ForeColor = System.Drawing.Color.White;
            this.btnAntlr.Location = new System.Drawing.Point(789, 293);
            this.btnAntlr.Name = "btnAntlr";
            this.btnAntlr.Size = new System.Drawing.Size(101, 33);
            this.btnAntlr.TabIndex = 20;
            this.btnAntlr.Text = "Change";
            this.btnAntlr.Click += new System.EventHandler(this.btnAntlr_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(20, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Antlr JAR library Path:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnJava
            // 
            this.btnJava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJava.Animated = true;
            this.btnJava.AutoRoundedCorners = true;
            this.btnJava.BorderRadius = 15;
            this.btnJava.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnJava.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnJava.ForeColor = System.Drawing.Color.White;
            this.btnJava.Location = new System.Drawing.Point(789, 214);
            this.btnJava.Name = "btnJava";
            this.btnJava.Size = new System.Drawing.Size(101, 33);
            this.btnJava.TabIndex = 23;
            this.btnJava.Text = "Change";
            this.btnJava.Click += new System.EventHandler(this.btnJava_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(20, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Java Runtime Path:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(20, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Java Main Class:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMainClass
            // 
            this.btnMainClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMainClass.Animated = true;
            this.btnMainClass.AutoRoundedCorners = true;
            this.btnMainClass.BorderRadius = 15;
            this.btnMainClass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.btnMainClass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMainClass.ForeColor = System.Drawing.Color.White;
            this.btnMainClass.Location = new System.Drawing.Point(789, 123);
            this.btnMainClass.Name = "btnMainClass";
            this.btnMainClass.Size = new System.Drawing.Size(101, 33);
            this.btnMainClass.TabIndex = 23;
            this.btnMainClass.Text = "Change";
            this.btnMainClass.Click += new System.EventHandler(this.btnMainClass_Click);
            // 
            // lblMainClass
            // 
            this.lblMainClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMainClass.AutoEllipsis = true;
            this.lblMainClass.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ReactStudio.Properties.Settings.Default, "MAIN_CLASS", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblMainClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainClass.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblMainClass.Location = new System.Drawing.Point(221, 136);
            this.lblMainClass.Name = "lblMainClass";
            this.lblMainClass.Size = new System.Drawing.Size(551, 20);
            this.lblMainClass.TabIndex = 21;
            this.lblMainClass.Text = global::ReactStudio.Properties.Settings.Default.MAIN_CLASS;
            this.lblMainClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMainClass.Click += new System.EventHandler(this.lblMainClass_Click);
            // 
            // lblJava
            // 
            this.lblJava.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblJava.AutoEllipsis = true;
            this.lblJava.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ReactStudio.Properties.Settings.Default, "JAVA_PATH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJava.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblJava.Location = new System.Drawing.Point(205, 214);
            this.lblJava.Name = "lblJava";
            this.lblJava.Size = new System.Drawing.Size(551, 20);
            this.lblJava.TabIndex = 21;
            this.lblJava.Text = global::ReactStudio.Properties.Settings.Default.JAVA_PATH;
            this.lblJava.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblJava.Click += new System.EventHandler(this.lblJava_Click);
            // 
            // lblAntlr
            // 
            this.lblAntlr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAntlr.AutoEllipsis = true;
            this.lblAntlr.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ReactStudio.Properties.Settings.Default, "ANTLR_PATH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblAntlr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntlr.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblAntlr.Location = new System.Drawing.Point(221, 293);
            this.lblAntlr.Name = "lblAntlr";
            this.lblAntlr.Size = new System.Drawing.Size(551, 23);
            this.lblAntlr.TabIndex = 18;
            this.lblAntlr.Text = global::ReactStudio.Properties.Settings.Default.ANTLR_PATH;
            this.lblAntlr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAntlr.Click += new System.EventHandler(this.lblAntlr_Click);
            // 
            // lblPath
            // 
            this.lblPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPath.AutoEllipsis = true;
            this.lblPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ReactStudio.Properties.Settings.Default, "OUTPUT_PATH", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblPath.Location = new System.Drawing.Point(221, 364);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(551, 23);
            this.lblPath.TabIndex = 0;
            this.lblPath.Text = global::ReactStudio.Properties.Settings.Default.OUTPUT_PATH;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPath.Click += new System.EventHandler(this.lblPath_Click);
            // 
            // OptionsUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(908, 490);
            this.Controls.Add(this.btnMainClass);
            this.Controls.Add(this.btnJava);
            this.Controls.Add(this.lblMainClass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblJava);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAntlr);
            this.Controls.Add(this.lblAntlr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptionsUI";
            this.Load += new System.EventHandler(this.OptionsUI_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPath;
        private Guna.UI2.WinForms.Guna2Button btnChange;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnAntlr;
        private System.Windows.Forms.Label lblAntlr;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnJava;
        private System.Windows.Forms.Label lblJava;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMainClass;
        private Guna.UI2.WinForms.Guna2Button btnMainClass;
    }
}