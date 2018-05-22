using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SteribaseImporter.XML
{
    class XMLOrdering
    {
        public IEnumerable<string> GetOrderingList(string filePath) => LoadLines(filePath);

        private static IEnumerable<string> LoadLines(string fileName)
        {
            try
            {
                return File.ReadAllLines(fileName).Select(line => line.TrimEnd(';'));
            }
            catch (Exception e)
            {
                throw new Exception("Error while loading the XML.", e);
            }
        }
    }
}
