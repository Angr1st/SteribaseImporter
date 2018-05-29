using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SteribaseImporter.XML
{
    static class XmlNodeListExtension
    {
        public static List<XmlNode> ToXmlNodeList(this XmlNodeList nodeList)
        {
            var elementList = new List<XmlNode>();
            foreach (XmlNode item in nodeList)
            {
                elementList.Add(item);
            }
            return elementList;
        }
    }
}
