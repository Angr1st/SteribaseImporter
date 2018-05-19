using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zubdetartbmixtimedfn
    {
        public Zubdetartbmixtimedfn()
        {
            Zubdetartb = new HashSet<Zubdetartb>();
        }

        public int MixTimeId { get; set; }
        public string MixTimeBez { get; set; }

        public ICollection<Zubdetartb> Zubdetartb { get; set; }
    }
}
