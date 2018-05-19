using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Patdiag
    {
        public string DiagTxt { get; set; }
        public DateTime? DiagDat { get; set; }
        public int PatDiagId { get; set; }
        public int? PatGpid { get; set; }
    }
}
