using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;
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

        public (int erfolgreich, int fehlerhaft, List<(MySqlCommand command, string message, (string tableName, IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) fieldsEntrys)> failedCommand) ImportXml(XmlDocument xmlDocument, string fileName, int id)
        {
            var pdfImportId = ConfigHandler.GetConfigValue(ConfigValues.field);
            var elements = xmlDocument.LastChild.ChildNodes;

            var resultList = elements.ToXmlNodeList().Append(CreatePdfImportNode()).OrderBy(item => ElementOrderList[item.Name]).Select(items => TransformNode(items, id, pdfImportId)).ToList();
            DBContext.Open();
            var result = DBTables.SelectMany(table => table.CreateCommands().Select(command => ExecuteMySQLCommand(command))).Aggregate((old, newValue) => (old.erfolgreich + newValue.erfolgreich, old.fehlerhaft + newValue.fehlerhaft, old.failedCommands.Concat(newValue.failedCommands).ToList()));
            DBContext.Close();
            DBTables.Select(table => table.DeleteAllRows()).ToList();
            return result;

            XmlNode CreatePdfImportNode()
            {
                var rootElement = xmlDocument.CreateElement(ConfigHandler.GetConfigValue(ConfigValues.table));
                var pdfName = xmlDocument.CreateElement(ConfigHandler.GetConfigValue(ConfigValues.pdfName));
                var pdfId = xmlDocument.CreateElement(pdfImportId);
                pdfName.InnerText = fileName;
                pdfId.InnerText = id.ToString();
                rootElement.AppendChild(pdfId);
                rootElement.AppendChild(pdfName);
                return rootElement;
            }
        }

        private (int erfolgreich, int fehlerhaft, List<(MySqlCommand command, string message, (string tableName, IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) fieldsEntrys)> failedCommands) ExecuteMySQLCommand((MySqlCommand command, (string tableName, IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) fieldsEntrys) commandInfo)
        {
            try
            {
                commandInfo.command.Connection = DBContext;
                return (commandInfo.command.ExecuteNonQuery(), 0, new List<(MySqlCommand command, string message, (string tableName, IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) fieldsEntrys)>());
            }
            catch (Exception ex)
            {
                return (0, 1, new List<(MySqlCommand command, string message, (string tableName, IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) fieldsEntrys)>() { (commandInfo.command, ex.Message, commandInfo.fieldsEntrys) });
            }
        }

        private bool TransformNode(XmlNode xmlNode, int id, string pdfName)
        {
            var dbTable = FindDBTable(xmlNode.Name);
            var innerNodeList = xmlNode.ChildNodes.ToXmlNodeList();
            var dbRow = new List<DBFieldEntry>();
            foreach (var item in dbTable.DBFields)
            {
                var innerNode = innerNodeList.Where(node => node.Name == item.Name).FirstOrDefault();
                if (innerNode == null && item.Name == pdfName)
                {
                    dbRow.Add(new DBFieldEntry(item.Name, DBFieldType.@int).SetInt(id));
                }
                else if (innerNode == null)
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
        }

    }
}
