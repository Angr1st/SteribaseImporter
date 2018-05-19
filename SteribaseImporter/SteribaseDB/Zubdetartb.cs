using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zubdetartb
    {
        public string AutIdem { get; set; }
        public int ZubDetArtBid { get; set; }
        public int? ZubId { get; set; }
        public int? ZubDetId { get; set; }
        public int? ArtBid { get; set; }
        public int? Menge { get; set; }
        public int? UnitId { get; set; }
        public double? Masse { get; set; }
        public int? MasseUnit { get; set; }
        public int? AbfSequenz { get; set; }
        public int? MixTimeId { get; set; }
        public int? ApplBsubKompart { get; set; }
        public int? AbfStatPosId { get; set; }

        public Artb ArtB { get; set; }
        public Zubdetartbmixtimedfn MixTime { get; set; }
        public Units Unit { get; set; }
        public Zub Zub { get; set; }
        public Zubdet ZubDet { get; set; }
    }
}
