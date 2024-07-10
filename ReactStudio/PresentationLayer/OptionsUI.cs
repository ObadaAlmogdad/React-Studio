using System;
using System.Drawing;
using System.Windows.Forms;

namespace ReactStudio.PresentationLayer
{
    public partial class OptionsUI : Form
    {
        public OptionsUI()
        {
            InitializeComponent();
        }

        private void OptionsUI_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(lblAntlr, lblAntlr.Text);
            toolTip1.SetToolTip(lblPath, lblPath.Text);
            toolTip1.SetToolTip(lblJava, lblJava.Text);
            toolTip1.SetToolTip(lblMainClass, lblMainClass.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                // set the dialog properties
                folderDialog.Description = "Select a folder as a target";
                folderDialog.ShowNewFolderButton = true;

                // show the dialog and get the result
                DialogResult result = folderDialog.ShowDialog();

                if(result == DialogResult.OK)
                {
                    Properties.Settings.Default.OUTPUT_PATH = folderDialog.SelectedPath;
                    Properties.Settings.Default.Save();

                    this.lblPath.Text = folderDialog.SelectedPath;
                    toolTip1.SetToolTip(lblPath, lblPath.Text);
                }
            }
        }

        private void btnAntlr_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // set the dialog properties
                ofd.Title = "Select java.exe Runtime Environment Path";

                // Set the filter to show only .txt or .dart files
                ofd.Filter = "JAR file (*.jar)|*.jar";

                // show the dialog and get the result
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Properties.Settings.Default.ANTLR_PATH = ofd.FileName;
                    Properties.Settings.Default.Save();

                    this.lblAntlr.Text = ofd.FileName;
                    toolTip1.SetToolTip(lblAntlr, lblAntlr.Text);
                }
            }
        }

        private void btnJava_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // set the dialog properties
                ofd.Title = "Select AntlrV4.jar Path";

                // Set the filter to show only .txt or .dart files
                ofd.Filter = "Execution java file (*.exe)|*.exe";

                // show the dialog and get the result
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Properties.Settings.Default.JAVA_PATH = ofd.FileName;
                    Properties.Settings.Default.Save();

                    this.lblJava.Text = ofd.FileName;
                    toolTip1.SetToolTip(lblJava, lblJava.Text);
                }
            }
        }

        private void btnMainClass_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                // set the dialog properties
                ofd.Title = "Select Main Class Java Program Path";

                // Set the filter to show only .txt or .dart files
                ofd.Filter = "Main file (*.class)|*.class";

                // show the dialog and get the result
                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Properties.Settings.Default.MAIN_CLASS = ofd.FileName;
                    Properties.Settings.Default.Save();

                    this.lblMainClass.Text = ofd.FileName;
                    toolTip1.SetToolTip(lblMainClass, lblMainClass.Text);
                }
            }
        }

        #region Form Move
        // Create variables to store the mouse coordinates
        private int mouseX;
        private int mouseY;
        private bool mouseDown;

        // When the mouse is pressed inside the Panel
        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            // Set mouseDown to true
            mouseDown = true;
            // Set mouseX and mouseY to the current mouse coordinates
            mouseX = e.X;
            mouseY = e.Y;
        }

        // When the mouse is released inside the Panel
        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            // Set mouseDown to false
            mouseDown = false;
        }

        // When the mouse is moved inside the Panel
        private void frm_MouseMove(object sender, MouseEventArgs e)
        {
            // If mouseDown is true
            if (mouseDown)
            {
                // Calculate the difference between the current and previous mouse coordinates
                int deltaX = e.X - mouseX;
                int deltaY = e.Y - mouseY;
                // Get the screen bounds
                Rectangle screenBounds = Screen.FromControl(this).Bounds;
                // Get the new location of the Form
                Point newLocation = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
                // Check if the new location is within the screen bounds
                if (newLocation.X >= screenBounds.Left && newLocation.X + this.Width <= screenBounds.Right &&
                    newLocation.Y >= screenBounds.Top && newLocation.Y + this.Height <= screenBounds.Bottom)
                {
                    // Change the location of the Form based on the difference
                    this.Location = newLocation;
                }
            }
        }

        #endregion

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // إنشاء نموذج Home وفتحه
            Home homeForm = new Home();
            homeForm.Show();

            // إغلاق النموذج الحالي
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblAntlr_Click(object sender, EventArgs e)
        {

        }

        private void lblPath_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblJava_Click(object sender, EventArgs e)
        {

        }

        private void lblMainClass_Click(object sender, EventArgs e)
        {

        }
    }
}
