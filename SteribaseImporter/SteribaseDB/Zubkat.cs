using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zubkat
    {
        public Zubkat()
        {
            Zubartdoku = new HashSet<Zubartdoku>();
            Zubdet = new HashSet<Zubdet>();
        }

        public string ZubKatBesch { get; set; }
        public string ZubKatBez { get; set; }
        public int ZubKatId { get; set; }

        public ICollection<Zubartdoku> Zubartdoku { get; set; }
        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
