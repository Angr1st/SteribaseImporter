using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SteribaseImporter.XML
{
    class XMLOrdering
    {
        public Dictionary<string, int> GetOrderingList(string filePath) => LoadLines(filePath);

        private static Dictionary<string, int> LoadLines(string fileName)
        {
            try
            {
                var resultList = new Dictionary<string, int>();
                var lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i++)
                {
                    resultList.Add(lines[i].TrimEnd(';'), i);
                }
                return resultList;
            }
            catch (Exception e)
            {
                throw new Exception("Error while loading the Orderingfile.", e);
            }
        }
    }
}
