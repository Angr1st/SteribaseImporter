using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Mgmtinfo
    {
        public string VersionNo { get; set; }
        public string ExportId { get; set; }
        public DateTime ExportDate { get; set; }
        public string Theme { get; set; }
        public int ImportStatId { get; set; }
        public int SenderExtApplId { get; set; }
        public int SenderExtSysId { get; set; }
        public int ReceiverExtApplId { get; set; }
        public int ReceiverExtSysId { get; set; }
    }
}
