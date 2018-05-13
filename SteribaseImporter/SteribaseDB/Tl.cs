using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Tl
    {
        public Tl()
        {
            Zubdet = new HashSet<Zubdet>();
        }

        public int Tlid { get; set; }
        public string Tlbez { get; set; }
        public string Tlbesch { get; set; }
        public double? Tldens { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
