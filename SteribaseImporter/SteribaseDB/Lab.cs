using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Lab
    {
        public Lab()
        {
            Labdet = new HashSet<Labdet>();
            Zub = new HashSet<Zub>();
        }

        public DateTime? Datum { get; set; }
        public int LabId { get; set; }
        public int? Patient { get; set; }

        public ICollection<Labdet> Labdet { get; set; }
        public ICollection<Zub> Zub { get; set; }
    }
}
