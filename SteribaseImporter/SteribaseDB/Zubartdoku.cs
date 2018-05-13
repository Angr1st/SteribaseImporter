using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zubartdoku
    {
        public int ZubArtDokuId { get; set; }
        public int? ZubId { get; set; }
        public int? MixNr { get; set; }
        public string ZubMixId { get; set; }
        public int? ZubKatId { get; set; }
        public int? ZubDetId { get; set; }
        public int? ArtFkt { get; set; }
        public int? ArtFktTlid { get; set; }
        public int? ArtLagId { get; set; }
        public int? ArtId { get; set; }
        public string ArtBez { get; set; }
        public int? ArtPzn { get; set; }
        public string ArtChB { get; set; }
        public string EndlessChB { get; set; }
        public int? DosUnit { get; set; }
        public int? VolUnit { get; set; }
        public int? Stid { get; set; }
        public int? ArtTmanz { get; set; }
        public string AusAnbr { get; set; }
        public string Anbruch { get; set; }
        public DateTime? HaltbDat { get; set; }
        public string Verbraucht { get; set; }
        public int? AufbTypId { get; set; }
        public int? AufbTlid { get; set; }
        public int? AufbSubArtId { get; set; }
        public string IsApplB { get; set; }
        public string VolCountsForSum { get; set; }
        public string RekExAbtl { get; set; }
        public DateTime? DokuDat { get; set; }
        public int? UsrId { get; set; }
        public double? PosAnz { get; set; }
        public double? PosAnzLag { get; set; }
        public double? PosAnzRech { get; set; }
        public double? Dos { get; set; }
        public double? Vol { get; set; }
        public double? ArtTmdos { get; set; }
        public double? ArtTmvolDecl { get; set; }
        public double? ArtTmvolAdForRek { get; set; }
        public double? ArtTmvolFill { get; set; }

        public Art Art { get; set; }
        public Artlager ArtLag { get; set; }
        public Artaufbtyp AufbTyp { get; set; }
        public St St { get; set; }
        public Usr Usr { get; set; }
        public Zub Zub { get; set; }
        public Zubdet ZubDet { get; set; }
        public Zubkat ZubKat { get; set; }
    }
}
