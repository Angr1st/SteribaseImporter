using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Gpgpgr
    {
        public int? RecId { get; set; }
        public int Gpid { get; set; }
        public int GpgrId { get; set; }

        public Gp Gp { get; set; }
        public Gpgr Gpgr { get; set; }
    }
}
