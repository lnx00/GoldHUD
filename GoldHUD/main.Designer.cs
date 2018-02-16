namespace GoldHUD
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.goldHUDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.missingFeatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseFileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandFileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileView = new System.Windows.Forms.TreeView();
            this.fileMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.context_rename = new System.Windows.Forms.ToolStripMenuItem();
            this.context_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.context_closeproject = new System.Windows.Forms.ToolStripMenuItem();
            this.fileIcons = new System.Windows.Forms.ImageList(this.components);
            this.resizePanel = new System.Windows.Forms.Panel();
            this.hudBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_expand = new System.Windows.Forms.PictureBox();
            this.btn_collapse = new System.Windows.Forms.PictureBox();
            this.mainMenu.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.fileMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_expand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_collapse)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.goldHUDToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.debugToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.deleteToolStripMenuItem1,
            this.closeToolStripMenuItem2});
            this.mainMenu.Name = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.closeToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // openToolStripMenuItem1
            // 
            resources.ApplyResources(this.openToolStripMenuItem1, "openToolStripMenuItem1");
            this.openToolStripMenuItem1.Image = global::GoldHUD.Properties.Resources.folder;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            resources.ApplyResources(this.saveToolStripMenuItem1, "saveToolStripMenuItem1");
            this.saveToolStripMenuItem1.Image = global::GoldHUD.Properties.Resources.save;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // closeToolStripMenuItem1
            // 
            resources.ApplyResources(this.closeToolStripMenuItem1, "closeToolStripMenuItem1");
            this.closeToolStripMenuItem1.Image = global::GoldHUD.Properties.Resources.close;
            this.closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            this.closeToolStripMenuItem1.Click += new System.EventHandler(this.closeToolStripMenuItem1_Click);
            // 
            // goldHUDToolStripMenuItem
            // 
            resources.ApplyResources(this.goldHUDToolStripMenuItem, "goldHUDToolStripMenuItem");
            this.goldHUDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.toolStripMenuItem5,
            this.saveToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.closeToolStripMenuItem3});
            this.goldHUDToolStripMenuItem.Name = "goldHUDToolStripMenuItem";
            this.goldHUDToolStripMenuItem.Click += new System.EventHandler(this.goldHUDToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Image = global::GoldHUD.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            resources.ApplyResources(this.restartToolStripMenuItem, "restartToolStripMenuItem");
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // saveToolStripMenuItem
            // 
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // closeToolStripMenuItem3
            // 
            resources.ApplyResources(this.closeToolStripMenuItem3, "closeToolStripMenuItem3");
            this.closeToolStripMenuItem3.Name = "closeToolStripMenuItem3";
            this.closeToolStripMenuItem3.Click += new System.EventHandler(this.closeToolStripMenuItem3_Click);
            // 
            // viewToolStripMenuItem
            // 
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.missingFeatureToolStripMenuItem,
            this.toolStripMenuItem3,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.toolStripMenuItem4,
            this.collapseFileExplorerToolStripMenuItem,
            this.expandFileExplorerToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            // 
            // refreshToolStripMenuItem
            // 
            resources.ApplyResources(this.refreshToolStripMenuItem, "refreshToolStripMenuItem");
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // missingFeatureToolStripMenuItem
            // 
            resources.ApplyResources(this.missingFeatureToolStripMenuItem, "missingFeatureToolStripMenuItem");
            this.missingFeatureToolStripMenuItem.Name = "missingFeatureToolStripMenuItem";
            this.missingFeatureToolStripMenuItem.Click += new System.EventHandler(this.missingFeatureToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // expandAllToolStripMenuItem
            // 
            resources.ApplyResources(this.expandAllToolStripMenuItem, "expandAllToolStripMenuItem");
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            resources.ApplyResources(this.collapseAllToolStripMenuItem, "collapseAllToolStripMenuItem");
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // collapseFileExplorerToolStripMenuItem
            // 
            resources.ApplyResources(this.collapseFileExplorerToolStripMenuItem, "collapseFileExplorerToolStripMenuItem");
            this.collapseFileExplorerToolStripMenuItem.Name = "collapseFileExplorerToolStripMenuItem";
            this.collapseFileExplorerToolStripMenuItem.Click += new System.EventHandler(this.collapseFileExplorerToolStripMenuItem_Click);
            // 
            // expandFileExplorerToolStripMenuItem
            // 
            resources.ApplyResources(this.expandFileExplorerToolStripMenuItem, "expandFileExplorerToolStripMenuItem");
            this.expandFileExplorerToolStripMenuItem.Name = "expandFileExplorerToolStripMenuItem";
            this.expandFileExplorerToolStripMenuItem.Click += new System.EventHandler(this.expandFileExplorerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // debugToolStripMenuItem
            // 
            resources.ApplyResources(this.debugToolStripMenuItem, "debugToolStripMenuItem");
            this.debugToolStripMenuItem.Image = global::GoldHUD.Properties.Resources.play;
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            resources.ApplyResources(this.toolStripMenuItem7, "toolStripMenuItem7");
            this.toolStripMenuItem7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem6
            // 
            resources.ApplyResources(this.toolStripMenuItem6, "toolStripMenuItem6");
            this.toolStripMenuItem6.Image = global::GoldHUD.Properties.Resources.save;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem1, "deleteToolStripMenuItem1");
            this.deleteToolStripMenuItem1.Image = global::GoldHUD.Properties.Resources.delete;
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // closeToolStripMenuItem2
            // 
            resources.ApplyResources(this.closeToolStripMenuItem2, "closeToolStripMenuItem2");
            this.closeToolStripMenuItem2.Image = global::GoldHUD.Properties.Resources.close;
            this.closeToolStripMenuItem2.Name = "closeToolStripMenuItem2";
            this.closeToolStripMenuItem2.Click += new System.EventHandler(this.closeToolStripMenuItem2_Click);
            // 
            // contextMenu
            // 
            resources.ApplyResources(this.contextMenu, "contextMenu");
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            // 
            // openToolStripMenuItem
            // 
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Image = global::GoldHUD.Properties.Resources.folder;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAllToolStripMenuItem
            // 
            resources.ApplyResources(this.saveAllToolStripMenuItem, "saveAllToolStripMenuItem");
            this.saveAllToolStripMenuItem.Image = global::GoldHUD.Properties.Resources.save;
            this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
            this.saveAllToolStripMenuItem.Click += new System.EventHandler(this.saveAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // closeToolStripMenuItem
            // 
            resources.ApplyResources(this.closeToolStripMenuItem, "closeToolStripMenuItem");
            this.closeToolStripMenuItem.Image = global::GoldHUD.Properties.Resources.close;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // fileView
            // 
            resources.ApplyResources(this.fileView, "fileView");
            this.fileView.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fileView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileView.ContextMenuStrip = this.fileMenu;
            this.fileView.ImageList = this.fileIcons;
            this.fileView.Name = "fileView";
            this.fileView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.fileView_AfterLabelEdit);
            this.fileView.DoubleClick += new System.EventHandler(this.fileView_DoubleClick);
            this.fileView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fileView_MouseDown);
            // 
            // fileMenu
            // 
            resources.ApplyResources(this.fileMenu, "fileMenu");
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem2,
            this.context_rename,
            this.context_delete,
            this.context_closeproject});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Opening += new System.ComponentModel.CancelEventHandler(this.fileMenu_Opening);
            // 
            // openToolStripMenuItem2
            // 
            resources.ApplyResources(this.openToolStripMenuItem2, "openToolStripMenuItem2");
            this.openToolStripMenuItem2.Image = global::GoldHUD.Properties.Resources.folder;
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.Click += new System.EventHandler(this.openToolStripMenuItem2_Click);
            // 
            // context_rename
            // 
            resources.ApplyResources(this.context_rename, "context_rename");
            this.context_rename.Image = global::GoldHUD.Properties.Resources.rename;
            this.context_rename.Name = "context_rename";
            this.context_rename.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // context_delete
            // 
            resources.ApplyResources(this.context_delete, "context_delete");
            this.context_delete.Image = global::GoldHUD.Properties.Resources.delete;
            this.context_delete.Name = "context_delete";
            this.context_delete.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // context_closeproject
            // 
            resources.ApplyResources(this.context_closeproject, "context_closeproject");
            this.context_closeproject.Image = global::GoldHUD.Properties.Resources.close;
            this.context_closeproject.Name = "context_closeproject";
            this.context_closeproject.Click += new System.EventHandler(this.context_closeproject_Click);
            // 
            // fileIcons
            // 
            this.fileIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fileIcons.ImageStream")));
            this.fileIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.fileIcons.Images.SetKeyName(0, "home.png");
            this.fileIcons.Images.SetKeyName(1, "folder.png");
            this.fileIcons.Images.SetKeyName(2, "file.png");
            this.fileIcons.Images.SetKeyName(3, "hudfile.png");
            this.fileIcons.Images.SetKeyName(4, "exe.png");
            this.fileIcons.Images.SetKeyName(5, "otf.png");
            this.fileIcons.Images.SetKeyName(6, "picture.png");
            this.fileIcons.Images.SetKeyName(7, "ttf.png");
            this.fileIcons.Images.SetKeyName(8, "txt.png");
            this.fileIcons.Images.SetKeyName(9, "zip.png");
            this.fileIcons.Images.SetKeyName(10, "dat.png");
            // 
            // resizePanel
            // 
            resources.ApplyResources(this.resizePanel, "resizePanel");
            this.resizePanel.BackColor = System.Drawing.Color.Transparent;
            this.resizePanel.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.resizePanel.Name = "resizePanel";
            this.resizePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseDown);
            this.resizePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseMove);
            this.resizePanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.resizePanel_MouseUp);
            // 
            // hudBrowser
            // 
            resources.ApplyResources(this.hudBrowser, "hudBrowser");
            this.hudBrowser.ShowNewFolderButton = false;
            // 
            // btn_expand
            // 
            resources.ApplyResources(this.btn_expand, "btn_expand");
            this.btn_expand.BackColor = System.Drawing.Color.Transparent;
            this.btn_expand.Image = global::GoldHUD.Properties.Resources.CollapseButtonNew;
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.TabStop = false;
            this.btn_expand.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // btn_collapse
            // 
            resources.ApplyResources(this.btn_collapse, "btn_collapse");
            this.btn_collapse.BackColor = System.Drawing.Color.Transparent;
            this.btn_collapse.Image = global::GoldHUD.Properties.Resources.ExpandButtonNew;
            this.btn_collapse.Name = "btn_collapse";
            this.btn_collapse.TabStop = false;
            this.btn_collapse.Click += new System.EventHandler(this.btn_collapse_Click);
            // 
            // main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ContextMenuStrip = this.contextMenu;
            this.Controls.Add(this.btn_expand);
            this.Controls.Add(this.btn_collapse);
            this.Controls.Add(this.resizePanel);
            this.Controls.Add(this.fileView);
            this.Controls.Add(this.mainMenu);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_expand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_collapse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TreeView fileView;
        private System.Windows.Forms.Panel resizePanel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem missingFeatureToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem context_rename;
        private System.Windows.Forms.ToolStripMenuItem context_delete;
        private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog hudBrowser;
        private System.Windows.Forms.ToolStripMenuItem goldHUDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ImageList fileIcons;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem context_closeproject;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.PictureBox btn_collapse;
        private System.Windows.Forms.PictureBox btn_expand;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem collapseFileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandFileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

