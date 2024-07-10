using ReactStudio.BusinessLayer;
using ReactStudio.PresentationLayer;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ReactStudio
{
    public partial class Home : Form
    {
        private string _folderName;
        private string _targetFolderPath;

        private bool _timeStopFlag;

        public Home()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get the selected node
            TreeNode node = e.Node;

            // Check if the node has a name (file path)
            if (!string.IsNullOrEmpty(node.Name))
            {

                flowLayoutError.Controls.Clear();
                richTextOutput.Clear();

                if (node.Name.EndsWith(".exception"))
                {
                    flowLayoutError.Controls.AddRange(FileProcess.ErrorsLabel(File.ReadAllText(node.Name)));
                }
                else
                {
                    StreamReader reader = new StreamReader(node.Name);

                    // Clear the rich text box
                    richTextOutput.Clear();

                    // Read and display the file content
                    richTextOutput.Text = reader.ReadToEnd();

                    richTextOutput.Tag = node.Name;

                    // Close the stream reader
                    reader.Close();
                }
            }
        }

        private void btnConfig_Click_1(object sender, EventArgs e)
        {
            using (OptionsUI options = new OptionsUI())
            {
                options.ShowDialog();
                SetRootFolder();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnWrap_Click(object sender, EventArgs e)
        {
            this.richTextInput.WordWrap = this.btnWrap.Checked;
            this.richTextOutput.WordWrap = this.btnWrap.Checked;

            Properties.Settings.Default.TEXT_WRAP = this.btnWrap.Checked;
            Properties.Settings.Default.Save();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            // Enable drag-and-drop operations
            this.richTextInput.AllowDrop = true;
            this.treeFolder.AllowDrop = true;

            // Register the event handlers for DragEnter and DragDrop events
            this.richTextInput.DragEnter += richTextInput_DragEnter;
            this.richTextInput.DragDrop += richTextInput_DragDrop;

            lblMainClass.DragEnter += LblMainClass_DragEnter;
            lblMainClass.DragDrop += LblMainClass_DragDrop;

            this.treeFolder.DragEnter += TreeFolder_DragEnter;
            this.treeFolder.DragDrop += TreeFolder_DragDrop;

            // Sort the treeview nodes by name descending using an anonymous comparer
            this.treeFolder.TreeViewNodeSorter = new NodeSorter();

            this.SetRootFolder();
        }

        private void LblMainClass_DragDrop(object sender, DragEventArgs e)
        {
            // Get the array of strings that represent the paths of the dropped items
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);

            if(paths[0].EndsWith(".class"))
            {
                lblMainClass.Text = paths[0];
                Properties.Settings.Default.MAIN_CLASS = lblMainClass.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void LblMainClass_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data is a file or a folder
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Set the effect to copy
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Set the effect to none
                e.Effect = DragDropEffects.None;
            }
        }

        private void TreeFolder_DragDrop(object sender, DragEventArgs e)
        {
            // Get the array of strings that represent the paths of the dropped items
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Check if the first item is a folder path
            if (Directory.Exists(paths[0]))
            {
                Properties.Settings.Default.OUTPUT_PATH = paths[0];
                Properties.Settings.Default.Save();
                SetRootFolder();
            }
        }

        private void TreeFolder_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data is a file or a folder
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Set the effect to copy
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Set the effect to none
                e.Effect = DragDropEffects.None;
            }
        }

        private void SetRootFolder()
        {
            string rootFolderPath = Properties.Settings.Default.OUTPUT_PATH.ToString();

            treeFolder.Nodes.Clear();

            treeFolder.Nodes.Add(FileProcess.GetFolderTreeNodes(rootFolderPath));

            if (treeFolder.Nodes.Count > 0)
                treeFolder.SelectedNode = treeFolder.Nodes[0];

            treeFolder.ExpandAll();
        }

        private void richTextInput_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file paths as an array of strings
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            this.richTextInput.Text = "";

            // Loop through each file path
            foreach (string file in files)
            {
                // Get the file extension
                string extension = Path.GetExtension(file);

                // Check if the file extension is .txt or .dart
                if (extension == ".txt" || extension == ".dart")
                {
                    // Create a new instance of the StreamReader class
                    StreamReader reader = new StreamReader(file);

                    // Read the file content as a string
                    string content = reader.ReadToEnd();

                    // Close the reader
                    reader.Close();

                    // Append the file content to the RichTextBox control
                    this.richTextInput.AppendText(content + "\n");
                }
            }
        }

        private void richTextInput_DragEnter(object sender, DragEventArgs e)
        {
            // Check if the data being dragged is a file
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // Set the effect to copy
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Set the effect to none
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    this.richTextInput.Font = fontDialog.Font;
                    this.richTextOutput.Font = fontDialog.Font;

                    Properties.Settings.Default.FONT = fontDialog.Font;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Font font = new Font("Consolas", 10, FontStyle.Regular);

            Properties.Settings.Default.FONT = font;
            Properties.Settings.Default.Save();

            this.richTextInput.Font = font;
            this.richTextOutput.Font = font;
        }

        private void btnOpenTextInputFile_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog class
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory to the current directory
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            // Set the filter to show only .txt or .dart files
            openFileDialog.Filter = "Text files (*.txt)|*.txt|Dart files (*.dart)|*.dart";

            // Set the default extension to .txt
            openFileDialog.DefaultExt = "txt";

            // Set the title of the dialog box
            openFileDialog.Title = "Select a file";

            // Show the dialog box and get the result
            DialogResult result = openFileDialog.ShowDialog();

            // If the user clicked OK, read and return the file content
            if (result == DialogResult.OK)
            {
                richTextInput.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(richTextInput.Text == "")
            {
                MessageBox.Show("Source code is empty !", "Compile NaN", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            this._folderName = "Output_" + DateTime.Now.ToString("yyyy-MM-dd-hh-mm-ss");

            this._targetFolderPath = Path.Combine(Properties.Settings.Default.OUTPUT_PATH.ToString(), _folderName);

            if (!Directory.Exists(_targetFolderPath))
                Directory.CreateDirectory(_targetFolderPath);

            TreeNode node = new TreeNode();

            node.Name = node.Text =  _folderName;
            node.Tag = _targetFolderPath;

            treeFolder.Nodes[0].Nodes.Add(node);

            progressLoad.Visible = true;
            richTextOutput.Visible = false;

            treeFolder.SelectedNode = node;

            flowLayoutError.Controls.Clear();

            // here we have to save text temp text input then pass it as parameter

            File.WriteAllLines("_temp.txt", richTextInput.Lines);

            string inputPath = new FileInfo("_temp.txt").FullName;

            ReactProcess.Start(inputPath, _targetFolderPath);

            // Timer turn it on here
            timerToShowFiles.Start();
        }

        private void btnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            FileProcess.ExplorerOpenFolder(treeFolder.SelectedNode.Tag.ToString());
        }

        private void treeFolder_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Get the selected node
            TreeNode selectedNode = e.Node;

            // Get the full path from the node's tag property
            string selectedFolderPath = (string)selectedNode.Tag;

            // Show the path in a message box
            treeFiles.Nodes.Clear();
            treeFiles.Nodes.AddRange(FileProcess.GetPathFilesNodes(selectedFolderPath));
        }

        private void timerToShowFiles_Tick(object sender, EventArgs e)
        {
            if(_timeStopFlag)
            {
                _timeStopFlag = false;

                this.timerToShowFiles.Interval = 1000;

                string exceptions = FileProcess.CheckExceptionsExists(_targetFolderPath);

                if (exceptions != null)
                {
                    flowLayoutError.Controls.AddRange(FileProcess.ErrorsLabel(File.ReadAllText(exceptions)));
                }

                progressLoad.Visible = false;
                richTextOutput.Visible = true;

                File.Delete("_temp.txt");

                treeFolder.Focus();
                treeFolder.SelectedNode = treeFolder.Nodes[0].Nodes[0];

                this.treeFolder_AfterSelect(treeFolder.SelectedNode, new TreeViewEventArgs(treeFolder.SelectedNode));

                this.timerToShowFiles.Stop();

            }

            if(Directory.GetFiles(_targetFolderPath).Length > 0)
            {
                this.timerToShowFiles.Interval = 2000;

                _timeStopFlag = true;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (this.richTextOutput.Tag != null)
            {
                string path = this.richTextOutput.Tag.ToString();
                if (path.EndsWith(".html"))
                    Process.Start(this.richTextOutput.Tag.ToString());
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (About about = new About())
            {
                about.ShowDialog();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
