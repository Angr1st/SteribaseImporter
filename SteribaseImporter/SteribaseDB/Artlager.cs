using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Artlager
    {
        public Artlager()
        {
            Zubartdoku = new HashSet<Zubartdoku>();
        }

        public int ArtLagId { get; set; }
        public int? ArtId { get; set; }
        public string ArtChB { get; set; }
        public int? ArtTmanz { get; set; }
        public int? ArtSt { get; set; }
        public int? ArtTmdos { get; set; }
        public int? ArtDosUnit { get; set; }
        public int? ArtTmvolDecl { get; set; }
        public int? ArtVolUnit { get; set; }
        public int? ArtAnbiet { get; set; }
        public int? ArtHerst { get; set; }
        public int? AufbTlid { get; set; }
        public int? ArtTmvolFill { get; set; }

        public Art Art { get; set; }
        public ICollection<Zubartdoku> Zubartdoku { get; set; }
    }
}
