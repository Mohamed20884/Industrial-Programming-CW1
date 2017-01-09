using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WebBrowser
{
    class XMLManager
    {
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

        /// <summary>
        ///     Get data from xml file
        /// </summary>
        /// <param name="filename"></param>
        /// <returns>
        ///     returns elements of the xml file
        /// </returns>
        public static IEnumerable<XElement> getDataFromFile(string filename)
        {
            XDocument doc = XDocument.Load(filename);
            
            return doc.Elements();
        }
        /// <summary>
        ///     Takes generic list and creates an xml element for every property 
        ///     and saves it to the speciefied file with <Root></Root> as the root element of the file
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filename"></param>
        /// <param name="list"></param>
        public static void saveDataToFile<T>(string filename, List<T> list)
        {
            if (list.Count != 0)
            {
                Type type = list[0].GetType();
                PropertyInfo[] properties = type.GetProperties();
                XElement result = new XElement("Root");
                foreach (var obj in list)
                {
                    XElement temp = new XElement(type.Name);
                    foreach (var property in properties)
                    {
                        temp.Add(new XElement(property.Name, property.GetValue(obj)));
                    }
                    // a faster way of doing this would be to use the object serialize extension
                    ///<example><code>
                    ///     result.Add(obj.XmlSerialize());
                    /// </code></example>
                    // wasn't used as i wanted to represent the file in a different format
                    result.Add(temp);
                }
                result.Save(filename);
            }
        }
        /// <summary>
        ///     converts supplied xml elements to objects generically and sets their value to the supplied list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xml"></param>
        /// <param name="result"></param>
        public static void getList<T>(IEnumerable<XElement> xml, ref List<T> result)
        {
            result.Clear();
            foreach(var element in xml.Elements())
            {
                result.Add(element.ToString().DeserializeXML<T>());
            }
        }
    }

}
