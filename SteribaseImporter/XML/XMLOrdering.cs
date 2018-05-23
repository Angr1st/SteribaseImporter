using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SteribaseImporter.XML
{
    class XMLOrdering
    {
        public IEnumerable<(string nodeName,int orderingNumber)> GetOrderingList(string filePath) => LoadLines(filePath);

        private static List<(string nodeName, int orderingNumber)> LoadLines(string fileName)
        {
            try
            {
                var resultList = new List<(string nodeName, int orderingNumber)>();
                var lines = File.ReadAllLines(fileName);
                for (int i = 0; i < lines.Length; i++)
                {
                   resultList.Add((lines[i].TrimEnd(';'), i));
                }
                return resultList;
            }
            catch (Exception e)
            {
                throw new Exception("Error while loading the XML.", e);
            }
        }
    }
}
