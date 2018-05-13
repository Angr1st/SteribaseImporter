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

        public int ApplFid { get; set; }
        public string ApplFbez { get; set; }
        public string ApplFbesch { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
