using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Usr
    {
        public Usr()
        {
            Zubartdoku = new HashSet<Zubartdoku>();
        }

        public int UsrId { get; set; }
        public string UsrShort { get; set; }
        public string UsrName { get; set; }

        public ICollection<Zubartdoku> Zubartdoku { get; set; }
    }
}
