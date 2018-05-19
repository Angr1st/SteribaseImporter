using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Applzbh
    {
        public Applzbh()
        {
            Zubdet = new HashSet<Zubdet>();
        }

        public int ApplZbhId { get; set; }
        public string ApplZbhBez { get; set; }
        public string ApplZbhTaxBez { get; set; }
        public string Active { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
