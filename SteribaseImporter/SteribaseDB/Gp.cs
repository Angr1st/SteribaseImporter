using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Gp
    {
        public int Gpid { get; set; }
        public string Gpname { get; set; }
        public string GpfaName { get; set; }
        public string Gpkurz { get; set; }
        public string Gpanrede { get; set; }
        public string Sex { get; set; }
        public string Strasse { get; set; }
        public int? Plz { get; set; }
        public string Ort { get; set; }
        public string Nation { get; set; }
        public int? Postf { get; set; }
        public int? Plzpostf { get; set; }
        public string OrtPostf { get; set; }
        public string Archiv { get; set; }
        public int? KeyAdrAbda { get; set; }
        public int? KvbzkId { get; set; }
        public string Gpvorname { get; set; }
        public string Gptitel { get; set; }
        public string Bundesland { get; set; }
        public int? KvarztNr { get; set; }
        public int? KvbetrStNr { get; set; }
        public DateTime? GebDat { get; set; }
        public string Gpmessage { get; set; }
    }
}
