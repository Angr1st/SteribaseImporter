using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Gp
    {
        public Gp()
        {
            Gpgpgr = new HashSet<Gpgpgr>();
            Gpkrka = new HashSet<Gpkrka>();
            Gppat = new HashSet<Gppat>();
        }

        public string Gpmessage { get; set; }
        public string Gpname { get; set; }
        public string GpfaName { get; set; }
        public string Strasse { get; set; }
        public DateTime? GebDat { get; set; }
        public DateTime? SepamandatsRefLastUseDat { get; set; }
        public string BankBez { get; set; }
        public string Iban { get; set; }
        public string Gpvorname { get; set; }
        public string Bundesland { get; set; }
        public string Ort { get; set; }
        public string OrtPostf { get; set; }
        public string Bic { get; set; }
        public string Gptitel { get; set; }
        public string SepamandatsRef { get; set; }
        public string Gpkurz { get; set; }
        public string Archiv { get; set; }
        public string Gpanrede { get; set; }
        public string Sex { get; set; }
        public string Nation { get; set; }
        public int Gpid { get; set; }
        public int? Plz { get; set; }
        public int? KeyAdrAbda { get; set; }
        public int? KvbzkId { get; set; }
        public int? Postf { get; set; }
        public int? Plzpostf { get; set; }
        public int? KvarztNr { get; set; }
        public int? KvbetrStNr { get; set; }
        public int? Blz { get; set; }
        public int? KtoNr { get; set; }

        public ICollection<Gpgpgr> Gpgpgr { get; set; }
        public ICollection<Gpkrka> Gpkrka { get; set; }
        public ICollection<Gppat> Gppat { get; set; }
    }
}
