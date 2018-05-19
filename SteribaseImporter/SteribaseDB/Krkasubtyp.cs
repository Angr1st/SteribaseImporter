using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Krkasubtyp
    {
        public Krkasubtyp()
        {
            Gpkrka = new HashSet<Gpkrka>();
        }

        public string KrKaSubTypBez { get; set; }
        public int KrKaSubTypId { get; set; }

        public ICollection<Gpkrka> Gpkrka { get; set; }
    }
}
