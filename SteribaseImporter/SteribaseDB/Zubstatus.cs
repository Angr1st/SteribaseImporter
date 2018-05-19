using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zubstatus
    {
        public Zubstatus()
        {
            Zubdet = new HashSet<Zubdet>();
        }

        public string ZubStatBez { get; set; }
        public int ZubStatId { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
