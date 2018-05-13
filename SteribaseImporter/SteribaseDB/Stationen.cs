using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Stationen
    {
        public Stationen()
        {
            Zub = new HashSet<Zub>();
        }

        public int StatId { get; set; }
        public string StatBez { get; set; }

        public ICollection<Zub> Zub { get; set; }
    }
}
