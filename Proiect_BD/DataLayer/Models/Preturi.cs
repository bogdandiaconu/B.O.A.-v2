using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class Preturi
    {
        public Preturi()
        {
            this.AlocareHranas = new List<AlocareHrana>();
        }

        public int ID_Pret { get; set; }
        public string Nume { get; set; }
        public double Pret { get; set; }
        public System.DateTime Data { get; set; }
        public virtual ICollection<AlocareHrana> AlocareHranas { get; set; }
        public static IQueryable<Models.Preturi> get_Preturi()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Preturis
                        select b;
            return query;
        }
    }
}
