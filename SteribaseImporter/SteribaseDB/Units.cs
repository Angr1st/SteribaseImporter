using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Units
    {
        public Units()
        {
            Zubdetartb = new HashSet<Zubdetartb>();
        }

        public string UnitText { get; set; }
        public string UnitKz { get; set; }
        public int UnitId { get; set; }

        public ICollection<Zubdetartb> Zubdetartb { get; set; }
    }
}
