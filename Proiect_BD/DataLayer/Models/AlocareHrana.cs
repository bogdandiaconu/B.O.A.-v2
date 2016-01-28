using System;
using System.Collections.Generic;
using System.Linq;

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
        public static IQueryable<Models.AlocareHrana> get_AlocareHrana()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.AlocareHranas
                        select b;
            return query;
        }
    }
}
