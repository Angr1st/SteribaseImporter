using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Applform
    {
        public Applform()
        {
            Zubdet = new HashSet<Zubdet>();
        }

        public string ApplFbesch { get; set; }
        public string ApplFbez { get; set; }
        public int ApplFid { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
