using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebBrowser
{
    public static class ExtString
    {
        /// <summary>
        ///     deserializes a xml string representation of an object to an object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="xmlString"></param>
        /// <returns>
        ///     return object of the xml string representation
        /// </returns>
        public static T DeserializeXML<T>(this string xmlString)
        {
            T returnValue = default(T);

            XmlSerializer serial = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(xmlString);
            object result = serial.Deserialize(reader);

            if (result != null && result is T)
            {
                returnValue = ((T)result);
            }

            reader.Close();

            return returnValue;
        }
    }
}
