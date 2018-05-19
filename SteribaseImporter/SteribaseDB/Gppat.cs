using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Gppat
    {
        public DateTime? ZuzFreiAb { get; set; }
        public DateTime? ZuzFreiBis { get; set; }
        public DateTime? VkgueltBis { get; set; }
        public string VersNr { get; set; }
        public int Gpid { get; set; }
        public int? KrKaId { get; set; }
        public int VerStatId { get; set; }
        public int? VersMitglStatus { get; set; }

        public Gp Gp { get; set; }
        public Verstat VerStat { get; set; }
    }
}
