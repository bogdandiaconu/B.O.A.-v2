using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class AlocareHrana
    {
        public int ID_Student { get; set; }
        public int ID_Pret { get; set; }
        public int ID_Administrator { get; set; }
        public int Counter { get; set; }
        public virtual Administratori Administratori { get; set; }
        public virtual Preturi Preturi { get; set; }
        public virtual Student Student { get; set; }
    }
}
