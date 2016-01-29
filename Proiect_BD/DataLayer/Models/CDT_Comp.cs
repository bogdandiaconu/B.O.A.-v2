using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class newCDT_Comp
    {
        public int ID_Comandant { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ID_Grad { get; set; }
        public string Grad { get; set; }
    }
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
        public static IQueryable<Models.newCDT_Comp> get_CDT_comp()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.CDT_Comp
                        join g in bd.Grades on b.ID_Grad equals g.ID_Grad
                        select new newCDT_Comp
                        {
                            ID_Comandant = b.ID_Comandant,
                            Nume = b.Nume,
                            Prenume = b.Prenume,
                            ID_Grad = b.ID_Grad,
                            Grad = g.Nume
                        };
            return query;
        }

        public static void insert_CDT_Comp(string nume, string prenume, int grad)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            CDT_Comp cdt = new CDT_Comp
            {
                Nume = nume,
                Prenume = prenume,
                ID_Grad = grad
            };

            bd.CDT_Comp.Add(cdt);
            bd.Entry(cdt).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }

        public static void delete_CDT_Comp(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var cdt = (from b in bd.CDT_Comp
                       where b.ID_Comandant == id
                       select b).First();

            bd.CDT_Comp.Remove(cdt);
            bd.Entry(cdt).State = System.Data.Entity.EntityState.Deleted;
            bd.SaveChanges();
        }

        public static void update_CDT_Comp(int id, string nume, string prenume, int grad)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var cdt = (from b in bd.CDT_Comp
                       where b.ID_Comandant == id
                       select b).First();

            cdt.Nume = nume;
            cdt.Prenume = prenume;
            cdt.ID_Grad = grad;

            bd.Entry(cdt).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }
    }
}
