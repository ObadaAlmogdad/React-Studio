using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReactStudio.BusinessLayer
{
    class FileProcess
    {
        public static TreeNode[] GetPathFilesNodes(string folderPath)
        {
            List<TreeNode> treeNodes = new List<TreeNode>();

            // Get the directory info of the folder
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);

            // Loop through each file in the folder
            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                // Check if the file extension is html, css or javascript
                if (file.Extension == ".html" || file.Extension == ".css" || file.Extension == ".exception")
                {
                    // Create a new tree node with the file name and path
                    TreeNode node = new TreeNode(file.Name);
                    node.Name = file.FullName;

                    if (file.Extension == ".exception")
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 2;
                    }

                    // Add the node to the tree view
                    treeNodes.Add(node);
                }
            }

            return treeNodes.ToArray();
        }

        public static void ExplorerOpenFolder(string folderPath)
        {
            // Check if the folder exists
            if (Directory.Exists(folderPath))
            {
                // Open the folder in windows explorer
                Process.Start("explorer.exe", folderPath);
            }
        }

        public static TreeNode GetFolderTreeNodes(string rootPath)
        {
            TreeNode rootNode = null;

            // Create a new instance of the DirectoryInfo class
            DirectoryInfo rootDir = new DirectoryInfo(rootPath);

            // Check if the directory exists
            if (rootDir.Exists)
            {
                // Create a root node with the directory name
                rootNode = new TreeNode(rootDir.Name);

                // Set the tag property to the full path
                rootNode.Tag = rootDir.FullName;

                // Call the helper method to add child nodes
                AddChildNodes(rootNode);

                // Add the root node to the treeview
                //this.treeView1.Nodes.Add(rootNode);
            }

            return rootNode;
        }

        private static void AddChildNodes(TreeNode parentNode)
        {
            // Get the full path from the parent node's tag property
            string parentPath = (string)parentNode.Tag;

            // Create a new instance of the DirectoryInfo class
            DirectoryInfo parentDir = new DirectoryInfo(parentPath);

            // Loop through each subdirectory in the parent directory
            foreach (DirectoryInfo subDir in parentDir.GetDirectories())
            {
                if (IsAccessible(subDir.FullName))
                {
                    // Create a child node with the subdirectory name
                    TreeNode childNode = new TreeNode(subDir.Name);

                    // Set the tag property to the full path
                    childNode.Tag = subDir.FullName;

                    // Add the child node to the parent node
                    parentNode.Nodes.Add(childNode);
                }
            }

        }

        private static bool IsAccessible(string path)
        {
            try
            {
                // Try to get the directory security object
                var directorySecurity = Directory.GetAccessControl(path);

                // If no exception is thrown, assume read access
                return true;
            }
            catch
            {
                // If an exception is thrown, assume no access
                return false;
            }
        }

        public static string CheckExceptionsExists(string folderPath) =>
             Directory.GetFiles(folderPath).FirstOrDefault(x => x.EndsWith(".exception"));


        public static Label[] ErrorsLabel(string text)
        {
            string[] textLines = null;

            if(text.EndsWith(";"))
                textLines = text.Substring(0, text.Length - 1).Split(';');
            else
                textLines = text.Substring(0, text.Length).Split(';');

            Label[] lblErrors = new Label[textLines.Length];

            for (int i = 0; i < textLines.Length; i++)
            {
                lblErrors[i] = createErrorLabel(textLines[i], i);
            }

            return lblErrors;
        }

        private static Label createErrorLabel(String text, int num)
        {
            Label lblError = new Label
            {
                Size = new Size(1145, 30),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(44, 44, 44),
                Font = new Font("Consolas",9),
                Image = Properties.Resources.Close_Window_25px,
                ImageAlign = ContentAlignment.MiddleLeft,
                Tag = text,
                Text = $"    [{num}] {text}",
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0, 1, 0, 7),
                AutoEllipsis = true,
                AutoSize = false
            };

            lblError.DoubleClick += LblError_DoubleClick;

            return lblError;
        }

        private static void LblError_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(((Label)sender).Tag.ToString());

            MessageBox.Show("Error has been copied to this clipboard.", "Copy Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
