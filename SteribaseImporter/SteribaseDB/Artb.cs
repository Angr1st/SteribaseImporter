﻿using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Artb
    {
        public Artb()
        {
            Art = new HashSet<Art>();
            Zubdetartb = new HashSet<Zubdetartb>();
        }

        public string ArtBbez { get; set; }
        public int ArtBid { get; set; }

        public ICollection<Art> Art { get; set; }
        public ICollection<Zubdetartb> Zubdetartb { get; set; }
    }
}
