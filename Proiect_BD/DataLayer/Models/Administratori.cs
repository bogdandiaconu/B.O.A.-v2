using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class Administratori
    {
        public Administratori()
        {
            this.AlocareHranas = new List<AlocareHrana>();
            this.ArticoleDrepturis = new List<ArticoleDrepturi>();
            this.ArticoleVests = new List<ArticoleVest>();
            this.Companies = new List<Companie>();
        }

        public int ID_Admistrator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ID_Grad { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<AlocareHrana> AlocareHranas { get; set; }
        public virtual ICollection<ArticoleDrepturi> ArticoleDrepturis { get; set; }
        public virtual ICollection<ArticoleVest> ArticoleVests { get; set; }
        public virtual ICollection<Companie> Companies { get; set; }

        public static IQueryable<Models.Administratori> get_Administratori()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Administratoris
                        select b;
            return query;
        }
    }
}
