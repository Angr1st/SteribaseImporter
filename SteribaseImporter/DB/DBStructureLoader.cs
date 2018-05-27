using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SteribaseImporter.DB
{
    class DBStructureLoader
    {
        public List<DBTable> LoadDBStructure()
        {
            File.ReadAllLines(ConfigHandler.GetConfigValue(ConfigValues.dbstructure)).Select(Line => Line.Split(';').Select(subLine => subLine.Split(',')))
        }
    }
}
