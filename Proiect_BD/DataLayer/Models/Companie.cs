using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class Companie
    {
        public Companie()
        {
            this.Students = new List<Student>();
        }

        public int ID_Companie { get; set; }
        public string Nume { get; set; }
        public int ID_Comandant { get; set; }
        public int ID_Administrator { get; set; }
        public virtual Administratori Administratori { get; set; }
        public virtual CDT_Comp CDT_Comp { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public static IQueryable<Models.Companie> get_Companie()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Companies
                        select b;
            return query;
        }
    }
}
