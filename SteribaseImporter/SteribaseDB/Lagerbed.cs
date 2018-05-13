using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Lagerbed
    {
        public Lagerbed()
        {
            Lagerort = new HashSet<Lagerort>();
        }

        public int LagBedId { get; set; }
        public string LagBed { get; set; }

        public ICollection<Lagerort> Lagerort { get; set; }
    }
}
