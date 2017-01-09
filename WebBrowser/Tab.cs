using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using CefSharp.WinForms;
using CefSharp;
using System.Text.RegularExpressions;

namespace WebBrowser
{

    /// <summary>
    ///     Classed used to store and do logic related manipulation for tabs
    /// </summary>
    public partial class Tab : UserControl
    {
        public List<string> localHistory { get; set; }
        public int localHistoryPointer { get; set; }
        public TextBox addressBar { get; set; }
        public bool graphical { get; set; }
        public string url { get; set; }
        public int index { get; set; }
        public string title { get; set; }
        public Button backBtn { get; set; }

        public WindowGUI window;

        public CustomTabControl tabController { get; set; }

        /// <summary>
        ///     initializes the user control and adds the chromium browser control and fast colored textbox control
        ///     sets them to fill this object and hides the browser as the required default is the textbox 
        /// </summary>
        public Tab()
        {
            InitializeComponent();
            FastColoredTextBox display = new FastColoredTextBox();
            display.Name = "display";
            display.Dock = DockStyle.Fill;
            display.ReadOnly = true;
            var browser = new ChromiumWebBrowser(null)
            {
                Dock = DockStyle.Fill,
                Name = "browser"
            };
            browser.Hide();
            browser.AddressChanged += OnBrowserAddressChanged;
            this.Controls.Add(display);
            this.Controls.Add(browser);
            localHistory = new List<string>();
            localHistoryPointer = 0;
        }
        private string getTitleFromHtml(string html)
        {
            string temp = Regex.Match(html, @"(\<title\b[^>]*\>\s*(?<Title>[\s\S]*?)\</title\>)", RegexOptions.IgnoreCase).Groups["Title"].Value;
            if (temp != "")
                return temp;
            else
                return Regex.Match(html, @"(\([0-9]+\).*)", RegexOptions.IgnoreCase).Value;
        }
        /// <summary>
        ///     sets the display of the application to match the requested webpage
        /// </summary>
        public void setDisplay()
        {
            WebPage page = WebPage.getWebPage(url);
            //Valid URI
            if (page != null)
            {
                this.url = page.url;
                addLocalHistory(this.url);
                this.title = getTitleFromHtml(page.html);
                this.window.history.Add(new History(title, page.url, DateTime.Now.ToString()));
                XMLManager.saveDataToFile("History.xml", this.window.history);

                try
                {
                    WindowGUI window = (WindowGUI)this.addressBar.Parent;
                    window.title = this.title;
                    
                    this.addressBar.Invoke(new MethodInvoker(delegate { this.addressBar.Text = page.url; }));
                    this.tabController.Invoke(new MethodInvoker(delegate { this.tabController.SelectedTab.Text = this.title; }));
                    this.tabController.ImageList.Images.RemoveByKey(index.ToString());
                    this.tabController.ImageList.Images.Add(index.ToString(), page.icon);
                }
                catch (Exception e)
                {
                    //window closed
                }

                TabPage current = this.tabController.TabPages[index];
                if (graphical)
                {
                    ChromiumWebBrowser browser = (ChromiumWebBrowser)this.Controls[1];
                    browser.Load(url);
                }
                else
                {
                    FastColoredTextBox textDisplay = (FastColoredTextBox)this.Controls[0];
                    try
                    {
                        textDisplay.Invoke(new MethodInvoker(delegate { textDisplay.Text = page.html; }));
                        textDisplay.SyntaxHighlighter.HTMLSyntaxHighlight(textDisplay.Range);
                        current.Invoke(new MethodInvoker(delegate { current.ImageKey = index.ToString(); }));
                    }
                    catch (Exception e)
                    {
                        //tab closed
                    }
                }
            }//Invalid URI
            else
            { 
                MessageBox.Show("Invalid URI");
            }
        }

        /// <summary>
        ///     Adds the supplied url to the localHistory list if it is not equal to the one before it
        /// </summary>
        /// <param name="url"></param>
        public void addLocalHistory(string url)
        {
            if (this.localHistory.Count != 0)
            {
                if (url != this.localHistory[this.localHistoryPointer])
                {
                    try {
                        this.backBtn.Invoke(new MethodInvoker(delegate { this.backBtn.Enabled = true; }));
                    }
                    catch(Exception e)
                    {
                        //window closed
                    }
                    if (this.localHistoryPointer + 1 != this.localHistory.Count)
                        this.localHistory.RemoveRange(this.localHistoryPointer, this.localHistory.Count - this.localHistoryPointer - 1);
                    this.localHistory.Add(url);
                    this.localHistoryPointer = this.localHistory.Count - 1;
                }
            }
            else
            {
                this.localHistory.Add(url);
                this.localHistoryPointer = this.localHistory.Count - 1;
            }
        }
        /// <summary>
        ///     captures the changes in the browser control and sets display accorddingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            var window = (WindowGUI) this.Parent.Parent.Parent;
            ChromiumWebBrowser browser = (ChromiumWebBrowser) this.Controls[1];
            addLocalHistory(browser.Address);
            string title = getTitleFromHtml(WebPage.getPage(browser.Address)[1]);
            window.history.Add(new History(title, browser.Address, DateTime.Now.ToString()));
            try
            {
                this.addressBar.Invoke(new MethodInvoker(delegate { this.addressBar.Text = browser.Address; }));
                this.tabController.Invoke(new MethodInvoker(delegate { this.tabController.SelectedTab.Text = title; }));
            }
            catch (Exception e)
            {
                // window closed
            }
        }

        internal WebPage WebPage
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
