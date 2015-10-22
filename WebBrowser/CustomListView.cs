using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class CustomListView : UserControl
    {
        public CustomListView()
        {
            InitializeComponent();
            Task<WebPage> page = WebPage.getWebPage("google.com");
            this.listView1.LargeImageList = new ImageList();
            this.listView1.LargeImageList.Images.Add(page.Result.url, page.Result.icon);
            this.listView1.Items[0].ImageKey = page.Result.url;
        }
    }
}
