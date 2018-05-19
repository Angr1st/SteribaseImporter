using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Gpgr
    {
        public Gpgr()
        {
            Gpgpgr = new HashSet<Gpgpgr>();
        }

        public string Gpgruppe { get; set; }
        public int GpgrId { get; set; }

        public ICollection<Gpgpgr> Gpgpgr { get; set; }
    }
}
