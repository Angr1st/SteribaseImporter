using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Dostyp
    {
        public Dostyp()
        {
            Zubdet = new HashSet<Zubdet>();
        }

        public string DosTypBesch { get; set; }
        public string DosTypRel { get; set; }
        public string SysDs { get; set; }
        public string DosTypBez { get; set; }
        public string AbsRel { get; set; }
        public int DosTypId { get; set; }

        public ICollection<Zubdet> Zubdet { get; set; }
    }
}
