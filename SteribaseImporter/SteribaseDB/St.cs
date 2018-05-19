using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class St
    {
        public St()
        {
            Zubartdoku = new HashSet<Zubartdoku>();
            Zubdet = new HashSet<Zubdet>();
        }

        public string StbezInn { get; set; }
        public int Stid { get; set; }

        public ICollection<Zubartdoku> Zubartdoku { get; set; }
        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
