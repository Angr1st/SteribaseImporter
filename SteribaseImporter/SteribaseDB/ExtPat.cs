using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class ExtPat
    {
        public int? RecId { get; set; }
        public int? ExtApplId { get; set; }
        public int? ExtSysId { get; set; }
        public int ExtPatId { get; set; }
        public string ExtPatName { get; set; }
        public string ExtPatVorname { get; set; }
        public DateTime? ExtPatGebDat { get; set; }
        public string ExtPatSex { get; set; }
        public int? SbpatGpid { get; set; }
        public DateTime? InsDate { get; set; }
    }
}
