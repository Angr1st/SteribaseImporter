using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Applgeraet
    {
        public Applgeraet()
        {
            Zubdet = new HashSet<Zubdet>();
        }

        public string ApplGbez { get; set; }
        public string ApplGbesch { get; set; }
        public int ApplGid { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
