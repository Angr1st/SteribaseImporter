using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Applweg
    {
        public Applweg()
        {
            Zubdet = new HashSet<Zubdet>();
        }

        public string ApplWbesch { get; set; }
        public string ApplWbez { get; set; }
        public int ApplWid { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
