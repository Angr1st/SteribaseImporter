using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Art
    {
        public Art()
        {
            Artlager = new HashSet<Artlager>();
            Zubartdoku = new HashSet<Zubartdoku>();
        }

        public int ArtId { get; set; }
        public int? ArtIdusr { get; set; }
        public int? ArtPzn { get; set; }
        public string ArtBez { get; set; }
        public string ArtVe { get; set; }
        public int? ArtAnbiet { get; set; }
        public int? ArtHerst { get; set; }
        public int? ArtBid { get; set; }
        public int? ArtStdLief { get; set; }
        public string ArtLag { get; set; }
        public int? ArtStdLag { get; set; }
        public int? ArtLagBed { get; set; }
        public int? ArtStdLagAnbr { get; set; }
        public int? ArtLagBedAnbr { get; set; }
        public int? ArtAnbrHaltbD { get; set; }
        public int? ArtAnbrHaltbH { get; set; }
        public int? ArtAnbrHaltbM { get; set; }
        public string ArtAnbrHaltbIgnoreForZubHaltb { get; set; }
        public int? ArtStdLagWe { get; set; }
        public int? ArtBestMinVe { get; set; }
        public int? ArtStdsupplDays { get; set; }
        public int? ArtMinOrderVe { get; set; }
        public string ArtTm { get; set; }
        public int? ArtTmanz { get; set; }
        public int? ArtSt { get; set; }
        public int? ArtTmdos { get; set; }
        public int? ArtTmdosUnit { get; set; }
        public int? ArtTmvolFill { get; set; }
        public int? ArtTmvolUnit { get; set; }
        public int? ArtTmvolDecl { get; set; }
        public int? ArtTmvolMax { get; set; }
        public string ArtAnbrIsPos { get; set; }
        public double? ArtAnbrTmminPart { get; set; }
        public int? ArtTypId { get; set; }
        public string ArtIsSubArt { get; set; }
        public int? ArtMasterArtId { get; set; }
        public int? ArtAufbTypId { get; set; }
        public string ArtAv { get; set; }
        public int? ArtHaltbMon { get; set; }
        public DateTime? ArtInsDat { get; set; }
        public string ArtKztmp { get; set; }
        public string ArtDataInpOk { get; set; }
        public int? ArtIsTltyp { get; set; }
        public string ArtIsApplB { get; set; }
        public string NoSyncToAbda { get; set; }
        public int? ArtTaxTypIdartAbv { get; set; }
        public int? ArtVerwTypId { get; set; }
        public int? ArtTmdosTax { get; set; }
        public int? ArtImportReimportAbda { get; set; }
        public DateTime? ArtVertriebAbDat { get; set; }
        public string ArtFreeForPrd { get; set; }
        public string ArtMwStTyp { get; set; }

        public Artb ArtB { get; set; }
        public Arttyp ArtTyp { get; set; }
        public ICollection<Artlager> Artlager { get; set; }
        public ICollection<Zubartdoku> Zubartdoku { get; set; }
    }
}
