using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class History
    {
        public string name { get; set; }
        public string address { get; set; }
        public string datetime { get; set; }

        /// <summary>
        ///     empty history constructor, required for the deserialization of xml representation
        /// </summary>
        public History()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="datetime"></param>
        public History(string name, string address, string datetime)
        {
            this.name = name;
            this.address = address;
            this.datetime = datetime;
        }
    }
}
