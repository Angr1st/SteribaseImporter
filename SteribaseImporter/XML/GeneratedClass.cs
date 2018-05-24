using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SteribaseImporter.XML
{
    class Xml2CSharp
    {
        /* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
        [XmlRoot(ElementName = "ZubDet")]
        public class ZubDet
        {
            [XmlElement(ElementName = "ZubDetID")]
            public string ZubDetID { get; set; }
            [XmlElement(ElementName = "ZubID")]
            public string ZubID { get; set; }
            [XmlElement(ElementName = "ZubKatID")]
            public string ZubKatID { get; set; }
            [XmlElement(ElementName = "PosAnz")]
            public string PosAnz { get; set; }
            [XmlElement(ElementName = "MixNr")]
            public string MixNr { get; set; }
            [XmlElement(ElementName = "ZubMixID")]
            public string ZubMixID { get; set; }
            [XmlElement(ElementName = "ZubStatID")]
            public string ZubStatID { get; set; }
            [XmlElement(ElementName = "TagNr")]
            public string TagNr { get; set; }
            [XmlElement(ElementName = "STID")]
            public string STID { get; set; }
            [XmlElement(ElementName = "STHerstPref")]
            public string STHerstPref { get; set; }
            [XmlElement(ElementName = "DosTypID")]
            public string DosTypID { get; set; }
            [XmlElement(ElementName = "DosRel")]
            public string DosRel { get; set; }
            [XmlElement(ElementName = "DosAbs")]
            public string DosAbs { get; set; }
            [XmlElement(ElementName = "DosUnit")]
            public string DosUnit { get; set; }
            [XmlElement(ElementName = "DosAnpDet")]
            public string DosAnpDet { get; set; }
            [XmlElement(ElementName = "TLID")]
            public string TLID { get; set; }
            [XmlElement(ElementName = "ApplWID")]
            public string ApplWID { get; set; }
            [XmlElement(ElementName = "ApplFID")]
            public string ApplFID { get; set; }
            [XmlElement(ElementName = "ApplGID")]
            public string ApplGID { get; set; }
            [XmlElement(ElementName = "ApplDUnit")]
            public string ApplDUnit { get; set; }
            [XmlElement(ElementName = "VolGesAbw")]
            public string VolGesAbw { get; set; }
            [XmlElement(ElementName = "VolGesAnf")]
            public string VolGesAnf { get; set; }
            [XmlElement(ElementName = "VolUnit")]
            public string VolUnit { get; set; }
            [XmlElement(ElementName = "ApplDat")]
            public string ApplDat { get; set; }
            [XmlElement(ElementName = "HerstDat")]
            public string HerstDat { get; set; }
            [XmlElement(ElementName = "HaltbBed1")]
            public string HaltbBed1 { get; set; }
            [XmlElement(ElementName = "HaltbBed2")]
            public string HaltbBed2 { get; set; }
            [XmlElement(ElementName = "LightProt")]
            public string LightProt { get; set; }
            [XmlElement(ElementName = "ApplBDivCnt")]
            public string ApplBDivCnt { get; set; }
            [XmlElement(ElementName = "AutIdem")]
            public string AutIdem { get; set; }
            [XmlElement(ElementName = "ApplD")]
            public string ApplD { get; set; }
            [XmlElement(ElementName = "ApplB")]
            public string ApplB { get; set; }
            [XmlElement(ElementName = "ApplZbhID")]
            public string ApplZbhID { get; set; }
        }

        [XmlRoot(ElementName = "ZubStatus")]
        public class ZubStatus
        {
            [XmlElement(ElementName = "ZubStatID")]
            public string ZubStatID { get; set; }
            [XmlElement(ElementName = "ZubStatBez")]
            public string ZubStatBez { get; set; }
        }

        [XmlRoot(ElementName = "ZubKat")]
        public class ZubKat
        {
            [XmlElement(ElementName = "ZubKatID")]
            public string ZubKatID { get; set; }
            [XmlElement(ElementName = "ZubKatBez")]
            public string ZubKatBez { get; set; }
            [XmlElement(ElementName = "ZubKatBesch")]
            public string ZubKatBesch { get; set; }
        }

        [XmlRoot(ElementName = "Zub")]
        public class Zub
        {
            [XmlElement(ElementName = "ZubID")]
            public string ZubID { get; set; }
            [XmlElement(ElementName = "AnfordDat")]
            public string AnfordDat { get; set; }
            [XmlElement(ElementName = "Patient")]
            public string Patient { get; set; }
            [XmlElement(ElementName = "Verordner")]
            public string Verordner { get; set; }
            [XmlElement(ElementName = "StatID")]
            public string StatID { get; set; }
            [XmlElement(ElementName = "AuftrGeb")]
            public string AuftrGeb { get; set; }
            [XmlElement(ElementName = "LohnAuftrGeb")]
            public string LohnAuftrGeb { get; set; }
            [XmlElement(ElementName = "LohnHerst")]
            public string LohnHerst { get; set; }
            [XmlElement(ElementName = "KostID")]
            public string KostID { get; set; }
            [XmlElement(ElementName = "PatSex")]
            public string PatSex { get; set; }
            [XmlElement(ElementName = "PatGebDat")]
            public string PatGebDat { get; set; }
            [XmlElement(ElementName = "PatGr")]
            public string PatGr { get; set; }
            [XmlElement(ElementName = "PatGew")]
            public string PatGew { get; set; }
            [XmlElement(ElementName = "PatGewReal")]
            public string PatGewReal { get; set; }
            [XmlElement(ElementName = "PatGewIdeal")]
            public string PatGewIdeal { get; set; }
            [XmlElement(ElementName = "PatKOF")]
            public string PatKOF { get; set; }
            [XmlElement(ElementName = "ZyklNr")]
            public string ZyklNr { get; set; }
            [XmlElement(ElementName = "DiagSTDID")]
            public string DiagSTDID { get; set; }
            [XmlElement(ElementName = "PDID")]
            public string PDID { get; set; }
            [XmlElement(ElementName = "PKID")]
            public string PKID { get; set; }
            [XmlElement(ElementName = "PatVerStatID")]
            public string PatVerStatID { get; set; }
            [XmlElement(ElementName = "PatDispID")]
            public string PatDispID { get; set; }
            [XmlElement(ElementName = "AuftrVerm")]
            public string AuftrVerm { get; set; }
            [XmlElement(ElementName = "LabID")]
            public string LabID { get; set; }
        }

        [XmlRoot(ElementName = "Units")]
        public class Units
        {
            [XmlElement(ElementName = "UnitID")]
            public string UnitID { get; set; }
            [XmlElement(ElementName = "UnitKZ")]
            public string UnitKZ { get; set; }
            [XmlElement(ElementName = "UnitText")]
            public string UnitText { get; set; }
        }

        [XmlRoot(ElementName = "TL")]
        public class TL
        {
            [XmlElement(ElementName = "TLID")]
            public string TLID { get; set; }
            [XmlElement(ElementName = "TLBez")]
            public string TLBez { get; set; }
            [XmlElement(ElementName = "TLBesch")]
            public string TLBesch { get; set; }
            [XmlElement(ElementName = "TLDens")]
            public string TLDens { get; set; }
        }

        [XmlRoot(ElementName = "ST")]
        public class ST
        {
            [XmlElement(ElementName = "STID")]
            public string STID { get; set; }
            [XmlElement(ElementName = "STBezINN")]
            public string STBezINN { get; set; }
        }

        [XmlRoot(ElementName = "LightProtDfn")]
        public class LightProtDfn
        {
            [XmlElement(ElementName = "LightProtID")]
            public string LightProtID { get; set; }
            [XmlElement(ElementName = "LightProtName")]
            public string LightProtName { get; set; }
        }

        [XmlRoot(ElementName = "LagerBed")]
        public class LagerBed
        {
            [XmlElement(ElementName = "LagBedID")]
            public string LagBedID { get; set; }
            [XmlElement(ElementName = "LagBed")]
            public string LagBed { get; set; }
        }

        [XmlRoot(ElementName = "GP")]
        public class GP
        {
            [XmlElement(ElementName = "GPID")]
            public string GPID { get; set; }
            [XmlElement(ElementName = "GPName")]
            public string GPName { get; set; }
            [XmlElement(ElementName = "GPFaName")]
            public string GPFaName { get; set; }
            [XmlElement(ElementName = "GPKurz")]
            public string GPKurz { get; set; }
            [XmlElement(ElementName = "GPAnrede")]
            public string GPAnrede { get; set; }
            [XmlElement(ElementName = "Sex")]
            public string Sex { get; set; }
            [XmlElement(ElementName = "Strasse")]
            public string Strasse { get; set; }
            [XmlElement(ElementName = "PLZ")]
            public string PLZ { get; set; }
            [XmlElement(ElementName = "Ort")]
            public string Ort { get; set; }
            [XmlElement(ElementName = "Nation")]
            public string Nation { get; set; }
            [XmlElement(ElementName = "OrtPostf")]
            public string OrtPostf { get; set; }
            [XmlElement(ElementName = "Archiv")]
            public string Archiv { get; set; }
            [XmlElement(ElementName = "Key_ADR_ABDA")]
            public string Key_ADR_ABDA { get; set; }
            [XmlElement(ElementName = "KVBzkID")]
            public string KVBzkID { get; set; }
            [XmlElement(ElementName = "Postf")]
            public string Postf { get; set; }
            [XmlElement(ElementName = "PLZPostf")]
            public string PLZPostf { get; set; }
            [XmlElement(ElementName = "GPMessage")]
            public string GPMessage { get; set; }
            [XmlElement(ElementName = "GPVorname")]
            public string GPVorname { get; set; }
            [XmlElement(ElementName = "GPTitel")]
            public string GPTitel { get; set; }
            [XmlElement(ElementName = "Bundesland")]
            public string Bundesland { get; set; }
            [XmlElement(ElementName = "KVArztNr")]
            public string KVArztNr { get; set; }
            [XmlElement(ElementName = "KVBetrStNr")]
            public string KVBetrStNr { get; set; }
            [XmlElement(ElementName = "GebDat")]
            public string GebDat { get; set; }
            [XmlElement(ElementName = "BankBez")]
            public string BankBez { get; set; }
            [XmlElement(ElementName = "BLZ")]
            public string BLZ { get; set; }
            [XmlElement(ElementName = "KtoNr")]
            public string KtoNr { get; set; }
            [XmlElement(ElementName = "IBAN")]
            public string IBAN { get; set; }
            [XmlElement(ElementName = "BIC")]
            public string BIC { get; set; }
            [XmlElement(ElementName = "SEPAMandatsRef")]
            public string SEPAMandatsRef { get; set; }
            [XmlElement(ElementName = "SEPAMandatsRefLastUseDat")]
            public string SEPAMandatsRefLastUseDat { get; set; }
        }

        [XmlRoot(ElementName = "DosTyp")]
        public class DosTyp
        {
            [XmlElement(ElementName = "DosTypID")]
            public string DosTypID { get; set; }
            [XmlElement(ElementName = "DosTypBez")]
            public string DosTypBez { get; set; }
            [XmlElement(ElementName = "DosTypRel")]
            public string DosTypRel { get; set; }
            [XmlElement(ElementName = "DosTypBesch")]
            public string DosTypBesch { get; set; }
            [XmlElement(ElementName = "SysDS")]
            public string SysDS { get; set; }
            [XmlElement(ElementName = "AbsRel")]
            public string AbsRel { get; set; }
        }

        [XmlRoot(ElementName = "ArtB")]
        public class ArtB
        {
            [XmlElement(ElementName = "ArtBID")]
            public string ArtBID { get; set; }
            [XmlElement(ElementName = "ArtBBez")]
            public string ArtBBez { get; set; }
        }

        [XmlRoot(ElementName = "ApplZbh")]
        public class ApplZbh
        {
            [XmlElement(ElementName = "ApplZbhID")]
            public string ApplZbhID { get; set; }
            [XmlElement(ElementName = "ApplZbhBez")]
            public string ApplZbhBez { get; set; }
            [XmlElement(ElementName = "ApplZbhTaxBez")]
            public string ApplZbhTaxBez { get; set; }
            [XmlElement(ElementName = "Active")]
            public string Active { get; set; }
        }

        [XmlRoot(ElementName = "ApplWeg")]
        public class ApplWeg
        {
            [XmlElement(ElementName = "ApplWID")]
            public string ApplWID { get; set; }
            [XmlElement(ElementName = "ApplWBez")]
            public string ApplWBez { get; set; }
            [XmlElement(ElementName = "ApplWBesch")]
            public string ApplWBesch { get; set; }
        }

        [XmlRoot(ElementName = "ApplGeraet")]
        public class ApplGeraet
        {
            [XmlElement(ElementName = "ApplGID")]
            public string ApplGID { get; set; }
            [XmlElement(ElementName = "ApplGBez")]
            public string ApplGBez { get; set; }
            [XmlElement(ElementName = "ApplGBesch")]
            public string ApplGBesch { get; set; }
        }

        [XmlRoot(ElementName = "ApplForm")]
        public class ApplForm
        {
            [XmlElement(ElementName = "ApplFID")]
            public string ApplFID { get; set; }
            [XmlElement(ElementName = "ApplFBez")]
            public string ApplFBez { get; set; }
            [XmlElement(ElementName = "ApplFBesch")]
            public string ApplFBesch { get; set; }
        }

        [XmlRoot(ElementName = "ZubDetArtB")]
        public class ZubDetArtB
        {
            [XmlElement(ElementName = "ZubDetArtBID")]
            public string ZubDetArtBID { get; set; }
            [XmlElement(ElementName = "ZubID")]
            public string ZubID { get; set; }
            [XmlElement(ElementName = "ZubDetID")]
            public string ZubDetID { get; set; }
            [XmlElement(ElementName = "ArtBID")]
            public string ArtBID { get; set; }
            [XmlElement(ElementName = "Menge")]
            public string Menge { get; set; }
            [XmlElement(ElementName = "UnitID")]
            public string UnitID { get; set; }
            [XmlElement(ElementName = "Masse")]
            public string Masse { get; set; }
            [XmlElement(ElementName = "MasseUnit")]
            public string MasseUnit { get; set; }
            [XmlElement(ElementName = "AbfStatPosID")]
            public string AbfStatPosID { get; set; }
            [XmlElement(ElementName = "AbfSequenz")]
            public string AbfSequenz { get; set; }
            [XmlElement(ElementName = "MixTimeID")]
            public string MixTimeID { get; set; }
            [XmlElement(ElementName = "ApplBSubKompart")]
            public string ApplBSubKompart { get; set; }
            [XmlElement(ElementName = "AutIdem")]
            public string AutIdem { get; set; }
        }

        [XmlRoot(ElementName = "ZubDetArtBMixTimeDfn")]
        public class ZubDetArtBMixTimeDfn
        {
            [XmlElement(ElementName = "MixTimeID")]
            public string MixTimeID { get; set; }
            [XmlElement(ElementName = "MixTimeBez")]
            public string MixTimeBez { get; set; }
        }

        [XmlRoot(ElementName = "ZubArtDoku")]
        public class ZubArtDoku
        {
            [XmlElement(ElementName = "ZubArtDokuID")]
            public string ZubArtDokuID { get; set; }
            [XmlElement(ElementName = "ZubID")]
            public string ZubID { get; set; }
            [XmlElement(ElementName = "MixNr")]
            public string MixNr { get; set; }
            [XmlElement(ElementName = "ZubMixID")]
            public string ZubMixID { get; set; }
            [XmlElement(ElementName = "ZubKatID")]
            public string ZubKatID { get; set; }
            [XmlElement(ElementName = "ZubDetID")]
            public string ZubDetID { get; set; }
            [XmlElement(ElementName = "ArtFkt")]
            public string ArtFkt { get; set; }
            [XmlElement(ElementName = "ArtFktTLID")]
            public string ArtFktTLID { get; set; }
            [XmlElement(ElementName = "PosAnz")]
            public string PosAnz { get; set; }
            [XmlElement(ElementName = "PosAnzLag")]
            public string PosAnzLag { get; set; }
            [XmlElement(ElementName = "PosAnzRech")]
            public string PosAnzRech { get; set; }
            [XmlElement(ElementName = "ArtLagID")]
            public string ArtLagID { get; set; }
            [XmlElement(ElementName = "ArtID")]
            public string ArtID { get; set; }
            [XmlElement(ElementName = "ArtBez")]
            public string ArtBez { get; set; }
            [XmlElement(ElementName = "ArtPZN")]
            public string ArtPZN { get; set; }
            [XmlElement(ElementName = "ArtChB")]
            public string ArtChB { get; set; }
            [XmlElement(ElementName = "EndlessChB")]
            public string EndlessChB { get; set; }
            [XmlElement(ElementName = "Dos")]
            public string Dos { get; set; }
            [XmlElement(ElementName = "DosUnit")]
            public string DosUnit { get; set; }
            [XmlElement(ElementName = "Vol")]
            public string Vol { get; set; }
            [XmlElement(ElementName = "VolUnit")]
            public string VolUnit { get; set; }
            [XmlElement(ElementName = "STID")]
            public string STID { get; set; }
            [XmlElement(ElementName = "ArtTMAnz")]
            public string ArtTMAnz { get; set; }
            [XmlElement(ElementName = "AusAnbr")]
            public string AusAnbr { get; set; }
            [XmlElement(ElementName = "Anbruch")]
            public string Anbruch { get; set; }
            [XmlElement(ElementName = "HaltbDat")]
            public string HaltbDat { get; set; }
            [XmlElement(ElementName = "Verbraucht")]
            public string Verbraucht { get; set; }
            [XmlElement(ElementName = "ArtTMDos")]
            public string ArtTMDos { get; set; }
            [XmlElement(ElementName = "ArtTMVolDecl")]
            public string ArtTMVolDecl { get; set; }
            [XmlElement(ElementName = "ArtTMVolAdForRek")]
            public string ArtTMVolAdForRek { get; set; }
            [XmlElement(ElementName = "ArtTMVolFill")]
            public string ArtTMVolFill { get; set; }
            [XmlElement(ElementName = "AufbTypID")]
            public string AufbTypID { get; set; }
            [XmlElement(ElementName = "AufbTLID")]
            public string AufbTLID { get; set; }
            [XmlElement(ElementName = "AufbSubArtID")]
            public string AufbSubArtID { get; set; }
            [XmlElement(ElementName = "IsApplB")]
            public string IsApplB { get; set; }
            [XmlElement(ElementName = "VolCountsForSum")]
            public string VolCountsForSum { get; set; }
            [XmlElement(ElementName = "RekExABTL")]
            public string RekExABTL { get; set; }
            [XmlElement(ElementName = "DokuDat")]
            public string DokuDat { get; set; }
            [XmlElement(ElementName = "UsrID")]
            public string UsrID { get; set; }
        }

        [XmlRoot(ElementName = "Usr")]
        public class Usr
        {
            [XmlElement(ElementName = "UsrID")]
            public string UsrID { get; set; }
            [XmlElement(ElementName = "UsrShort")]
            public string UsrShort { get; set; }
            [XmlElement(ElementName = "UsrName")]
            public string UsrName { get; set; }
        }

        [XmlRoot(ElementName = "ArtZubFkt")]
        public class ArtZubFkt
        {
            [XmlElement(ElementName = "ArtZubFktID")]
            public string ArtZubFktID { get; set; }
            [XmlElement(ElementName = "ArtZubFktBez")]
            public string ArtZubFktBez { get; set; }
            [XmlElement(ElementName = "ArtZubFktBesch")]
            public string ArtZubFktBesch { get; set; }
            [XmlElement(ElementName = "AddOrderInDoku")]
            public string AddOrderInDoku { get; set; }
            [XmlElement(ElementName = "ArtZubFktKZ")]
            public string ArtZubFktKZ { get; set; }
        }

        [XmlRoot(ElementName = "ArtLager")]
        public class ArtLager
        {
            [XmlElement(ElementName = "ArtLagID")]
            public string ArtLagID { get; set; }
            [XmlElement(ElementName = "ArtID")]
            public string ArtID { get; set; }
            [XmlElement(ElementName = "ArtChB")]
            public string ArtChB { get; set; }
            [XmlElement(ElementName = "ArtTMAnz")]
            public string ArtTMAnz { get; set; }
            [XmlElement(ElementName = "ArtST")]
            public string ArtST { get; set; }
            [XmlElement(ElementName = "ArtTMDos")]
            public string ArtTMDos { get; set; }
            [XmlElement(ElementName = "ArtDosUnit")]
            public string ArtDosUnit { get; set; }
            [XmlElement(ElementName = "ArtTMVolDecl")]
            public string ArtTMVolDecl { get; set; }
            [XmlElement(ElementName = "ArtVolUnit")]
            public string ArtVolUnit { get; set; }
            [XmlElement(ElementName = "ArtAnbiet")]
            public string ArtAnbiet { get; set; }
            [XmlElement(ElementName = "ArtHerst")]
            public string ArtHerst { get; set; }
            [XmlElement(ElementName = "AufbTLID")]
            public string AufbTLID { get; set; }
            [XmlElement(ElementName = "ArtTMVolFill")]
            public string ArtTMVolFill { get; set; }
        }

        [XmlRoot(ElementName = "ArtAufbTyp")]
        public class ArtAufbTyp
        {
            [XmlElement(ElementName = "AufbTypID")]
            public string AufbTypID { get; set; }
            [XmlElement(ElementName = "AufbTypBez")]
            public string AufbTypBez { get; set; }
        }

        [XmlRoot(ElementName = "ZubDetImpRel")]
        public class ZubDetImpRel
        {
            [XmlElement(ElementName = "RelID")]
            public string RelID { get; set; }
            [XmlElement(ElementName = "ExtApplID")]
            public string ExtApplID { get; set; }
            [XmlElement(ElementName = "ExtSysID")]
            public string ExtSysID { get; set; }
            [XmlElement(ElementName = "ExtZubDetID")]
            public string ExtZubDetID { get; set; }
            [XmlElement(ElementName = "ZubDetID")]
            public string ZubDetID { get; set; }
            [XmlElement(ElementName = "Status")]
            public string Status { get; set; }
            [XmlElement(ElementName = "InsDat")]
            public string InsDat { get; set; }
            [XmlElement(ElementName = "ExpFileName")]
            public string ExpFileName { get; set; }
            [XmlElement(ElementName = "MoreInfo")]
            public string MoreInfo { get; set; }
        }

        [XmlRoot(ElementName = "Art")]
        public class Art
        {
            [XmlElement(ElementName = "ArtID")]
            public string ArtID { get; set; }
            [XmlElement(ElementName = "ArtIDUsr")]
            public string ArtIDUsr { get; set; }
            [XmlElement(ElementName = "ArtPZN")]
            public string ArtPZN { get; set; }
            [XmlElement(ElementName = "ArtBez")]
            public string ArtBez { get; set; }
            [XmlElement(ElementName = "ArtVE")]
            public string ArtVE { get; set; }
            [XmlElement(ElementName = "ArtAnbiet")]
            public string ArtAnbiet { get; set; }
            [XmlElement(ElementName = "ArtHerst")]
            public string ArtHerst { get; set; }
            [XmlElement(ElementName = "ArtBID")]
            public string ArtBID { get; set; }
            [XmlElement(ElementName = "ArtStdLief")]
            public string ArtStdLief { get; set; }
            [XmlElement(ElementName = "ArtLag")]
            public string ArtLag { get; set; }
            [XmlElement(ElementName = "ArtStdLag")]
            public string ArtStdLag { get; set; }
            [XmlElement(ElementName = "ArtLagBed")]
            public string ArtLagBed { get; set; }
            [XmlElement(ElementName = "ArtStdLagAnbr")]
            public string ArtStdLagAnbr { get; set; }
            [XmlElement(ElementName = "ArtLagBedAnbr")]
            public string ArtLagBedAnbr { get; set; }
            [XmlElement(ElementName = "ArtAnbrHaltbD")]
            public string ArtAnbrHaltbD { get; set; }
            [XmlElement(ElementName = "ArtAnbrHaltbH")]
            public string ArtAnbrHaltbH { get; set; }
            [XmlElement(ElementName = "ArtAnbrHaltbM")]
            public string ArtAnbrHaltbM { get; set; }
            [XmlElement(ElementName = "ArtAnbrHaltbIgnoreForZubHaltb")]
            public string ArtAnbrHaltbIgnoreForZubHaltb { get; set; }
            [XmlElement(ElementName = "ArtStdLagWE")]
            public string ArtStdLagWE { get; set; }
            [XmlElement(ElementName = "ArtBestMinVE")]
            public string ArtBestMinVE { get; set; }
            [XmlElement(ElementName = "ArtSTDSupplDays")]
            public string ArtSTDSupplDays { get; set; }
            [XmlElement(ElementName = "ArtMinOrderVE")]
            public string ArtMinOrderVE { get; set; }
            [XmlElement(ElementName = "ArtTM")]
            public string ArtTM { get; set; }
            [XmlElement(ElementName = "ArtTMAnz")]
            public string ArtTMAnz { get; set; }
            [XmlElement(ElementName = "ArtST")]
            public string ArtST { get; set; }
            [XmlElement(ElementName = "ArtTMDos")]
            public string ArtTMDos { get; set; }
            [XmlElement(ElementName = "ArtTMDosUnit")]
            public string ArtTMDosUnit { get; set; }
            [XmlElement(ElementName = "ArtTMVolFill")]
            public string ArtTMVolFill { get; set; }
            [XmlElement(ElementName = "ArtTMVolUnit")]
            public string ArtTMVolUnit { get; set; }
            [XmlElement(ElementName = "ArtTMVolDecl")]
            public string ArtTMVolDecl { get; set; }
            [XmlElement(ElementName = "ArtTMVolMax")]
            public string ArtTMVolMax { get; set; }
            [XmlElement(ElementName = "ArtAnbrIsPos")]
            public string ArtAnbrIsPos { get; set; }
            [XmlElement(ElementName = "ArtAnbrTMMinPart")]
            public string ArtAnbrTMMinPart { get; set; }
            [XmlElement(ElementName = "ArtTypID")]
            public string ArtTypID { get; set; }
            [XmlElement(ElementName = "ArtIsSubArt")]
            public string ArtIsSubArt { get; set; }
            [XmlElement(ElementName = "ArtMasterArtID")]
            public string ArtMasterArtID { get; set; }
            [XmlElement(ElementName = "ArtAufbTypID")]
            public string ArtAufbTypID { get; set; }
            [XmlElement(ElementName = "ArtAV")]
            public string ArtAV { get; set; }
            [XmlElement(ElementName = "ArtHaltbMon")]
            public string ArtHaltbMon { get; set; }
            [XmlElement(ElementName = "ArtInsDat")]
            public string ArtInsDat { get; set; }
            [XmlElement(ElementName = "ArtKZTmp")]
            public string ArtKZTmp { get; set; }
            [XmlElement(ElementName = "ArtDataInpOK")]
            public string ArtDataInpOK { get; set; }
            [XmlElement(ElementName = "ArtIsTLTyp")]
            public string ArtIsTLTyp { get; set; }
            [XmlElement(ElementName = "ArtIsApplB")]
            public string ArtIsApplB { get; set; }
            [XmlElement(ElementName = "NoSyncToABDA")]
            public string NoSyncToABDA { get; set; }
            [XmlElement(ElementName = "ArtTaxTypIDArtAbv")]
            public string ArtTaxTypIDArtAbv { get; set; }
            [XmlElement(ElementName = "ArtVerwTypID")]
            public string ArtVerwTypID { get; set; }
            [XmlElement(ElementName = "ArtTMDosTax")]
            public string ArtTMDosTax { get; set; }
            [XmlElement(ElementName = "ArtImport_Reimport_ABDA")]
            public string ArtImport_Reimport_ABDA { get; set; }
            [XmlElement(ElementName = "ArtVertriebAbDat")]
            public string ArtVertriebAbDat { get; set; }
            [XmlElement(ElementName = "ArtFreeForPrd")]
            public string ArtFreeForPrd { get; set; }
            [XmlElement(ElementName = "ArtMwStTyp")]
            public string ArtMwStTyp { get; set; }
        }

        [XmlRoot(ElementName = "VerStat")]
        public class VerStat
        {
            [XmlElement(ElementName = "VerStatID")]
            public string VerStatID { get; set; }
            [XmlElement(ElementName = "VersStatBez")]
            public string VersStatBez { get; set; }
        }

        [XmlRoot(ElementName = "Stationen")]
        public class Stationen
        {
            [XmlElement(ElementName = "StatID")]
            public string StatID { get; set; }
            [XmlElement(ElementName = "StatBez")]
            public string StatBez { get; set; }
        }

        [XmlRoot(ElementName = "Sex")]
        public class Sex
        {
            [XmlElement(ElementName = "SexID")]
            public string SexID { get; set; }
            [XmlElement(ElementName = "SexBez")]
            public string SexBez { get; set; }
        }

        [XmlRoot(ElementName = "PatDisp")]
        public class PatDisp
        {
            [XmlElement(ElementName = "PatDispID")]
            public string PatDispID { get; set; }
            [XmlElement(ElementName = "PatDispBez")]
            public string PatDispBez { get; set; }
            [XmlElement(ElementName = "PatDispMemo")]
            public string PatDispMemo { get; set; }
        }

        [XmlRoot(ElementName = "Lab")]
        public class Lab
        {
            [XmlElement(ElementName = "LabID")]
            public string LabID { get; set; }
            [XmlElement(ElementName = "Patient")]
            public string Patient { get; set; }
            [XmlElement(ElementName = "Datum")]
            public string Datum { get; set; }
        }

        [XmlRoot(ElementName = "Kostenstellen")]
        public class Kostenstellen
        {
            [XmlElement(ElementName = "KostID")]
            public string KostID { get; set; }
            [XmlElement(ElementName = "KostBez")]
            public string KostBez { get; set; }
        }

        [XmlRoot(ElementName = "LabDet")]
        public class LabDet
        {
            [XmlElement(ElementName = "LabDetID")]
            public string LabDetID { get; set; }
            [XmlElement(ElementName = "LabID")]
            public string LabID { get; set; }
            [XmlElement(ElementName = "LabWertID")]
            public string LabWertID { get; set; }
            [XmlElement(ElementName = "Wert")]
            public string Wert { get; set; }
            [XmlElement(ElementName = "LabDetBem")]
            public string LabDetBem { get; set; }
        }

        [XmlRoot(ElementName = "LabWerte")]
        public class LabWerte
        {
            [XmlElement(ElementName = "LabWertID")]
            public string LabWertID { get; set; }
            [XmlElement(ElementName = "LabWertBez")]
            public string LabWertBez { get; set; }
            [XmlElement(ElementName = "LabWertUnit")]
            public string LabWertUnit { get; set; }
            [XmlElement(ElementName = "LabWertMin")]
            public string LabWertMin { get; set; }
            [XmlElement(ElementName = "LabWertMax")]
            public string LabWertMax { get; set; }
            [XmlElement(ElementName = "LabWertTyp")]
            public string LabWertTyp { get; set; }
            [XmlElement(ElementName = "SysDS")]
            public string SysDS { get; set; }
        }

        [XmlRoot(ElementName = "LabWertTyp")]
        public class LabWertTyp
        {
            [XmlElement(ElementName = "LabWertTyp")]
            public string LabWertTyp { get; set; }
            [XmlElement(ElementName = "LabWertTypBez")]
            public string LabWertTypBez { get; set; }
        }

        [XmlRoot(ElementName = "Ext_Pat")]
        public class Ext_Pat
        {
            [XmlElement(ElementName = "RecID")]
            public string RecID { get; set; }
            [XmlElement(ElementName = "ExtApplID")]
            public string ExtApplID { get; set; }
            [XmlElement(ElementName = "ExtSysID")]
            public string ExtSysID { get; set; }
            [XmlElement(ElementName = "ExtPatID")]
            public string ExtPatID { get; set; }
            [XmlElement(ElementName = "ExtPatName")]
            public string ExtPatName { get; set; }
            [XmlElement(ElementName = "ExtPatVorname")]
            public string ExtPatVorname { get; set; }
            [XmlElement(ElementName = "ExtPatGebDat")]
            public string ExtPatGebDat { get; set; }
            [XmlElement(ElementName = "ExtPatSex")]
            public string ExtPatSex { get; set; }
            [XmlElement(ElementName = "SBPatGPID")]
            public string SBPatGPID { get; set; }
            [XmlElement(ElementName = "InsDate")]
            public string InsDate { get; set; }
        }

        [XmlRoot(ElementName = "GPPat")]
        public class GPPat
        {
            [XmlElement(ElementName = "GPID")]
            public string GPID { get; set; }
            [XmlElement(ElementName = "KrKaID")]
            public string KrKaID { get; set; }
            [XmlElement(ElementName = "VerStatID")]
            public string VerStatID { get; set; }
            [XmlElement(ElementName = "ZuzFreiAb")]
            public string ZuzFreiAb { get; set; }
            [XmlElement(ElementName = "ZuzFreiBis")]
            public string ZuzFreiBis { get; set; }
            [XmlElement(ElementName = "VersNr")]
            public string VersNr { get; set; }
            [XmlElement(ElementName = "VersMitglStatus")]
            public string VersMitglStatus { get; set; }
            [XmlElement(ElementName = "VKGueltBis")]
            public string VKGueltBis { get; set; }
        }

        [XmlRoot(ElementName = "PatDiag")]
        public class PatDiag
        {
            [XmlElement(ElementName = "PatDiagID")]
            public string PatDiagID { get; set; }
            [XmlElement(ElementName = "PatGPID")]
            public string PatGPID { get; set; }
            [XmlElement(ElementName = "DiagTxt")]
            public string DiagTxt { get; set; }
            [XmlElement(ElementName = "DiagDat")]
            public string DiagDat { get; set; }
        }

        [XmlRoot(ElementName = "GPKrKa")]
        public class GPKrKa
        {
            [XmlElement(ElementName = "GPID")]
            public string GPID { get; set; }
            [XmlElement(ElementName = "KrKaTypID")]
            public string KrKaTypID { get; set; }
            [XmlElement(ElementName = "KrKaSubTypID")]
            public string KrKaSubTypID { get; set; }
            [XmlElement(ElementName = "KrkaIK")]
            public string KrkaIK { get; set; }
            [XmlElement(ElementName = "KrKaVKNR")]
            public string KrKaVKNR { get; set; }
        }

        [XmlRoot(ElementName = "KrKaTyp")]
        public class KrKaTyp
        {
            [XmlElement(ElementName = "KrKaTypID")]
            public string KrKaTypID { get; set; }
            [XmlElement(ElementName = "TypBez")]
            public string TypBez { get; set; }
        }

        [XmlRoot(ElementName = "KrKaSubTyp")]
        public class KrKaSubTyp
        {
            [XmlElement(ElementName = "KrKaSubTypID")]
            public string KrKaSubTypID { get; set; }
            [XmlElement(ElementName = "KrKaSubTypBez")]
            public string KrKaSubTypBez { get; set; }
        }

        [XmlRoot(ElementName = "GPGPGr")]
        public class GPGPGr
        {
            [XmlElement(ElementName = "RecID")]
            public string RecID { get; set; }
            [XmlElement(ElementName = "GPID")]
            public string GPID { get; set; }
            [XmlElement(ElementName = "GPGrID")]
            public string GPGrID { get; set; }
        }

        [XmlRoot(ElementName = "GPGr")]
        public class GPGr
        {
            [XmlElement(ElementName = "GPGrID")]
            public string GPGrID { get; set; }
            [XmlElement(ElementName = "GPGruppe")]
            public string GPGruppe { get; set; }
        }

        [XmlRoot(ElementName = "TaxTyp")]
        public class TaxTyp
        {
            [XmlElement(ElementName = "TaxTypID")]
            public string TaxTypID { get; set; }
            [XmlElement(ElementName = "TaxTypBez")]
            public string TaxTypBez { get; set; }
        }

        [XmlRoot(ElementName = "Lagerort")]
        public class Lagerort
        {
            [XmlElement(ElementName = "LagOrtID")]
            public string LagOrtID { get; set; }
            [XmlElement(ElementName = "LagOrtBez")]
            public string LagOrtBez { get; set; }
            [XmlElement(ElementName = "LagBedID")]
            public string LagBedID { get; set; }
            [XmlElement(ElementName = "SperrLagTypID")]
            public string SperrLagTypID { get; set; }
            [XmlElement(ElementName = "PrdLineLag")]
            public string PrdLineLag { get; set; }
            [XmlElement(ElementName = "Active")]
            public string Active { get; set; }
        }

        [XmlRoot(ElementName = "ArtTyp")]
        public class ArtTyp
        {
            [XmlElement(ElementName = "ArtTypID")]
            public string ArtTypID { get; set; }
            [XmlElement(ElementName = "ArtTypBez")]
            public string ArtTypBez { get; set; }
        }

        [XmlRoot(ElementName = "MgmtInfo")]
        public class MgmtInfo
        {
            [XmlElement(ElementName = "VersionNo")]
            public string VersionNo { get; set; }
            [XmlElement(ElementName = "ExportID")]
            public string ExportID { get; set; }
            [XmlElement(ElementName = "ExportDate")]
            public string ExportDate { get; set; }
            [XmlElement(ElementName = "Theme")]
            public string Theme { get; set; }
            [XmlElement(ElementName = "ImportStatID")]
            public string ImportStatID { get; set; }
            [XmlElement(ElementName = "SenderExtApplID")]
            public string SenderExtApplID { get; set; }
            [XmlElement(ElementName = "SenderExtSysID")]
            public string SenderExtSysID { get; set; }
            [XmlElement(ElementName = "ReceiverExtApplID")]
            public string ReceiverExtApplID { get; set; }
            [XmlElement(ElementName = "ReceiverExtSysID")]
            public string ReceiverExtSysID { get; set; }
        }

        [XmlRoot(ElementName = "WAEExport")]
        public class WAEExport
        {
            [XmlElement(ElementName = "ZubDet")]
            public List<ZubDet> ZubDet { get; set; }
            [XmlElement(ElementName = "ZubStatus")]
            public List<ZubStatus> ZubStatus { get; set; }
            [XmlElement(ElementName = "ZubKat")]
            public List<ZubKat> ZubKat { get; set; }
            [XmlElement(ElementName = "Zub")]
            public List<Zub> Zub { get; set; }
            [XmlElement(ElementName = "Units")]
            public List<Units> Units { get; set; }
            [XmlElement(ElementName = "TL")]
            public List<TL> TL { get; set; }
            [XmlElement(ElementName = "ST")]
            public List<ST> ST { get; set; }
            [XmlElement(ElementName = "LightProtDfn")]
            public List<LightProtDfn> LightProtDfn { get; set; }
            [XmlElement(ElementName = "LagerBed")]
            public LagerBed LagerBed { get; set; }
            [XmlElement(ElementName = "GP")]
            public List<GP> GP { get; set; }
            [XmlElement(ElementName = "DosTyp")]
            public List<DosTyp> DosTyp { get; set; }
            [XmlElement(ElementName = "ArtB")]
            public List<ArtB> ArtB { get; set; }
            [XmlElement(ElementName = "ApplZbh")]
            public ApplZbh ApplZbh { get; set; }
            [XmlElement(ElementName = "ApplWeg")]
            public List<ApplWeg> ApplWeg { get; set; }
            [XmlElement(ElementName = "ApplGeraet")]
            public List<ApplGeraet> ApplGeraet { get; set; }
            [XmlElement(ElementName = "ApplForm")]
            public List<ApplForm> ApplForm { get; set; }
            [XmlElement(ElementName = "ZubDetArtB")]
            public List<ZubDetArtB> ZubDetArtB { get; set; }
            [XmlElement(ElementName = "ZubDetArtBMixTimeDfn")]
            public ZubDetArtBMixTimeDfn ZubDetArtBMixTimeDfn { get; set; }
            [XmlElement(ElementName = "ZubArtDoku")]
            public List<ZubArtDoku> ZubArtDoku { get; set; }
            [XmlElement(ElementName = "Usr")]
            public Usr Usr { get; set; }
            [XmlElement(ElementName = "ArtZubFkt")]
            public List<ArtZubFkt> ArtZubFkt { get; set; }
            [XmlElement(ElementName = "ArtLager")]
            public ArtLager ArtLager { get; set; }
            [XmlElement(ElementName = "ArtAufbTyp")]
            public List<ArtAufbTyp> ArtAufbTyp { get; set; }
            [XmlElement(ElementName = "ZubDetImpRel")]
            public List<ZubDetImpRel> ZubDetImpRel { get; set; }
            [XmlElement(ElementName = "Art")]
            public Art Art { get; set; }
            [XmlElement(ElementName = "VerStat")]
            public List<VerStat> VerStat { get; set; }
            [XmlElement(ElementName = "Stationen")]
            public Stationen Stationen { get; set; }
            [XmlElement(ElementName = "Sex")]
            public List<Sex> Sex { get; set; }
            [XmlElement(ElementName = "PatDisp")]
            public PatDisp PatDisp { get; set; }
            [XmlElement(ElementName = "Lab")]
            public List<Lab> Lab { get; set; }
            [XmlElement(ElementName = "Kostenstellen")]
            public Kostenstellen Kostenstellen { get; set; }
            [XmlElement(ElementName = "LabDet")]
            public List<LabDet> LabDet { get; set; }
            [XmlElement(ElementName = "LabWerte")]
            public LabWerte LabWerte { get; set; }
            [XmlElement(ElementName = "LabWertTyp")]
            public LabWertTyp LabWertTyp { get; set; }
            [XmlElement(ElementName = "Ext_Pat")]
            public List<Ext_Pat> Ext_Pat { get; set; }
            [XmlElement(ElementName = "GPPat")]
            public List<GPPat> GPPat { get; set; }
            [XmlElement(ElementName = "PatDiag")]
            public List<PatDiag> PatDiag { get; set; }
            [XmlElement(ElementName = "GPKrKa")]
            public List<GPKrKa> GPKrKa { get; set; }
            [XmlElement(ElementName = "KrKaTyp")]
            public List<KrKaTyp> KrKaTyp { get; set; }
            [XmlElement(ElementName = "KrKaSubTyp")]
            public List<KrKaSubTyp> KrKaSubTyp { get; set; }
            [XmlElement(ElementName = "GPGPGr")]
            public List<GPGPGr> GPGPGr { get; set; }
            [XmlElement(ElementName = "GPGr")]
            public List<GPGr> GPGr { get; set; }
            [XmlElement(ElementName = "TaxTyp")]
            public TaxTyp TaxTyp { get; set; }
            [XmlElement(ElementName = "Lagerort")]
            public Lagerort Lagerort { get; set; }
            [XmlElement(ElementName = "ArtTyp")]
            public ArtTyp ArtTyp { get; set; }
            [XmlElement(ElementName = "MgmtInfo")]
            public MgmtInfo MgmtInfo { get; set; }
        }

    }

}

