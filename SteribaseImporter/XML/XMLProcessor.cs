using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using SteribaseImporter.DB;

namespace SteribaseImporter.XML
{
    class XMLProcessor
    {
        private Dictionary<string, int> ElementOrderList { get; }
        private MySql.Data.MySqlClient.MySqlConnection DBContext { get; }

        private List<DBTable> DBTables { get; }

        public XMLProcessor(Dictionary<string, int> elementOrderList, List<DBTable> tables, MySql.Data.MySqlClient.MySqlConnection steribaseContext)
        {
            ElementOrderList = elementOrderList;
            DBTables = tables;
            DBContext = steribaseContext;
        }

        public (int erfolgreich, int fehlerhaft) ImportXml(XmlDocument xmlDocument)
        {
            var elements = xmlDocument.LastChild.ChildNodes;

            var resultList = elements.ToXmlNodeList().OrderBy(item => ElementOrderList[item.Name]).Select(items => TransformNode(items)).ToList();
            
            return resultList.Select(result => result ? (1, 0) : (0, 1)).Aggregate((old, next) => (old.Item1 + next.Item1, old.Item2 + next.Item2));
        }

        private bool TransformNode(XmlNode xmlNode)
        {
            var dbTable = FindDBTable(xmlNode.Name);
            var innerNodeList = xmlNode.ChildNodes.ToXmlNodeList();
            var dbRow = new List<DBFieldEntry>();
            foreach (var item in dbTable.DBFields)
            {
                var innerNode = innerNodeList.Where(node => node.Name == item.Name).FirstOrDefault();
                if (innerNode == null)
                {
                    dbRow.Add(new DBFieldEntry(item.Name));
                }
                else
                {
                    DBFieldEntry entry = new DBFieldEntry(item.Name, item.DBFieldType);
                    switch (item.DBFieldType)
                    {
                        case DBFieldType.varchar:
                            entry.SetString(innerNode.InnerText, item.Length);
                            break;

                        case DBFieldType.@int:
                            entry.SetInt(int.Parse(innerNode.InnerText));
                            break;

                        case DBFieldType.@double:
                            entry.SetDouble(double.Parse(innerNode.InnerText));
                            break;

                        case DBFieldType.DateTime:
                            entry.SetDateTimeOffset(DateTimeOffset.Parse(innerNode.InnerText));
                            break;

                        case DBFieldType.unkown:
                        default:
                            throw new ArgumentException($"The innerNode Value of:{innerNode.InnerText} cannot be parsed!");
                    }
                    dbRow.Add(entry);
                }
            }

            return dbTable.AddRow(new DBRow(dbRow));

            DBTable FindDBTable(string name) => DBTables.Where(table => table.Name == name).First();

            string FirstUpperCaseRestLowerCase(string name)
            {
                var initial = name.Take(1).First().ToString().ToUpper();
                var restOfString = StringBuilderChars(name.ToLower().Skip(1));
                return StringBuilderChars(restOfString.Prepend(initial.ToCharArray().First()));
            }

            string StringBuilderChars(IEnumerable<char> charSequence)
            {
                var sb = new StringBuilder();
                foreach (var c in charSequence)
                {
                    sb.Append(c);
                }
                return sb.ToString();
            }
        }

    }
}
