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

namespace WebBrowser
{
    public partial class Tab : UserControl
    {
        public List<string> localHistory { get; set; }
        public int localHistoryPointer { get; set; }
        public Tab()
        {
            InitializeComponent();
            FastColoredTextBox display = new FastColoredTextBox();
            display.Name = "display";
            display.Dock = DockStyle.Fill;
            display.ReadOnly = true;
            var browser = new ChromiumWebBrowser(null)
            {
                Dock = DockStyle.Fill

            };
            //browser.AddressChanged += OnBrowserAddressChanged;
            browser.Hide();
            this.Controls.Add(display);
            this.Controls.Add(browser);
            localHistory = new List<string>();
            localHistoryPointer = 0;
        }

        private void OnBrowserAddressChanged(object sender, AddressChangedEventArgs args)
        {
            var window = (WindowGUI) this.Parent.Parent.Parent;
            //window.addressBar.Text = args.Address;
            //window.setDisplay();
        }
    }
}
