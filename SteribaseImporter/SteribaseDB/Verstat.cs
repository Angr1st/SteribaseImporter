using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Verstat
    {
        public Verstat()
        {
            Gppat = new HashSet<Gppat>();
        }

        public string VersStatBez { get; set; }
        public int VerStatId { get; set; }

        public ICollection<Gppat> Gppat { get; set; }
    }
}
