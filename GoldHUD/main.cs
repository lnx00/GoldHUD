using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;

namespace GoldHUD
{
    public partial class main : Form
    {

        public string version = "0.8";

        bool allowResize = false;
        bool isCollapse = true;
        settings settingFrm = new settings();
        DirectoryInfo workingPath;

        //public Size fileIconSize { get; set; }
        public Size fileIconSize = new Size(16, 16);

        public main()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Closing GoldHUD...");
            Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Closing GoldHUD...");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Starting Gold Hud...");
        }

        private void resizePanel_MouseUp(object sender, MouseEventArgs e)
        {
            allowResize = false;
        }

        private void resizePanel_MouseDown(object sender, MouseEventArgs e)
        {
            allowResize = true;
        }

        private void resizePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (allowResize && !(fileView.Width > this.Width - btn_collapse.Width))
            {
                fileView.Width = resizePanel.Left + e.X;
                btn_collapse.Left = fileView.Width - btn_collapse.Width;
                if (isCollapse)
                {
                    fileView.Visible = true;
                    btn_collapse.Visible = true;
                    btn_expand.Visible = false;
                    isCollapse = false;
                }
                if(fileView.Width < 10)
                {
                    fileView.Visible = false;
                    btn_collapse.Visible = false;
                    btn_expand.Visible = true;
                    isCollapse = true;
                }
            }else if(fileView.Width > this.Width - btn_collapse.Width)
            {
                fileView.Width = this.Width - (btn_collapse.Width + 1);
                btn_collapse.Left = fileView.Width - btn_collapse.Width;
            }
        }

        private void openToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = fileView.SelectedNode;
                if (selectedNode.Tag.GetType() == typeof(DirectoryInfo))
                {
                    Console.WriteLine("Selected file is Directory... expanding...");
                    //DirectoryInfo selFileInfo = (DirectoryInfo)selectedNode.Tag;
                    //MessageBox.Show("You cant edit folders.");
                    selectedNode.Expand();
                }
                else if (selectedNode.Tag.GetType() == typeof(FileInfo))
                {
                    Console.WriteLine("Selected file is File... opening...");
                    FileInfo selFileInfo = (FileInfo)selectedNode.Tag;
                    editorForm fileForm = new editorForm();
                    fileForm.FileInfo = selFileInfo;
                    fileForm.MdiParent = this;
                    fileForm.Show();
                }
                else
                {
                    Console.WriteLine("File is neither File nor Directory. How could this happen?!");
                    MessageBox.Show("File Type not found.");
                    return;
                }
            }catch (Exception ex)
            {
                if (ex.GetType() == typeof(System.NullReferenceException))
                {
                    Console.WriteLine("ERROR(No File selected): " + ex.Message);
                    MessageBox.Show("Please select a file first.");
                }
                else
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    MessageBox.Show("An error occurred:" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Opening Hud...");
            openHud();
        }

        private void openHud()
        {
            if (hudBrowser.ShowDialog() == DialogResult.OK)
            {
                #region oldBrowser
                DirectoryInfo dirInfo = new DirectoryInfo(hudBrowser.SelectedPath);
                try
                {
                    Console.WriteLine("Loading directories...");
                    DirectoryInfo[] directories = dirInfo.GetDirectories();
                    TreeNode rootNode;
                    if (directories.Length > 0)
                    {
                        Console.WriteLine("Setting root file...");
                        //Set root Node
                        rootNode = new TreeNode(dirInfo.Name);
                        this.Text = "GoldHUD | " + dirInfo.Name;
                        workingPath = dirInfo;
                        rootNode.Tag = dirInfo;
                        getDirectories(dirInfo.GetDirectories(), rootNode);

                        Console.WriteLine("Getting top level files...");
                        //Get RootFiles
                        foreach (FileInfo file in dirInfo.GetFiles())
                        {
                            if (file.Exists)
                            {
                                Console.WriteLine("Adding file: " + file.Name);
                                TreeNode fileNodes = rootNode.Nodes.Add(file.Name);
                                if (file.FullName.EndsWith(".res"))
                                    fileNodes.ImageIndex = 3;
                                else if (file.FullName.EndsWith(".exe"))
                                    fileNodes.ImageIndex = 4;
                                else if (file.FullName.EndsWith(".otf"))
                                    fileNodes.ImageIndex = 5;
                                else if (file.FullName.EndsWith(".png") || file.FullName.EndsWith(".jpg") || file.FullName.EndsWith(".jpeg") || file.FullName.EndsWith(".gif") || file.FullName.EndsWith(".vtf"))
                                    fileNodes.ImageIndex = 6;
                                else if (file.FullName.EndsWith(".ttf"))
                                    fileNodes.ImageIndex = 7;
                                else if (file.FullName.EndsWith(".txt"))
                                    fileNodes.ImageIndex = 8;
                                else if (file.FullName.EndsWith(".zip"))
                                    fileNodes.ImageIndex = 9;
                                else if (file.FullName.EndsWith(".dat") || file.FullName.EndsWith(".bin"))
                                    fileNodes.ImageIndex = 10;
                                else
                                    fileNodes.ImageIndex = 2;
                                fileNodes.SelectedImageIndex = fileNodes.ImageIndex;
                                fileNodes.Tag = file;
                            }
                        }

                        //Add Nodes to fileView
                        Console.WriteLine("Adding all files to explorer...");
                        fileView.Nodes.Add(rootNode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ERROR: " + ex.Message);
                    MessageBox.Show(ex.Message);
                }
                #endregion
            }
            else
            {
                Console.WriteLine("Dialog Result was not OK.");
                MessageBox.Show("No Hud Folder selected.");
            }
        }

        private void getDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                Console.WriteLine("Adding directory: " + subDir.Name);
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageIndex = 1;
                aNode.SelectedImageIndex = aNode.ImageIndex;
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    getDirectories(subSubDirs, aNode);
                }
                foreach (FileInfo file in subDir.GetFiles())
                {
                    if (file.Exists)
                    {
                        Console.WriteLine("Adding file: " + file.Name);
                        TreeNode fileNodes = aNode.Nodes.Add(file.Name);
                        if (file.FullName.EndsWith(".res"))
                            fileNodes.ImageIndex = 3;
                        else if (file.FullName.EndsWith(".exe"))
                            fileNodes.ImageIndex = 4;
                        else if (file.FullName.EndsWith(".otf"))
                            fileNodes.ImageIndex = 5;
                        else if (file.FullName.EndsWith(".png") || file.FullName.EndsWith(".jpg") || file.FullName.EndsWith(".jpeg") || file.FullName.EndsWith(".gif") || file.FullName.EndsWith(".vtf"))
                            fileNodes.ImageIndex = 6;
                        else if (file.FullName.EndsWith(".ttf"))
                            fileNodes.ImageIndex = 7;
                        else if (file.FullName.EndsWith(".txt"))
                            fileNodes.ImageIndex = 8;
                        else if (file.FullName.EndsWith(".zip"))
                            fileNodes.ImageIndex = 9;
                        else if (file.FullName.EndsWith(".dat") || file.FullName.EndsWith(".bin"))
                            fileNodes.ImageIndex = 10;
                        else
                            fileNodes.ImageIndex = 2;
                        fileNodes.SelectedImageIndex = fileNodes.ImageIndex;
                        fileNodes.Tag = file;
                    }
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        private void missingFeatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Resetting UI...");
            fileView.Width = 241;
            fileView.Nodes.Clear();
            foreach (Form frm in this.MdiChildren)
            {
                //if(frm != this)
                //{
                    frm.Dispose();
                    frm.Close();
                //}
            }
            this.Width = 1250;
            this.Height = 680;
        }

        private void goldHUDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Showing Settings...");
            settingFrm.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Updating Files...");
            updateFiles();
        }

        public void updateFiles()
        {
            try
            {
                foreach (TreeNode node in fileView.Nodes)
                {
                    if (node.Parent == null)
                    {
                        if (node.Tag.GetType() == typeof(DirectoryInfo))
                        {
                            refreshFiles((DirectoryInfo)node.Tag);
                            node.Remove();
                        }
                    }
                }
                TreeNode firstNode = fileView.Nodes[0];
                if (firstNode.Tag.GetType() == typeof(DirectoryInfo))
                {
                    refreshFiles((DirectoryInfo)firstNode.Tag);
                    firstNode.Remove();
                }
                //refreshFiles();
            }
            catch(Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.Message);
                MessageBox.Show("Updating failed.", "Updating failed.");
            }
        }

        private void refreshFiles(DirectoryInfo hudPath)
        {
            DirectoryInfo dirInfo = hudPath;
            try
            {
                DirectoryInfo[] directories = dirInfo.GetDirectories();
                TreeNode rootNode;
                if (directories.Length > 0)
                {
                    //Set root Node
                    rootNode = new TreeNode(dirInfo.Name);
                    this.Text = "GoldHUD | " + dirInfo.Name;
                    workingPath = dirInfo;
                    rootNode.Tag = dirInfo;
                    getDirectories(dirInfo.GetDirectories(), rootNode);

                    //Get RootFiles
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        if (file.Exists)
                        {
                            TreeNode fileNodes = rootNode.Nodes.Add(file.Name);
                            if (file.FullName.EndsWith(".res"))
                                fileNodes.ImageIndex = 3;
                            else if (file.FullName.EndsWith(".exe"))
                                fileNodes.ImageIndex = 4;
                            else if (file.FullName.EndsWith(".otf"))
                                fileNodes.ImageIndex = 5;
                            else if (file.FullName.EndsWith(".png") || file.FullName.EndsWith(".jpg") || file.FullName.EndsWith(".jpeg") || file.FullName.EndsWith(".gif") || file.FullName.EndsWith(".vtf"))
                                fileNodes.ImageIndex = 6;
                            else if (file.FullName.EndsWith(".ttf"))
                                fileNodes.ImageIndex = 7;
                            else if (file.FullName.EndsWith(".txt"))
                                fileNodes.ImageIndex = 8;
                            else if (file.FullName.EndsWith(".zip"))
                                fileNodes.ImageIndex = 9;
                            else if (file.FullName.EndsWith(".dat") || file.FullName.EndsWith(".bin"))
                                fileNodes.ImageIndex = 10;
                            else
                                fileNodes.ImageIndex = 2;
                            fileNodes.SelectedImageIndex = fileNodes.ImageIndex;
                            fileNodes.Tag = file;
                        }
                    }

                    //Add Nodes to fileView
                    fileView.Nodes.Add(rootNode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = fileView.SelectedNode;

            if (selectedNode != null && selectedNode.Parent != null)
            {
                fileView.LabelEdit = true;
                if(!selectedNode.IsEditing)
                {
                    selectedNode.BeginEdit();
                }
            }
            else
            {
                MessageBox.Show("No file selected or selected file is the HUD folder.", "Invalid selection");
            }
        }

        private void fileView_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if(e.Label != null)
            {
                if(e.Label.Length < 0)
                {
                    e.CancelEdit = true;
                    MessageBox.Show("Invalid file name." + Environment.NewLine + "The file name cannot be blank.", "Invalid file name.");
                }
                else
                {
                    FileInfo selFileInfo = (FileInfo)fileView.SelectedNode.Tag;
                    string newFileName = selFileInfo.FullName.Replace(selFileInfo.Name, e.Label);
                    File.Move(selFileInfo.FullName, newFileName);
                    FileInfo newFileInfo = new FileInfo(newFileName);
                    fileView.SelectedNode.Tag = newFileInfo;
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TreeNode selectedNode = fileView.SelectedNode;
                if (selectedNode.Tag.GetType() == typeof(DirectoryInfo))
                {
                    DirectoryInfo selDirInfo = (DirectoryInfo)fileView.SelectedNode.Tag;
                    DialogResult delResult = MessageBox.Show("Are you sure you want to delete '" + selDirInfo.Name + "'?", "Delete Folder", MessageBoxButtons.YesNo);
                    if (delResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        Directory.Delete(selDirInfo.FullName);
                        fileView.SelectedNode.Remove();
                    }
                }
                else if (selectedNode.Tag.GetType() == typeof(FileInfo))
                {
                    FileInfo selFileInfo = (FileInfo)fileView.SelectedNode.Tag;
                    DialogResult delResult = MessageBox.Show("Are you sure you want to delete '" + selFileInfo.Name + "'?", "Delete File", MessageBoxButtons.YesNo);
                    if (delResult == DialogResult.No)
                    {
                        return;
                    }
                    else
                    {
                        File.Delete(selFileInfo.FullName);
                        fileView.SelectedNode.Remove();
                    }
                }
                else
                {
                    MessageBox.Show("File Type not found.");
                    return;
                }
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(System.NullReferenceException))
                {
                    MessageBox.Show("Please select a file first.");
                }
                else
                {
                    MessageBox.Show("An error occurred:" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void fileMenu_Opening(object sender, CancelEventArgs e)
        {
            TreeNode selectedNode = fileView.SelectedNode;
            try
            {
                if (selectedNode.Parent == null)
                {
                    context_delete.Visible = false;
                    context_rename.Visible = false;
                    context_closeproject.Visible = true;
                }
                else
                {
                    context_delete.Visible = true;
                    context_rename.Visible = true;
                    context_closeproject.Visible = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please open a project first.");
            }
        }

        private void fileView_MouseDown(object sender, MouseEventArgs e)
        {
            fileView.SelectedNode = fileView.GetNodeAt(e.X, e.Y);
        }

        private void context_closeproject_Click(object sender, EventArgs e)
        {
            fileView.SelectedNode.Remove();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Expanding all files...");
            fileView.ExpandAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Collapsing all files...");
            fileView.CollapseAll();
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Starting debugger...");
            TF2 debuggerFrm = new TF2();
            debuggerFrm.Show();
        }

        private void fileView_DoubleClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = fileView.SelectedNode;

            if (selectedNode.Tag.GetType() == typeof(FileInfo))
            {
                try
                {
                    if (selectedNode.Tag.GetType() == typeof(DirectoryInfo))
                    {
                        //DirectoryInfo selFileInfo = (DirectoryInfo)selectedNode.Tag;
                        //MessageBox.Show("You cant edit folders.");
                        selectedNode.Expand();
                    }
                    else if (selectedNode.Tag.GetType() == typeof(FileInfo))
                    {
                        FileInfo selFileInfo = (FileInfo)selectedNode.Tag;
                        editorForm fileForm = new editorForm();
                        fileForm.FileInfo = selFileInfo;
                        fileForm.MdiParent = this;
                        fileForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("File Type not found.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(System.NullReferenceException))
                    {
                        MessageBox.Show("Please select a file first.");
                    }
                    else
                    {
                        MessageBox.Show("An error occurred:" + Environment.NewLine + ex.Message);
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openHud();
        }

        private void btn_collapse_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Wooooosh");
            fileView.Visible = false;
            btn_collapse.Visible = false;
            btn_expand.Visible = true;
            isCollapse = true;
            if (fileView.Width > this.Width - 50)
            {
                fileView.Width = this.Width - 50;
                btn_collapse.Left = fileView.Width - btn_collapse.Width;
            }
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Wooooosh");
            fileView.Visible = true;
            btn_collapse.Visible = true;
            btn_expand.Visible = false;
            isCollapse = false;
            if(fileView.Width < 50)
            {
                fileView.Width = 50;
                btn_collapse.Left = fileView.Width - btn_collapse.Width;
            }
        }

        private void collapseFileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Collapsing file explorer...");
            fileView.Visible = false;
            btn_collapse.Visible = false;
            btn_expand.Visible = true;
            isCollapse = true;
            if (fileView.Width > this.Width - 50)
            {
                fileView.Width = this.Width - 50;
                btn_collapse.Left = fileView.Width - btn_collapse.Width;
            }
        }

        private void expandFileExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Expanding file explorer...");
            fileView.Visible = true;
            btn_collapse.Visible = true;
            btn_expand.Visible = false;
            isCollapse = false;
            if (fileView.Width < 50)
            {
                fileView.Width = 50;
                btn_collapse.Left = fileView.Width - btn_collapse.Width;
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Restarting GoldHUD...");
            Application.Restart();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saving current file...");
            saveThisFile();
        }

        private void saveThisFile()
        {
            editorForm child = ActiveMdiChild as editorForm;
            if (child != null)
            {
                child.saveFile();
                MessageBox.Show("File saved succesfully!", "Succesfully saved.");
            }
            else
            {
                MessageBox.Show("No file opened.");
            }
        }

        private void deleteThisFile()
        {
            editorForm child = ActiveMdiChild as editorForm;
            if (child != null)
            {
                child.deleteFile();
            }
            else
            {
                MessageBox.Show("No file opened.");
            }
        }

        private void closeThisFile()
        {
            editorForm child = ActiveMdiChild as editorForm;
            if (child != null)
            {
                child.Dispose();
                child.Close();
            }
            else
            {
                MessageBox.Show("File could not be closed.");
            }
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Deleting current file...");
            deleteThisFile();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saving Hud...");
            saveAllFiles();
        }

        private void saveAllFiles()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == typeof(editorForm))
                 {
                    editorForm editorFrm = (editorForm) frm;
                    editorFrm.saveFile();
                 }
            }
            MessageBox.Show("All files saved succesfully!", "Succesfully saved.");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saving current file...");
            saveThisFile();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Deleting current file...");
            deleteThisFile();
        }

        private void closeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Closing current file...");
            closeThisFile();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("CLICK CLICK CLICK CLICK CLICK CLICK");
        }

        private void closeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Closing current file...");
            closeThisFile();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PLEASE DONT REMOVE THIS PART
            MessageBox.Show("GoldHUD Version " + version + Environment.NewLine + "Made by LiNCHx (http://steamcommunity.com/id/linchx/)", "GoldHUD", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //EDIT THIS IF YOU WANT TO ADD YOUR CREDITS
            //MessageBox.Show(" YOUR MESSAGE HERE ", "GoldHUD");
        }
    }
}
