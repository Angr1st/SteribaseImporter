using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Arttyp
    {
        public Arttyp()
        {
            Art = new HashSet<Art>();
        }

        public int ArtTypId { get; set; }
        public string ArtTypBez { get; set; }

        public ICollection<Art> Art { get; set; }
    }
}
