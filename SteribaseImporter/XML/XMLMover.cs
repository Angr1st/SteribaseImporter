using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using SteribaseImporter.DB;

namespace SteribaseImporter.XML
{
    class XMLMover
    {
        private string NewFolder { get; }

        public XMLMover()
        {
            NewFolder = ConfigHandler.GetConfigValue(ConfigValues.newFolder);
        }

        public List<(XmlDocument xmlDoc, string filePath)> LoadAllNewXmls()
        {
            return Directory.GetFiles(NewFolder).Select(file => { var xmlDoc = new XmlDocument(); xmlDoc.Load(file); return (xmlDoc, file); }).ToList();
        }


        public static string MoveFile(string filePath)
        {
            var returnValue = Path.Combine(ConfigHandler.GetConfigValue(ConfigValues.processedFolder), GetFileName(filePath));
            File.Move(filePath, returnValue);
            return returnValue;
        }

        public static string CreateErrorLog((int erfolgreich, int fehlerhaft, List<(MySqlCommand command, string message, (string tableName, IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) fieldsEntrys)> failedCommand) results)
        {
            if (results.fehlerhaft == 0)
            {
                return string.Empty;
            }
            var now = DateTime.Now;
            var failedFilePath = Path.Combine(ConfigHandler.GetConfigValue(ConfigValues.failedFolder), $"failed_{now.Year}-{now.DayOfYear}-{now.Hour}.{now.Minute}.{now.Second}.csv");
            File.WriteAllLines(failedFilePath, results.failedCommand.Select(command => $"Error:{command.message},Failed Command:{command.command.CommandText},Update Command:{CreateUpdateCommand(command.fieldsEntrys)}"));
            return failedFilePath;
        }

        private static string CreateUpdateCommand((string tableName, IEnumerable<(string fieldName, DBFieldKeyType fieldType)> fields, IEnumerable<(string name, string value)> entrys) fieldEntrys)
        {
            var pks = fieldEntrys.fields.Where(field => field.fieldType == DBFieldKeyType.ClusteredPrimaryKey || field.fieldType == DBFieldKeyType.PrimaryKey).SelectMany(field => fieldEntrys.entrys.Where(entry => entry.name == field.fieldName));
            return $"Update {fieldEntrys.tableName} SET {String.Join(",", fieldEntrys.entrys.Except(pks).Select(entry => $"{entry.name}={entry.value}"))} WHERE {String.Join(" and ", pks.Select(pk => $"{pk.name}={pk.value}"))};";
        }

        public static string GetFileName(string filePath) => filePath.Split(Path.DirectorySeparatorChar).Last();
    }
}
