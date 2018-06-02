using System;
using SteribaseImporter.XML;
using System.Linq;
using System.Configuration;

using static System.Console;
using System.IO;

namespace SteribaseImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            DB.DBStructureLoader dBStructureLoader = new DB.DBStructureLoader();
            var result = dBStructureLoader.LoadDBStructure();
            XMLMover mover = new XMLMover();
            XMLOrdering ordering = new XMLOrdering();
            XMLProcessor processor = new XMLProcessor(ordering.GetOrderingList(ConfigHandler.GetConfigValue(ConfigValues.order)), result, new MySql.Data.MySqlClient.MySqlConnection(ConfigurationManager.ConnectionStrings["steribaseDB"].ConnectionString));
            var importResults = mover.LoadAllNewXmls().Select(doc => (processor.ImportXml(doc.xmlDoc), doc.filePath)).Select(import => { WriteLine($"Import of {mover.GetFileName(import.filePath)}; Successfull:{import.Item1.erfolgreich}; Failed:{import.Item1.fehlerhaft}"); return import; }).Select(import => mover.MoveFile(import.filePath)).ToList();
            ReadLine();
        }
    }
}
