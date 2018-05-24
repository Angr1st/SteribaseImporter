using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace SteribaseImporter.XML
{
    class XMLProcessor
    {
        private Dictionary<string, int> ElementOrderList { get; }
        private SteribaseDB.SteribaseContext DBContext { get; }

        public XMLProcessor(Dictionary<string, int> elementOrderList, SteribaseDB.SteribaseContext steribaseContext)
        {
            ElementOrderList = elementOrderList;
            DBContext = steribaseContext;
        }

       public (int erfolgreich, int fehlerhaft) ImportXml(XmlDocument xmlDocument)
        {
            var elements = xmlDocument.LastChild.ChildNodes;
            var elementList = new List<XmlNode>();
            foreach (XmlNode item in elements)
            {
                elementList.Add(item);
            }

           var resultList = elementList.OrderBy(item => ElementOrderList[item.Name]).Select(items => TransformNode(items)).ToList();
            return default;
        }

        private bool TransformNode(XmlNode xmlNode)
        {
            //dynamic instance = System.Activator.CreateInstance();
            var xmlType = Type.GetType($"SteribaseImporter.SteribaseDB.{xmlNode.Name}");
            XmlSerializer serializer = new XmlSerializer(xmlType);
            using (StringReader reader = new StringReader(xmlNode.InnerText))
            {
                var book = Convert.ChangeType( serializer.Deserialize(reader), xmlType);
                DBContext.Add(book);
            }
            return true;
        }

    }
}
