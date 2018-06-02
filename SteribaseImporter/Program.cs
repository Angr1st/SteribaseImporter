using System;
using SteribaseImporter.XML;
using System.Linq;
using System.Configuration;

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
            XMLProcessor processor = new XMLProcessor(ordering.GetOrderingList(ConfigHandler.GetConfigValue(ConfigValues.order)), result,new MySql.Data.MySqlClient.MySqlConnection(ConfigurationManager.ConnectionStrings["steribaseDB"].ConnectionString));
            var importResults = mover.LoadAllNewXmls().Select(doc => processor.ImportXml(doc)).ToList();
            Console.WriteLine("Hello World!");
        }
    }
}
