using System;
using SteribaseImporter.XML;
using System.Linq;
using System.Configuration;

using static System.Console;

namespace SteribaseImporter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            var result = DB.DBStructureLoader.LoadDBStructure();
            var dbConn = new MySql.Data.MySqlClient.MySqlConnection(ConfigurationManager.ConnectionStrings["steribaseDB"].ConnectionString);
            var nextID = Query.QueryTask.GetHighestId(dbConn);
            XMLMover mover = new XMLMover();
            XMLOrdering ordering = new XMLOrdering();
            XMLProcessor processor = new XMLProcessor(ordering.GetOrderingList(ConfigHandler.GetConfigValue(ConfigValues.order)), result, dbConn);
            var importResults = mover.LoadAllNewXmls()
                    .Select(doc => { nextID++; return (processor.ImportXml(doc.xmlDoc, mover.GetFileName(doc.filePath), nextID), doc.filePath); })
                    .Select(import => { WriteLine($"Import of {mover.GetFileName(import.filePath)}; Successfull:{import.Item1.erfolgreich}; Failed:{import.Item1.fehlerhaft}"); return import; })
                    .Select(import => (mover.MoveFile(import.filePath), import))
                    .Select(import => mover.CreateErrorLog(import.import.Item1))
                    .ToList();
#if DEBUG
            ReadLine();
#endif
            }
            catch (Exception e)
            {
                Logger.LogException("Programm expierienced a exception.", e);
            }
        }
    }
}
