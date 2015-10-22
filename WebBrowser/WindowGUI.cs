using CefSharp.WinForms;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WebBrowser
{
    public partial class WindowGUI : Form
    {
        int originalScreenWidth;
        bool graphical = false;
        bool first = true;

        public WindowGUI()
        {
            InitializeComponent();
            addTab();
            originalScreenWidth = this.Width;
            this.addressBar.Text = Properties.Settings.Default.HomePage;
            Tab tab = (Tab) this.tabController.SelectedTab.Controls[0];
            tab.localHistory.Add((Properties.Settings.Default.HomePage));
            this.tabController.ImageList = new ImageList();
            setDisplay();
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            setDisplay();
        }

        public async Task setDisplay()
        {
            Task<WebPage> page = WebPage.getWebPage(this.addressBar.Text);
            Tab tab = (Tab)this.tabController.SelectedTab.Controls[0];
            if (graphical)
            {
                ChromiumWebBrowser browser = (ChromiumWebBrowser)this.tabController.SelectedTab.Controls[0].Controls[1];
                browser.Load(this.addressBar.Text);
            }
            else
            {
                FastColoredTextBox display = (FastColoredTextBox)tab.Controls[0];
                display.Text = page.Result.html;
                this.refreshBtn.Enabled = true;
                display.SyntaxHighlighter.HTMLSyntaxHighlight(display.Range);
            }
            if (tab.localHistory.Count != 0)
                {
                    if (this.addressBar.Text != tab.localHistory[tab.localHistoryPointer])
                    {
                        this.backBtn.Enabled = true;
                        if (tab.localHistoryPointer + 1 != tab.localHistory.Count)
                            tab.localHistory.RemoveRange(tab.localHistoryPointer, tab.localHistory.Count - tab.localHistoryPointer - 1);
                        tab.localHistory.Add(page.Result.url);
                        tab.localHistoryPointer = tab.localHistory.Count - 1;

                    }
                }
                else
                {
                    tab.localHistory.Add(page.Result.url);
                    tab.localHistoryPointer = tab.localHistory.Count - 1;
                }
            try
            {
                this.tabController.ImageList.Images.RemoveByKey(this.tabController.SelectedIndex.ToString());
            }
            catch (Exception e)
            {

            }
            this.addressBar.Text = page.Result.url;
            this.tabController.ImageList.Images.Add(this.tabController.SelectedIndex.ToString(), page.Result.icon);
            this.tabController.SelectedTab.ImageKey = this.tabController.SelectedIndex.ToString();
            
        }

        private void addTab()
        {
            TabPage newTab = new TabPage();
            Tab tab = new Tab();
            tab.Dock = DockStyle.Fill;
            newTab.Controls.Add(tab);
            newTab.Text = "New Tab";
            this.tabController.TabPages.Add(newTab);

                       


            tabController.TabPages[tabController.TabPages.Count - 1] = addTabBtn;
            tabController.TabPages[tabController.TabPages.Count - 2] = newTab;

            tabController.SelectTab(tabController.TabCount - 2);
            this.addressBar.Text = "";
        }
        private void screenResize(object sender, EventArgs e)
        {
            if (!first)
            {
                int newWidth = (this.Width - originalScreenWidth) + this.addressBar.Width;
                this.addressBar.Width = newWidth;
                originalScreenWidth = this.Width;
            }
            else
                first = false;
        }

        private void addTabBtn_Click(object sender, EventArgs e)
        {
            addTab();
        }

        private void bookmarkBtn_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Tab tab = (Tab) this.tabController.SelectedTab.Controls[0];
            tab.localHistoryPointer--;
            this.addressBar.Text = tab.localHistory[tab.localHistoryPointer];
            this.forwardBtn.Enabled = true;
            setDisplay();
            if (tab.localHistoryPointer == 0)
                this.backBtn.Enabled = false;
        }

        private void forwardBtn_Click(object sender, EventArgs e)
        {
            Tab tab = (Tab)this.tabController.SelectedTab.Controls[0];
            tab.localHistoryPointer++;
            this.addressBar.Text = tab.localHistory[tab.localHistoryPointer];
            this.backBtn.Enabled = true;
            setDisplay();
            if (tab.localHistoryPointer == tab.localHistory.Count - 1)
                this.forwardBtn.Enabled = false;
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            setDisplay();
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTab();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowGUI newWindow = new WindowGUI();
            newWindow.Show();
        }

        private void homepageBtn_Click(object sender, EventArgs e)
        {
            this.addressBar.Text = Properties.Settings.Default.HomePage;
            setDisplay();
        }

        private void addressBarTextChanged(object sender, EventArgs e)
        {

        }
        private void tabSelect(object sender, EventArgs e)
        {
            if (graphical)
            {
                this.tabController.SelectedTab.Controls[0].Controls[0].Hide();
                this.tabController.SelectedTab.Controls[0].Controls[1].Show();
            }else
            {
                this.tabController.SelectedTab.Controls[0].Controls[1].Hide();
                this.tabController.SelectedTab.Controls[0].Controls[0].Show();
            }
            Tab tab = (Tab) this.tabController.SelectedTab.Controls[0];
            if (tab.localHistory.Count != 0)
            {
                this.refreshBtn.Enabled = true;
                this.addressBar.Text = tab.localHistory[tab.localHistoryPointer];
                if (tab.localHistoryPointer != 0)
                    this.backBtn.Enabled = true;


                if (tab.localHistoryPointer != tab.localHistory.Count - 1)
                    this.forwardBtn.Enabled = true;
                else
                    this.forwardBtn.Enabled = false;
            }
            else
            {
                this.addressBar.Text = "";
                this.refreshBtn.Enabled = false;
                this.backBtn.Enabled = false;
            }
        }

        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && this.backBtn.Enabled == true)
                backBtn_Click(null, null);
            if (e.KeyCode == Keys.F5)
                refreshBtn_Click(null, null);
        }

        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                setDisplay();
        }

        private void switchViewBtn_Click(object sender, EventArgs e)
        {
            Tab tab = (Tab) this.tabController.SelectedTab.Controls[0];
            FastColoredTextBox tb = (FastColoredTextBox)tab.Controls[0];
            ChromiumWebBrowser browser = (ChromiumWebBrowser) tab.Controls[1];
            if (!graphical)
            {
                tb.Hide();
                browser.Show();
                browser.Load(this.addressBar.Text);
                this.graphical = true;
            }
            else
            {
                browser.Hide();
                tb.Show();
                setDisplay();
                this.graphical = false;
            }
        }
    }
}
