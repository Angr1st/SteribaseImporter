using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Krkatyp
    {
        public Krkatyp()
        {
            Gpkrka = new HashSet<Gpkrka>();
        }

        public string TypBez { get; set; }
        public int KrKaTypId { get; set; }

        public ICollection<Gpkrka> Gpkrka { get; set; }
    }
}
