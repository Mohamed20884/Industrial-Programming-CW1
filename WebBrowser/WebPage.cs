using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebBrowser
{
    class WebPage
    { 
        public string url { get; set; }

        public string html { get; set; }

        public string date { get; set; }

        public Image icon { get; set; }
        /// <summary>
        ///     WebPage class Constructor
        /// </summary>
        /// <param name="url"></param>
        /// <param name="html"></param>
        /// <param name="date"></param>
        /// <param name="icon"></param>
        /// <example>
        ///     <code>
        ///         WebPage page = new WebPage("google.com", "<html><head></head><body>Example</body></html>","26/10/2015 00:00:00",image);
        ///     </code>
        /// </example>
        public WebPage(string url, string html, string date, Image icon)
        {
            this.url = url;
            this.html = html;
            this.date = date;
            this.icon = icon;
        } 
        /// <summary>
        ///     Get a new webpage object for supplied url
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        ///     WebPage object <paramref name="resultPage"/> for supplied url
        /// </returns>
        public static WebPage getWebPage(string url)
        {
            WebPage resultPage = null;
            string iconUrl = "";
            if (!url.StartsWith("http"))
                if (!url.StartsWith("www"))
                    url = "http://www." + url;
                else
                    url = "http://" + url;
            iconUrl = Regex.Match(url, @"(http(s)?:\/\/)?www\..+\..+\/", RegexOptions.IgnoreCase).ToString() + "favicon.ico";

            string[] page =  getPage(url);
            if (page != null)
            {
                Image icon = getIcon(iconUrl);
                resultPage = new WebPage(page[0], page[1], page[2], icon);
            }
            return resultPage;
            
        }

        /// <summary>
        ///     Gets the webpage for the linked supplied if it exists otherwise returns error code
        /// </summary>
        /// <param name="url"></param>
        /// <exception cref="WebException">
        ///     if getRespose return an exception set the <paramref name="result"/> second element to return error code
        /// </exception>
        /// <returns><paramref name="url"/> which has 3 values first is the response url,
        /// second is the html response, third is the date and time of the current request</returns>
        public static string[] getPage(string url)
        {
            string[] result = new string[3];
            try {
                HttpWebResponse res = getResponse(url);
                if (res != null)
                {
                    result[0] = res.ResponseUri.ToString();

                    Stream data = res.GetResponseStream();
                    using (StreamReader sr = new StreamReader(data))
                    {
                        result[1] = "200 " + res.StatusCode + "\n";
                        result[1] += sr.ReadToEnd();
                    }
                    result[2] = DateTime.Now.ToString();
                }
                else
                {
                    result = null;
                }

            } catch (WebException e)
            {
                result[0] = url;
                result[1] = ("This program is expected to throw WebException on successful run." +
                                    "\n\nException Message :" + e.Message);
                if (e.Status == WebExceptionStatus.ProtocolError)
                {
                    result[1] = result[1] + ("\nStatus Code : " + ((HttpWebResponse)e.Response).StatusCode);
                    result[1] = result[1] + ("\nStatus Description : " + ((HttpWebResponse)e.Response).StatusDescription);
                }
                result[2] = DateTime.Now.ToString();
            }
            
            return result;
        }


        /// <summary>
        ///     Gets a web response for supplied url, this throws exception caught in other methods
        /// </summary>
        /// <param name="url"></param>
        /// <returns>
        ///     An HttpWebResponse object for the supplies url
        /// </returns>
        public static HttpWebResponse getResponse(string url)
        {
            HttpWebResponse result = null;
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                result = (HttpWebResponse)req.GetResponse();
            }
            catch (UriFormatException e)
            {
                //need to handle bad url
            }
            
            return (HttpWebResponse)result;

        }
        /// <summary>
        ///     Get an image given the url
        /// </summary>
        /// <param name="url"></param>
        /// <exception cref="Exception">
        ///     throws 2 exceptions, first is the WebException from the getResponse function
        ///     second is the ArgumentException from trying to create image from stream
        /// </exception>
        /// <returns>
        ///     returns <paramref name="icon"/> as the resulting image from the requested url
        /// </returns>
        public static Image getIcon(string url)
        {

            Image icon = null;
            try {
                HttpWebResponse res = getResponse(url);
                icon = Image.FromStream(res.GetResponseStream());
            }
            catch(Exception e)
            {

            }
                  
            
            return icon;
        }

    }
}
