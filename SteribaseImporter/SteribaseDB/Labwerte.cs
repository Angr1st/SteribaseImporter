using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Labwerte
    {
        public Labwerte()
        {
            Labdet = new HashSet<Labdet>();
        }

        public int LabWertId { get; set; }
        public string LabWertBez { get; set; }
        public int? LabWertUnit { get; set; }
        public int? LabWertMin { get; set; }
        public int? LabWertMax { get; set; }
        public int? LabWertTyp { get; set; }
        public string SysDs { get; set; }

        public Labwerttyp LabWertTypNavigation { get; set; }
        public ICollection<Labdet> Labdet { get; set; }
    }
}
