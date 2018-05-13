using System;
using System.Collections.Generic;

namespace SteribaseImporter.SteribaseDB
{
    public partial class Patdisp
    {
        public Patdisp()
        {
            Zub = new HashSet<Zub>();
        }

        public int PatDispId { get; set; }
        public string PatDispBez { get; set; }
        public string PatDispMemo { get; set; }

        public ICollection<Zub> Zub { get; set; }
    }
}
