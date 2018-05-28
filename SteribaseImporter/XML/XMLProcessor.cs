using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace SteribaseImporter.XML
{
    class XMLProcessor
    {
        private Dictionary<string, int> ElementOrderList { get; }
        private MySql.Data.MySqlClient.MySqlConnection DBContext { get; }

        // public XMLProcessor(Dictionary<string, int> elementOrderList, SteribaseDB.SteribaseContext steribaseContext)
        // {
        //     ElementOrderList = elementOrderList;
        //     DBContext = steribaseContext;
        // }

        //public (int erfolgreich, int fehlerhaft) ImportXml(XmlDocument xmlDocument)
        // {
        //     var elements = xmlDocument.LastChild.ChildNodes;
        //     var elementList = new List<XmlNode>();
        //     foreach (XmlNode item in elements)
        //     {
        //         elementList.Add(item);
        //     }

        //    var resultList = elementList.OrderBy(item => ElementOrderList[item.Name]).Select(items => TransformNode(items)).ToList();
        //     return resultList.Select(result => result ? (1, 0) : (0, 1)).Aggregate((old, next) => (old.Item1 + next.Item1, old.Item2 + next.Item2));
        // }

        // private string TransformNode(XmlNode xmlNode)
        // {
        //     //dynamic instance = System.Activator.CreateInstance();
        //     var searchString = $"SteribaseImporter.XML.Xml2CSharp.{xmlNode.Name}";
        //     var xmlType = Type.GetType(searchString);
        //     XmlSerializer serializer = new XmlSerializer(xmlType);
        //     using (StringReader reader = new StringReader(xmlNode.InnerText))
        //     {
        //         var book = Convert.ChangeType( serializer.Deserialize(reader), xmlType);
        //         DBContext.Add(book);
        //     }
        //     return true;

        //     string FirstUpperCaseRestLowerCase(string name)
        //     {
        //         var initial = name.Take(1).First().ToString().ToUpper();
        //         var restOfString = StringBuilderChars(name.ToLower().Skip(1));
        //         return StringBuilderChars(restOfString.Prepend(initial.ToCharArray().First()));
        //     }

        //     string StringBuilderChars(IEnumerable<char> charSequence)
        //     {
        //         var sb = new StringBuilder();
        //         foreach (var c in charSequence)
        //         {
        //             sb.Append(c);
        //         }
        //         return sb.ToString();
        //     }
        // }

    }
}
