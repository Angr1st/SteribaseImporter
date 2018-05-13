using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Kostenstellen
    {
        public Kostenstellen()
        {
            Zub = new HashSet<Zub>();
        }

        public int KostId { get; set; }
        public string KostBez { get; set; }

        public ICollection<Zub> Zub { get; set; }
    }
}
