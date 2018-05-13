using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Artb
    {
        public Artb()
        {
            Art = new HashSet<Art>();
        }

        public int ArtBid { get; set; }
        public string ArtBbez { get; set; }

        public ICollection<Art> Art { get; set; }
    }
}
