using CefSharp.WinForms;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WebBrowser
{
    public partial class WindowGUI : Form
    {
        bool graphical = false;
        bool first = true;
        public List<History> history = new List<History>();
        public List<Favourite> favourites = new List<Favourite>();
        public string title;
        
        public int selectedTab = 0;

        /// <summary>
        ///     WindowGUI constructor
        /// </summary>
        public WindowGUI()
        {
            InitializeComponent();
            //make sure the files exists before modifying them
            if (!File.Exists("Favourites.xml"))
            {
                XDocument root = new XDocument(new XElement("Root"));
                root.Save("Favourites.xml");
            }
            if (!File.Exists("History.xml"))
            {
                XDocument root = new XDocument(new XElement("Root"));
                root.Save("History.xml");
            }
            //add a new tab to the tab controller since it starts with only the add tab
            addTab();
            //set tab to display homepage if it is not empty
            if (Properties.Settings.Default.HomePage != "")
            {
                this.homepageBtn.Enabled = true;
                this.addressBar.Text = Properties.Settings.Default.HomePage;
                setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
            }
            this.tabController.ImageList = new ImageList();
            //run the getting of favourites and history in seperate threads
            Thread tb = new Thread(new ThreadStart(getfavourite));
            tb.Priority = ThreadPriority.Lowest;
            tb.Start();
            Thread th = new Thread(new ThreadStart(getHistory));
            th.Priority = ThreadPriority.Lowest;
            th.Start();
            
        }
        /// <summary>
        ///     Gets favourites from file and updates the listbox1 items
        /// </summary>
        private void getfavourite()
        {
            XMLManager.getList(XMLManager.getDataFromFile("Favourites.xml"), ref this.favourites);
            while (true)
            {
                try
                {
                    updatefavouriteList();
                    break;
                }
                catch (InvalidOperationException e)
                {
                    // listbox not yet initialized
                }
            }
        }
        /// <summary>
        ///     gets history from file and stores it in <paramref name="this.history"/>
        /// </summary>
        private void getHistory()
        {
            try
            {
                XMLManager.getList(XMLManager.getDataFromFile("History.xml"), ref this.history);
            }
            catch (Exception e)
            {

            }
        }

        /// <summary>
        ///     Sets display to the url in the addressBar in the selecttab when the event is triggered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void goBtn_Click(object sender, EventArgs e)
        {
            setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
        }
        
        /// <summary>
        ///     Sets Tab object member variables and a new thread to set the display to the 
        ///     webpage that results from the supplied url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="selectedTab"></param>
        public void setDisplay(string url, int selectedTab)
        {
            if (this.tabController.SelectedTab.Text == "History Tab")
            {
                addTab();
                selectedTab = this.tabController.SelectedIndex;
            }
            this.tabController.SelectedTab.Text = "Loading ...";
            Tab tab = (Tab) this.tabController.TabPages[selectedTab].Controls[0];
            tab.url = url;
            tab.index = selectedTab;
            tab.addressBar = this.addressBar;
            tab.backBtn = this.backBtn;
            tab.tabController = this.tabController;
            tab.graphical = this.graphical;
            Thread t = new Thread(new ThreadStart(tab.setDisplay));
            t.Priority = ThreadPriority.Highest;
            t.Start();
            this.title = tab.title;
        }

        /// <summary>
        ///     adds a new tabpage to the tabcontroller and adds the tab object to that tabpage
        /// </summary>
        public void addTab()
        {
            TabPage newTab = new TabPage();
            Tab tab = new Tab();
            tab.window = this;
            tab.Dock = DockStyle.Fill;
            newTab.Controls.Add(tab);
            newTab.Text = "New Tab";
            this.tabController.TabPages.Add(newTab);
            
            //swaps the last and selcond last tabs orders so that the add tab is always at the end
            tabController.TabPages[tabController.TabPages.Count - 1] = addTabBtn;
            tabController.TabPages[tabController.TabPages.Count - 2] = newTab;

            tabController.SelectTab(tabController.TabCount - 2);
            this.addressBar.Text = "";
            this.selectedTab = this.tabController.SelectedIndex;
            this.title = "";
        }
        /// <summary>
        ///     handles the add tab button click and adds a new tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTabBtn_Click(object sender, EventArgs e)
        {
            addTab();
        }

        bool showbox = false;
        /// <summary>
        ///     shows or hides the bookmarks related compontents at the side of the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void favouriteBtn_Click(object sender, EventArgs e)
        {
            if(showbox)
            {
                this.listBox1.Show();
                this.addfavouriteBtn.Show();
                this.editfavouriteBtn.Show();
                this.deletefavouriteBtn.Show();
                this.favouritesLbl.Show();
                this.tabController.Width = this.tabController.Width - this.listBox1.Width - 10;
                showbox = false;
            }
            else
            {
                this.listBox1.Hide();
                this.addfavouriteBtn.Hide();
                this.editfavouriteBtn.Hide();
                this.deletefavouriteBtn.Hide();
                this.favouritesLbl.Hide();
                this.tabController.Width = this.tabController.Width + this.listBox1.Width + 10;
                showbox = true;
            }
            
        }
        /// <summary>
        ///     handles the back button click by setting the display to the previous page in the localHistory
        ///     and enabling/disabling the foward/backward button based on the localHistoryPointer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backBtn_Click(object sender, EventArgs e)
        {
            Tab tab = (Tab) this.tabController.SelectedTab.Controls[0];
            tab.localHistoryPointer--;
            this.forwardBtn.Enabled = true;
            if (tab.localHistoryPointer == 0)
                this.backBtn.Enabled = false;
            this.addressBar.Text = tab.localHistory[tab.localHistoryPointer];
            setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
        }

        /// <summary>
        ///     handles the forward button click by setting the display to the next page in the localHistory
        ///     and enabling/disabling the foward/backward button based on the localHistoryPointer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            Tab tab = (Tab)this.tabController.SelectedTab.Controls[0];
            tab.localHistoryPointer++;
            this.backBtn.Enabled = true;
            if (tab.localHistoryPointer == tab.localHistory.Count - 1)
                this.forwardBtn.Enabled = false;
            this.addressBar.Text = tab.localHistory[tab.localHistoryPointer];
            setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
        }

        /// <summary>
        ///     handles the refresh button click by reloading the currentlly loaded page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
        }

        /// <summary>
        ///     handles the new tab menustrip item click but adding a new tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTab();
        }

        /// <summary>
        ///     handles the new window menustrip item click but adding a new window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowGUI newWindow = new WindowGUI();
            newWindow.Show();
        }

        /// <summary>
        ///     handles the homepage button click by loading the homepage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homepageBtn_Click(object sender, EventArgs e)
        {
            setDisplay(Properties.Settings.Default.HomePage.ToString(), this.tabController.SelectedIndex);
        }

        /// <summary>
        ///     enables/disables the go/setAsHomepageitem based on the contents of the addressBar 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressBarTextChanged(object sender, EventArgs e)
        {
            if(this.addressBar.Text != "")
            {
                this.goBtn.Enabled = true;
                this.setAsHomepageToolStripMenuItem.Enabled = true;
            }
            else
            {
                //can't go to empty page
                this.goBtn.Enabled = false;
                this.setAsHomepageToolStripMenuItem.Enabled = false;
            }
        }
        /// <summary>
        ///     handles the tab select event by setting the localHistory, localHistoyPointer and the buttons
        ///     to the selected tab values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabSelect(object sender, EventArgs e)
        {
            this.selectedTab = this.tabController.SelectedIndex;
            Tab tab = (Tab)this.tabController.SelectedTab.Controls[0];
            if (tab.title != "History Tab")
            {
                if (graphical)
                {
                    this.tabController.SelectedTab.Controls[0].Controls[0].Hide();
                    this.tabController.SelectedTab.Controls[0].Controls[1].Show();
                }
                else
                {
                    this.tabController.SelectedTab.Controls[0].Controls[1].Hide();
                    this.tabController.SelectedTab.Controls[0].Controls[0].Show();
                }
                this.title = tab.title;
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
                    this.forwardBtn.Enabled = false;
                }
            }
        }
        
        /// <summary>
        ///     handles the press enter event in the addressBar by setting the display to the
        ///     corresponding web page 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addressBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
        }
        /// <summary>
        ///     handles the switch view button click and sets the display for the newly selected view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void switchViewBtn_Click(object sender, EventArgs e)
        {
            Tab tab = (Tab) this.tabController.SelectedTab.Controls[0];
            FastColoredTextBox tb = (FastColoredTextBox)tab.Controls[0];
            ChromiumWebBrowser browser = (ChromiumWebBrowser) tab.Controls[1];
            if (!graphical)
            {
                tb.Hide();
                browser.Show();
                this.graphical = true;
                setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
                
            }
            else
            {
                browser.Hide();
                tb.Show();
                this.graphical = false;
                setDisplay(this.addressBar.Text, this.tabController.SelectedIndex);
                
            }
        }
        /// <summary>
        ///     handles the set as homepage item click by setting the homepage to the addressbar value
        ///     in the setting enabling/disabling the homepage buton based on if its not empty or it is
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setAsHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HomePage = this.addressBar.Text;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.HomePage == "")
                this.homepageBtn.Enabled = false;
            else
                this.homepageBtn.Enabled = true;
            MessageBox.Show("Hompage set successfully");
        }
        /// <summary>
        ///     handles the edit homepage window add button click by setting the homepage to the addressField value
        ///     in the setting enabling/disabling the homepage buton based on if its not empty or it is
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editHomepage (object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddControl add = (AddControl)btn.Parent;
            Properties.Settings.Default.HomePage = add.Controls.Find("addressField", true)[0].Text;
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.HomePage == "")
                this.homepageBtn.Enabled = false;
            else
                this.homepageBtn.Enabled = true;
            MessageBox.Show("Homepage updated successfully");
        }
        /// <summary>
        ///     Loads new window with the addcontrol user control and sets its controls approperiatly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editHomepageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            AddControl add = new AddControl();
            add.Dock = DockStyle.Fill;
            add.Controls.Find("titleLbl", true)[0].Text = "HomePage";
            add.Controls.Find("addressField", true)[0].Text = Properties.Settings.Default.HomePage;
            add.Controls.Find("addBtn", true)[0].Click += new System.EventHandler(editHomepage);
            add.Controls.RemoveByKey("nameLbl");
            add.Controls.RemoveByKey("nameField");
            form.Controls.Add(add);
            form.Show();
        }
        /// <summary>
        ///     updates listbox1 items with the stored favourites 
        /// </summary>
        private void updatefavouriteList()
        {
            this.listBox1.Invoke(new MethodInvoker(delegate { this.listBox1.Items.Clear(); }));
            foreach (var b in this.favourites)
            {
                this.listBox1.Invoke(new MethodInvoker(delegate { listBox1.Items.Add(b.name); }));
            }

        }

        /// <summary>
        ///     adds the favourite item to favourites and saves it to the file if it is not already there
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addfavourite(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddControl add = (AddControl)btn.Parent;
            if (!infavourites(add.Controls.Find("nameField", true)[0].Text, add.Controls.Find("addressField", true)[0].Text, this.favourites, null))
            {
                this.favourites.Add(new Favourite(add.Controls.Find("nameField", true)[0].Text, add.Controls.Find("addressField", true)[0].Text));
                XMLManager.saveDataToFile("Favourites.xml", this.favourites);
                MessageBox.Show("Favourite successfully added");
                updatefavouriteList();
            }
        }
        /// <summary>
        ///     checks to see if there is a favourite item with the name/address or both and
        ///     responds accordingly
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="list"></param>
        /// <param name="index"></param> used to handle setting a favourite to the same value as its self when editing
        /// <returns>true/false depending if it is in favourites or not</returns>
        public bool infavourites(string name, string address, List<Favourite> list, Nullable<int> index)
        {
            bool result = false;
            for(int i = 0; i < list.Count; i++)
            {
                if (index == null || index != i)
                {
                    if (list[i].name == name && list[i].address == address)
                    {
                        MessageBox.Show("This favourite already exists");
                        result = true;
                        break;
                    }
                    else if (list[i].name == name && list[i].address != address)
                    {
                        MessageBox.Show("A favourite with this name already exists");
                        result = true;
                        break;
                    }
                    else if (list[i].address == address && list[i].name != name)
                    {
                        MessageBox.Show("A favourite with this address already exists");
                        result = true;
                        break;
                    }
                }

            }
            return result;
        }

        /// <summary>
        ///     launches a new window with the addcontrol control and sets its values accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addTofavouritesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            AddControl add = new AddControl();
            Tab tab = (Tab)this.tabController.SelectedTab.Controls[0];
            add.Dock = DockStyle.Fill;
            add.Controls.Find("titleLbl", true)[0].Text = "favourites";
            add.Controls.Find("nameField", true)[0].Text = tab.title;
            add.Controls.Find("addressField", true)[0].Text = this.addressBar.Text;
            add.Controls.Find("addBtn", true)[0].Click += new System.EventHandler(this.addfavourite);
            form.Controls.Add(add);
            form.Show();
        }
        /// <summary>
        ///     used to view tooltip for the selected item in the favourites listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index > -1)
            {
                toolTip1.Active = false;
                toolTip1.SetToolTip(this.listBox1, (this.favourites[index]).name);
                toolTip1.Active = true;
            }

        }
        /// <summary>
        ///     used to load the selected favourites page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.SelectedIndex;
            if (index > -1)
            {
                this.addressBar.Text = this.favourites[index].address;
                setDisplay(this.addressBar.Text, this.selectedTab);
            }

        }
        /// <summary>
        ///     launches a new window with the addcontrol control and sets its values accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editfavouriteBtn_Click(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedIndex != -1)
            {
                Form form = new Form();
                AddControl add = new AddControl();
                add.Dock = DockStyle.Fill;
                Tab tab = (Tab)this.tabController.SelectedTab.Controls[0];
                add.Controls.Find("titleLbl", true)[0].Text = "favourites";
                add.Controls.Find("nameField", true)[0].Text = this.listBox1.SelectedItem.ToString();
                add.Controls.Find("addressField", true)[0].Text = this.favourites[this.listBox1.SelectedIndex].address;
                add.Controls.Find("addBtn", true)[0].Click += new System.EventHandler(this.editfavourite);
                form.Controls.Add(add);
                form.Show();
            }
            else
            {
                MessageBox.Show("Please select favourite to edit");
            }
        }
        /// <summary>
        ///     sets the edited value of the selected favourite to favourites, updates list box and save to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editfavourite(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            AddControl add = (AddControl)btn.Parent;
            if (!infavourites(add.Controls[4].Text, add.Controls[3].Text, this.favourites, this.listBox1.SelectedIndex))
            {
                this.favourites[this.listBox1.SelectedIndex] = new Favourite(add.Controls.Find("nameField", true)[0].Text, add.Controls.Find("addressField", true)[0].Text);
                updatefavouriteList();
                XMLManager.saveDataToFile("Favourites.xml", this.favourites);
                MessageBox.Show("Favourite edited successfully");
            }
        }
        /// <summary>
        ///     deletes the selected favourite, updates the listbox and saves to file 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deletefavouriteBtn_Click(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedIndex != -1)
            {
                this.favourites.RemoveAt(this.listBox1.SelectedIndex);
                XMLManager.saveDataToFile("Favourites.xml", this.favourites);
                updatefavouriteList();
                MessageBox.Show("Favourite deleted successfully");
            }
            else
            {
                MessageBox.Show("Please select a favourite to delete");
            }
        }
        /// <summary>
        ///     used to find the history tab index if it exists
        /// </summary>
        /// <returns>
        ///     returns null if it isn't open or the index if it is
        /// </returns>
        private Nullable<int> findHistoryTab()
        {
            Nullable<int> i = null;
            for (int tp = 0; tp < this.tabController.TabPages.Count; tp++)
            {
                try
                {
                    Tab tab = (Tab)this.tabController.TabPages[tp].Controls[0];
                    if (tab.title == "History Tab")
                    {
                        i = tp;
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return i;
        }
        /// <summary>
        ///     opens history tab if its already open otherwise it will open new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void historyBtn_Click(object sender, EventArgs e)
        {
            Nullable<int> i = findHistoryTab();
            
            if(i == null)
            {
                addTab();
                i = this.tabController.SelectedIndex;
                TabPage tp = this.tabController.SelectedTab;
                tp.Text = "History Tab";
                tp.Enter += new System.EventHandler(updateHistory);
                Tab tab = (Tab) tp.Controls[0];
                tab.Controls.RemoveByKey("display");
                tab.Controls.RemoveByKey("browser");
                ListBox lb = new ListBox();
                lb.Name = "listBox";
                lb.Dock = DockStyle.Fill;
                lb.BorderStyle = BorderStyle.None;
                lb.ForeColor = System.Drawing.SystemColors.Highlight;
                lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lb.MouseClick += new System.Windows.Forms.MouseEventHandler(historyItemClick);
                tab.Controls.Add(lb);
                tab.title = "History Tab";
                this.tabController.SelectTab(0);
                this.tabController.SelectTab((int)i);
            }
            else
            {
                this.tabController.SelectTab((int)i);
            }
        }
        /// <summary>
        ///     updates the history listbox in the history tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void updateHistory(object sender, EventArgs e)
        {
            TabPage tp = (TabPage)sender;
            Tab tab = (Tab) tp.Controls[0];
            ListBox lb = (ListBox) tab.Controls[0];
            lb.Items.Clear();
            this.history.Reverse();
            foreach(var item in this.history)
            {
                lb.Items.Add(item.datetime + "\t" + item.name + "\t" + item.address);
            }
            this.history.Reverse();
            
        }
        /// <summary>
        ///     loads selected history webpage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void historyItemClick(object sender, MouseEventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int index = lb.SelectedIndex;
            string url;
            if (index > -1)
            {
                string item = lb.Items[index].ToString();
                url = Regex.Match(item, @"(http(s)?:\/\/)?www\..+\..+", RegexOptions.IgnoreCase).ToString();
                Console.WriteLine(url);
                addTab();
                this.addressBar.Text = url;
                setDisplay(url, this.tabController.SelectedIndex);
            }
        }
        /// <summary>
        ///     clears the saved history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.history = new List<History>();
            XMLManager.saveDataToFile("History.xml", this.history);
            MessageBox.Show("History successfully cleared");
            Nullable<int> i = findHistoryTab();
            if (i != null)
            {
                if (i == this.tabController.SelectedIndex)
                {
                    ListBox lb = (ListBox)this.tabController.TabPages[(int)i].Controls[0].Controls[0];
                    lb.Items.Clear();
                }
            }
        }
        /// <summary>
        ///     handles all window key down events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WindowGUI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.T)
                addTab();
            else if (e.Control && e.KeyCode == Keys.N)
                newWindowToolStripMenuItem_Click(null, null);
            else if (e.Control && e.Shift && e.KeyCode == Keys.H)
                clearHistoryToolStripMenuItem_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.H)
                historyBtn_Click(null, null);
            else if (e.Control && e.KeyCode == Keys.B)
                favouriteBtn_Click(null, null);
        }

        public AddControl AddControl
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Tab Tab
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal XMLManager XMLManager
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public History History
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Favourite Favourite
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
