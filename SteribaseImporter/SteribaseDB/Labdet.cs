using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Labdet
    {
        public string LabDetBem { get; set; }
        public string Wert { get; set; }
        public int LabDetId { get; set; }
        public int? LabId { get; set; }
        public int? LabWertId { get; set; }

        public Lab Lab { get; set; }
        public Labwerte LabWert { get; set; }
    }
}
