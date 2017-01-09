using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser
{
    public class Favourite
    {
        public string name { get; set; }

        public string address { get; set; }
        /// <summary>
        ///     empty favourite constructor, required for the deserialization of xml representation
        /// </summary>
        public Favourite()
        {

        }
        /// <summary>
        ///     favourite constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public Favourite(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
