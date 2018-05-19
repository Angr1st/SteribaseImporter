using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zubdetimprel
    {
        public string MoreInfo { get; set; }
        public string ExpFileName { get; set; }
        public DateTime? InsDat { get; set; }
        public int RelId { get; set; }
        public int? ExtApplId { get; set; }
        public int? ExtSysId { get; set; }
        public int? ExtZubDetId { get; set; }
        public int? ZubDetId { get; set; }
        public int? Status { get; set; }

        public Zubdet ZubDet { get; set; }
    }
}
