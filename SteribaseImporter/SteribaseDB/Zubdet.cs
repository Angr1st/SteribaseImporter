using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zubdet
    {
        public Zubdet()
        {
            Zubartdoku = new HashSet<Zubartdoku>();
            Zubdetartb = new HashSet<Zubdetartb>();
            Zubdetimprel = new HashSet<Zubdetimprel>();
        }

        public DateTime? ApplDat { get; set; }
        public DateTime? HerstDat { get; set; }
        public string ZubMixId { get; set; }
        public string AutIdem { get; set; }
        public int ZubDetId { get; set; }
        public int? ZubId { get; set; }
        public int? ZubKatId { get; set; }
        public int? PosAnz { get; set; }
        public int? MixNr { get; set; }
        public int? ZubStatId { get; set; }
        public int? TagNr { get; set; }
        public int? Stid { get; set; }
        public int? StherstPref { get; set; }
        public int? DosTypId { get; set; }
        public int? DosUnit { get; set; }
        public double? DosAnpDet { get; set; }
        public int? Tlid { get; set; }
        public int? ApplWid { get; set; }
        public int? ApplFid { get; set; }
        public int? ApplGid { get; set; }
        public int? ApplDunit { get; set; }
        public double? VolGesAbw { get; set; }
        public int? VolUnit { get; set; }
        public int? HaltbBed1 { get; set; }
        public int? HaltbBed2 { get; set; }
        public int? LightProt { get; set; }
        public int? ApplBdivCnt { get; set; }
        public int? ApplD { get; set; }
        public int? ApplB { get; set; }
        public double? DosRel { get; set; }
        public double? DosAbs { get; set; }
        public double? VolGesAnf { get; set; }
        public int? ApplZbhId { get; set; }

        public Applform ApplF { get; set; }
        public Applgeraet ApplG { get; set; }
        public Applweg ApplW { get; set; }
        public Applzbh ApplZbh { get; set; }
        public Dostyp DosTyp { get; set; }
        public St St { get; set; }
        public Tl Tl { get; set; }
        public Zub Zub { get; set; }
        public Zubkat ZubKat { get; set; }
        public Zubstatus ZubStat { get; set; }
        public ICollection<Zubartdoku> Zubartdoku { get; set; }
        public ICollection<Zubdetartb> Zubdetartb { get; set; }
        public ICollection<Zubdetimprel> Zubdetimprel { get; set; }
    }
}
