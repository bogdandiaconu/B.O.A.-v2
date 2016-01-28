using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class CDT_Comp
    {
        public CDT_Comp()
        {
            this.Companies = new List<Companie>();
        }

        public int ID_Comandant { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ID_Grad { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual ICollection<Companie> Companies { get; set; }
        public static IQueryable<Models.CDT_Comp> get_CDT_comp()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.CDT_Comp
                        select b;
            return query;
        }
    }
}
