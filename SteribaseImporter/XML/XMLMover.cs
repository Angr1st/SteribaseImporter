using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;

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


        public string MoveFile(string filePath)
        {
            var returnValue = Path.Combine(ConfigHandler.GetConfigValue(ConfigValues.processedFolder), GetFileName(filePath));
            File.Move(filePath,returnValue);
            return returnValue;
        }

        public string CreateErrorLog((int erfolgreich, int fehlerhaft, List<(MySqlCommand command, string message)> failedCommand) results)
        {
            throw new NotImplementedException();
        }

        public string GetFileName(string filePath) => filePath.Split(Path.DirectorySeparatorChar).Last();
    }
}
