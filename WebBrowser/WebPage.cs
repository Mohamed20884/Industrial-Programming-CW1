using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    class WebPage
    { 
        public string url { get; set; }

        public string html { get; set; }

        public string date { get; set; }

        public Image icon { get; set; }

        public WebPage(string url, string html, string date, Image icon)
        {
            this.url = url;
            this.html = html;
            this.date = date;
            this.icon = icon;
        } 
        public static async Task<WebPage> getWebPage(string url)
        {
            WebPage resultPage = new WebPage("","","",null);
            string iconUrl = "";
            if (!url.StartsWith("http"))
                if (!url.StartsWith("www"))
                    url = "http://www." + url;
                else
                    url = "http://" + url;
            iconUrl = url + "/favicon.ico";

            Task<string[]> pageTask =  resultPage.getPage(url);
            string[] page = await pageTask;

            Task<Image> imageTask = resultPage.getIcon(iconUrl);
            Image icon = await imageTask;
            resultPage.url = page[0];
            resultPage.html = page[1];
            resultPage.date = page[2];
            resultPage.icon = icon;
            return resultPage;
        }


        public async Task<string[]> getPage(string url)
        {
            string[] result = new string[3];
            result[0] = url;
            Task<HttpWebResponse> getRes;
            try {
                getRes = getResponse(url);
                HttpWebResponse res = await getRes;
                Stream data = res.GetResponseStream();
                using (StreamReader sr = new StreamReader(data))
                {
                    result[1] = sr.ReadToEnd();
                }

            } catch (WebException e)
            {
                this.html = ("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    this.html = this.html + ("\nStatus Code : " + ((HttpWebResponse)e.Response).StatusCode);
                    this.html = this.html + ("\nStatus Description : " + ((HttpWebResponse)e.Response).StatusDescription);
                }
            }
            result[2] = DateTime.Now.ToString();
            return result;
        }

        public async Task<HttpWebResponse> getResponse(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            Task<WebResponse> resTask = null;
            try
            {
                resTask = req.GetResponseAsync();
            }
            catch (WebException e)
            {

            }

            return (HttpWebResponse) await resTask;
        }

        public async Task<Image> getIcon(string url)
        {

            Image icon = null;
            try {
                Task<HttpWebResponse> getRes = getResponse(url);
                HttpWebResponse res = await getRes;
                icon = Image.FromStream(res.GetResponseStream());
            }
            catch(Exception e)
            {

            }
                  
            
            return icon;
        }

    }
}
