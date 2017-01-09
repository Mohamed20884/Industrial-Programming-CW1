namespace WebBrowser
{
    partial class WindowGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowGUI));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setAsHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editHomepageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTofavouritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.favouriteBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.goBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.switchViewBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.favouritesLbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addfavouriteBtn = new System.Windows.Forms.Button();
            this.editfavouriteBtn = new System.Windows.Forms.Button();
            this.deletefavouriteBtn = new System.Windows.Forms.Button();
            this.tabController = new System.Windows.Forms.CustomTabControl();
            this.addTabBtn = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabController.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.homepageToolStripMenuItem,
            this.favouritesToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTabToolStripMenuItem,
            this.newWindowToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.newTabToolStripMenuItem.Text = "New Tab Ctrl + T";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(270, 30);
            this.newWindowToolStripMenuItem.Text = "New Window Ctrl + N";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // homepageToolStripMenuItem
            // 
            this.homepageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setAsHomepageToolStripMenuItem,
            this.editHomepageToolStripMenuItem});
            this.homepageToolStripMenuItem.Name = "homepageToolStripMenuItem";
            this.homepageToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.homepageToolStripMenuItem.Text = "Homepage";
            // 
            // setAsHomepageToolStripMenuItem
            // 
            this.setAsHomepageToolStripMenuItem.Enabled = false;
            this.setAsHomepageToolStripMenuItem.Name = "setAsHomepageToolStripMenuItem";
            this.setAsHomepageToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.setAsHomepageToolStripMenuItem.Text = "Set As Homepage";
            this.setAsHomepageToolStripMenuItem.Click += new System.EventHandler(this.setAsHomepageToolStripMenuItem_Click);
            // 
            // editHomepageToolStripMenuItem
            // 
            this.editHomepageToolStripMenuItem.Name = "editHomepageToolStripMenuItem";
            this.editHomepageToolStripMenuItem.Size = new System.Drawing.Size(288, 30);
            this.editHomepageToolStripMenuItem.Text = "Edit Homepage Ctrl + H";
            this.editHomepageToolStripMenuItem.Click += new System.EventHandler(this.editHomepageToolStripMenuItem_Click);
            // 
            // favouritesToolStripMenuItem
            // 
            this.favouritesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTofavouritesToolStripMenuItem});
            this.favouritesToolStripMenuItem.Name = "favouritesToolStripMenuItem";
            this.favouritesToolStripMenuItem.Size = new System.Drawing.Size(104, 29);
            this.favouritesToolStripMenuItem.Text = "Favourites";
            // 
            // addTofavouritesToolStripMenuItem
            // 
            this.addTofavouritesToolStripMenuItem.Name = "addTofavouritesToolStripMenuItem";
            this.addTofavouritesToolStripMenuItem.Size = new System.Drawing.Size(239, 30);
            this.addTofavouritesToolStripMenuItem.Text = "Add To Favourites";
            this.addTofavouritesToolStripMenuItem.Click += new System.EventHandler(this.addTofavouritesToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearHistoryToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.historyToolStripMenuItem.Text = "History ";
            // 
            // clearHistoryToolStripMenuItem
            // 
            this.clearHistoryToolStripMenuItem.Name = "clearHistoryToolStripMenuItem";
            this.clearHistoryToolStripMenuItem.Size = new System.Drawing.Size(323, 30);
            this.clearHistoryToolStripMenuItem.Text = "Clear History Ctrl + Shift + H";
            this.clearHistoryToolStripMenuItem.Click += new System.EventHandler(this.clearHistoryToolStripMenuItem_Click);
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.Enabled = false;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 42);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(38, 38);
            this.backBtn.TabIndex = 3;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.AutoSize = true;
            this.forwardBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.forwardBtn.BackColor = System.Drawing.Color.Transparent;
            this.forwardBtn.Enabled = false;
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            this.forwardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtn.Image")));
            this.forwardBtn.Location = new System.Drawing.Point(72, 42);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(38, 38);
            this.forwardBtn.TabIndex = 4;
            this.forwardBtn.UseVisualStyleBackColor = false;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.AutoSize = true;
            this.refreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.Enabled = false;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.Location = new System.Drawing.Point(138, 42);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(38, 38);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // homepageBtn
            // 
            this.homepageBtn.AutoSize = true;
            this.homepageBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.homepageBtn.BackColor = System.Drawing.Color.Transparent;
            this.homepageBtn.Enabled = false;
            this.homepageBtn.FlatAppearance.BorderSize = 0;
            this.homepageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homepageBtn.Image = ((System.Drawing.Image)(resources.GetObject("homepageBtn.Image")));
            this.homepageBtn.Location = new System.Drawing.Point(207, 42);
            this.homepageBtn.Name = "homepageBtn";
            this.homepageBtn.Size = new System.Drawing.Size(38, 38);
            this.homepageBtn.TabIndex = 6;
            this.homepageBtn.UseVisualStyleBackColor = false;
            this.homepageBtn.Click += new System.EventHandler(this.homepageBtn_Click);
            // 
            // addressBar
            // 
            this.addressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressBar.BackColor = System.Drawing.Color.White;
            this.addressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBar.Location = new System.Drawing.Point(271, 45);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(377, 35);
            this.addressBar.TabIndex = 7;
            this.addressBar.TextChanged += new System.EventHandler(this.addressBarTextChanged);
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // favouriteBtn
            // 
            this.favouriteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.favouriteBtn.AutoSize = true;
            this.favouriteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.favouriteBtn.BackColor = System.Drawing.Color.Transparent;
            this.favouriteBtn.FlatAppearance.BorderSize = 0;
            this.favouriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.favouriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("favouriteBtn.Image")));
            this.favouriteBtn.Location = new System.Drawing.Point(747, 42);
            this.favouriteBtn.Name = "favouriteBtn";
            this.favouriteBtn.Size = new System.Drawing.Size(38, 38);
            this.favouriteBtn.TabIndex = 8;
            this.favouriteBtn.UseVisualStyleBackColor = false;
            this.favouriteBtn.Click += new System.EventHandler(this.favouriteBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyBtn.AutoSize = true;
            this.historyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.historyBtn.BackColor = System.Drawing.Color.Transparent;
            this.historyBtn.FlatAppearance.BorderSize = 0;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.historyBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyBtn.Image")));
            this.historyBtn.Location = new System.Drawing.Point(806, 42);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(38, 38);
            this.historyBtn.TabIndex = 9;
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.historyBtn_Click);
            // 
            // goBtn
            // 
            this.goBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goBtn.AutoSize = true;
            this.goBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.goBtn.BackColor = System.Drawing.Color.Transparent;
            this.goBtn.FlatAppearance.BorderSize = 0;
            this.goBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBtn.Image = ((System.Drawing.Image)(resources.GetObject("goBtn.Image")));
            this.goBtn.Location = new System.Drawing.Point(693, 42);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(38, 38);
            this.goBtn.TabIndex = 10;
            this.goBtn.TabStop = false;
            this.goBtn.UseVisualStyleBackColor = false;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(74, 4);
            // 
            // switchViewBtn
            // 
            this.switchViewBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.switchViewBtn.AutoSize = true;
            this.switchViewBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchViewBtn.BackColor = System.Drawing.Color.Transparent;
            this.switchViewBtn.FlatAppearance.BorderSize = 0;
            this.switchViewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("switchViewBtn.Image")));
            this.switchViewBtn.Location = new System.Drawing.Point(867, 42);
            this.switchViewBtn.Name = "switchViewBtn";
            this.switchViewBtn.Size = new System.Drawing.Size(38, 38);
            this.switchViewBtn.TabIndex = 13;
            this.switchViewBtn.UseVisualStyleBackColor = false;
            this.switchViewBtn.Click += new System.EventHandler(this.switchViewBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.White;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(724, 142);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(181, 149);
            this.listBox1.TabIndex = 14;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // favouritesLbl
            // 
            this.favouritesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favouritesLbl.AutoSize = true;
            this.favouritesLbl.Location = new System.Drawing.Point(720, 108);
            this.favouritesLbl.Name = "favouritesLbl";
            this.favouritesLbl.Size = new System.Drawing.Size(83, 20);
            this.favouritesLbl.TabIndex = 15;
            this.favouritesLbl.Text = "Favourites";
            // 
            // addfavouriteBtn
            // 
            this.addfavouriteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addfavouriteBtn.AutoSize = true;
            this.addfavouriteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addfavouriteBtn.FlatAppearance.BorderSize = 0;
            this.addfavouriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addfavouriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("addfavouriteBtn.Image")));
            this.addfavouriteBtn.Location = new System.Drawing.Point(738, 294);
            this.addfavouriteBtn.Name = "addfavouriteBtn";
            this.addfavouriteBtn.Size = new System.Drawing.Size(22, 22);
            this.addfavouriteBtn.TabIndex = 16;
            this.addfavouriteBtn.UseVisualStyleBackColor = true;
            this.addfavouriteBtn.Click += new System.EventHandler(this.addTofavouritesToolStripMenuItem_Click);
            // 
            // editfavouriteBtn
            // 
            this.editfavouriteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editfavouriteBtn.AutoSize = true;
            this.editfavouriteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editfavouriteBtn.FlatAppearance.BorderSize = 0;
            this.editfavouriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editfavouriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("editfavouriteBtn.Image")));
            this.editfavouriteBtn.Location = new System.Drawing.Point(797, 294);
            this.editfavouriteBtn.Name = "editfavouriteBtn";
            this.editfavouriteBtn.Size = new System.Drawing.Size(22, 22);
            this.editfavouriteBtn.TabIndex = 17;
            this.editfavouriteBtn.UseVisualStyleBackColor = true;
            this.editfavouriteBtn.Click += new System.EventHandler(this.editfavouriteBtn_Click);
            // 
            // deletefavouriteBtn
            // 
            this.deletefavouriteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletefavouriteBtn.AutoSize = true;
            this.deletefavouriteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deletefavouriteBtn.FlatAppearance.BorderSize = 0;
            this.deletefavouriteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletefavouriteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deletefavouriteBtn.Image")));
            this.deletefavouriteBtn.Location = new System.Drawing.Point(857, 294);
            this.deletefavouriteBtn.Name = "deletefavouriteBtn";
            this.deletefavouriteBtn.Size = new System.Drawing.Size(22, 22);
            this.deletefavouriteBtn.TabIndex = 18;
            this.deletefavouriteBtn.UseVisualStyleBackColor = true;
            this.deletefavouriteBtn.Click += new System.EventHandler(this.deletefavouriteBtn_Click);
            // 
            // tabController
            // 
            this.tabController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabController.Controls.Add(this.addTabBtn);
            this.tabController.DisplayStyle = System.Windows.Forms.TabStyle.Chrome;
            // 
            // 
            // 
            this.tabController.DisplayStyleProvider.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.tabController.DisplayStyleProvider.BorderColorHot = System.Drawing.SystemColors.ControlDark;
            this.tabController.DisplayStyleProvider.BorderColorSelected = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
            this.tabController.DisplayStyleProvider.CloserColor = System.Drawing.Color.DarkGray;
            this.tabController.DisplayStyleProvider.CloserColorActive = System.Drawing.Color.White;
            this.tabController.DisplayStyleProvider.FocusTrack = false;
            this.tabController.DisplayStyleProvider.HotTrack = true;
            this.tabController.DisplayStyleProvider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tabController.DisplayStyleProvider.Opacity = 1F;
            this.tabController.DisplayStyleProvider.Overlap = 16;
            this.tabController.DisplayStyleProvider.Padding = new System.Drawing.Point(7, 5);
            this.tabController.DisplayStyleProvider.Radius = 16;
            this.tabController.DisplayStyleProvider.ShowTabCloser = true;
            this.tabController.DisplayStyleProvider.TextColor = System.Drawing.SystemColors.ControlText;
            this.tabController.DisplayStyleProvider.TextColorDisabled = System.Drawing.SystemColors.ControlDark;
            this.tabController.DisplayStyleProvider.TextColorSelected = System.Drawing.SystemColors.ControlText;
            this.tabController.HotTrack = true;
            this.tabController.Location = new System.Drawing.Point(12, 108);
            this.tabController.Name = "tabController";
            this.tabController.SelectedIndex = 0;
            this.tabController.Size = new System.Drawing.Size(687, 208);
            this.tabController.TabIndex = 12;
            this.tabController.Click += new System.EventHandler(this.tabSelect);
            // 
            // addTabBtn
            // 
            this.addTabBtn.Location = new System.Drawing.Point(4, 34);
            this.addTabBtn.Name = "addTabBtn";
            this.addTabBtn.Padding = new System.Windows.Forms.Padding(3);
            this.addTabBtn.Size = new System.Drawing.Size(679, 170);
            this.addTabBtn.TabIndex = 1;
            this.addTabBtn.Text = "Add Tab";
            this.addTabBtn.UseVisualStyleBackColor = true;
            this.addTabBtn.Enter += new System.EventHandler(this.addTabBtn_Click);
            // 
            // WindowGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 328);
            this.Controls.Add(this.deletefavouriteBtn);
            this.Controls.Add(this.editfavouriteBtn);
            this.Controls.Add(this.addfavouriteBtn);
            this.Controls.Add(this.favouritesLbl);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.switchViewBtn);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.favouriteBtn);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.homepageBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowGUI";
            this.Text = "Web Browser";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WindowGUI_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button homepageBtn;
        public System.Windows.Forms.TextBox addressBar;
        private System.Windows.Forms.Button favouriteBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CustomTabControl tabController;
        private System.Windows.Forms.TabPage addTabBtn;
        private System.Windows.Forms.Button switchViewBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label favouritesLbl;
        private System.Windows.Forms.ToolStripMenuItem homepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setAsHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editHomepageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTofavouritesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button addfavouriteBtn;
        private System.Windows.Forms.Button editfavouriteBtn;
        private System.Windows.Forms.Button deletefavouriteBtn;
        private System.Windows.Forms.ToolStripMenuItem clearHistoryToolStripMenuItem;
    }
}

