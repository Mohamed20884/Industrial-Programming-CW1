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
            this.backBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.homepageBtn = new System.Windows.Forms.Button();
            this.addressBar = new System.Windows.Forms.TextBox();
            this.bookmarkBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.goBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.switchViewBtn = new System.Windows.Forms.Button();
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
            this.fileToolStripMenuItem});
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
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(203, 30);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
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
            this.addressBar.BackColor = System.Drawing.Color.White;
            this.addressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressBar.Location = new System.Drawing.Point(278, 54);
            this.addressBar.Name = "addressBar";
            this.addressBar.Size = new System.Drawing.Size(377, 35);
            this.addressBar.TabIndex = 7;
            this.addressBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBar_KeyDown);
            // 
            // bookmarkBtn
            // 
            this.bookmarkBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookmarkBtn.AutoSize = true;
            this.bookmarkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookmarkBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookmarkBtn.FlatAppearance.BorderSize = 0;
            this.bookmarkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookmarkBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookmarkBtn.Image")));
            this.bookmarkBtn.Location = new System.Drawing.Point(747, 42);
            this.bookmarkBtn.Name = "bookmarkBtn";
            this.bookmarkBtn.Size = new System.Drawing.Size(38, 38);
            this.bookmarkBtn.TabIndex = 8;
            this.bookmarkBtn.UseVisualStyleBackColor = false;
            this.bookmarkBtn.Click += new System.EventHandler(this.bookmarkBtn_Click);
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
            this.tabController.Size = new System.Drawing.Size(897, 208);
            this.tabController.TabIndex = 12;
            this.tabController.Click += new System.EventHandler(this.tabSelect);
            this.tabController.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            // 
            // addTabBtn
            // 
            this.addTabBtn.Location = new System.Drawing.Point(4, 34);
            this.addTabBtn.Name = "addTabBtn";
            this.addTabBtn.Padding = new System.Windows.Forms.Padding(3);
            this.addTabBtn.Size = new System.Drawing.Size(889, 170);
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
            this.Controls.Add(this.switchViewBtn);
            this.Controls.Add(this.tabController);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.bookmarkBtn);
            this.Controls.Add(this.addressBar);
            this.Controls.Add(this.homepageBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowGUI";
            this.Text = "Web Browser";
            this.SizeChanged += new System.EventHandler(this.screenResize);
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
        private System.Windows.Forms.Button bookmarkBtn;
        private System.Windows.Forms.Button historyBtn;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CustomTabControl tabController;
        private System.Windows.Forms.TabPage addTabBtn;
        private System.Windows.Forms.Button switchViewBtn;
    }
}

