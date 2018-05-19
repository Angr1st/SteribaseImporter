using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Labwerttyp
    {
        public Labwerttyp()
        {
            Labwerte = new HashSet<Labwerte>();
        }

        public int LabWertTyp { get; set; }
        public string LabWertTypBez { get; set; }

        public ICollection<Labwerte> Labwerte { get; set; }
    }
}
