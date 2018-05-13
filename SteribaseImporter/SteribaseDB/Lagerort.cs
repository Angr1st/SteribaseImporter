using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Lagerort
    {
        public int LagOrtId { get; set; }
        public string LagOrtBez { get; set; }
        public int? LagBedId { get; set; }
        public int? SperrLagTypId { get; set; }
        public string PrdLineLag { get; set; }
        public string Active { get; set; }

        public Lagerbed LagBed { get; set; }
    }
}
