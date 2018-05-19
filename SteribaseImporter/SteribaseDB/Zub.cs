using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Zub
    {
        public Zub()
        {
            Zubartdoku = new HashSet<Zubartdoku>();
            Zubdet = new HashSet<Zubdet>();
            Zubdetartb = new HashSet<Zubdetartb>();
        }

        public DateTime? AnfordDat { get; set; }
        public DateTime? PatGebDat { get; set; }
        public string PatGewIdeal { get; set; }
        public string PatSex { get; set; }
        public int ZubId { get; set; }
        public int? Patient { get; set; }
        public int? Verordner { get; set; }
        public int? StatId { get; set; }
        public int? AuftrGeb { get; set; }
        public int? LohnAuftrGeb { get; set; }
        public int? LohnHerst { get; set; }
        public int? KostId { get; set; }
        public int? PatGr { get; set; }
        public double? PatKof { get; set; }
        public int? ZyklNr { get; set; }
        public int? DiagStdid { get; set; }
        public int? Pdid { get; set; }
        public int? Pkid { get; set; }
        public int? PatVerStatId { get; set; }
        public int? PatDispId { get; set; }
        public int? AuftrVerm { get; set; }
        public int? LabId { get; set; }
        public double? PatGew { get; set; }
        public double? PatGewReal { get; set; }

        public Kostenstellen Kost { get; set; }
        public Lab Lab { get; set; }
        public Patdisp PatDisp { get; set; }
        public Stationen Stat { get; set; }
        public ICollection<Zubartdoku> Zubartdoku { get; set; }
        public ICollection<Zubdet> Zubdet { get; set; }
        public ICollection<Zubdetartb> Zubdetartb { get; set; }
    }
}
