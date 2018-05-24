using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

        public List<XmlDocument> LoadAllNewXmls()
        {
            return Directory.GetFiles(NewFolder).Select(file => { var xmlDoc = new XmlDocument(); xmlDoc.Load(file); return xmlDoc; }).ToList();
        }
    }
}
