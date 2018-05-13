using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Artaufbtyp
    {
        public Artaufbtyp()
        {
            Zubartdoku = new HashSet<Zubartdoku>();
        }

        public int AufbTypId { get; set; }
        public string AufbTypBez { get; set; }

        public ICollection<Zubartdoku> Zubartdoku { get; set; }
    }
}
