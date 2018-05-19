using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Gpkrka
    {
        public int Gpid { get; set; }
        public int KrKaTypId { get; set; }
        public int KrKaSubTypId { get; set; }
        public int? KrkaIk { get; set; }
        public int? KrKaVknr { get; set; }

        public Gp Gp { get; set; }
        public Krkasubtyp KrKaSubTyp { get; set; }
        public Krkatyp KrKaTyp { get; set; }
    }
}
