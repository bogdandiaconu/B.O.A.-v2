using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;

namespace DataLayer.Models
{
    public partial class newAdministratori
    {
        public int ID_Administrator { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ID_Grad { get; set; }
        public string Grad { get; set; }
    }
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

        public static IQueryable<Models.newAdministratori> get_Administratori()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Administratoris
                        join c in bd.Grades
                        on b.ID_Grad equals c.ID_Grad
                        select new newAdministratori {
                            ID_Administrator = b.ID_Admistrator,
                            Nume = b.Nume,
                            Prenume = b.Prenume,
                            ID_Grad = b.ID_Grad,
                            Grad = c.Nume
                        };
            return query;
        }

        public static void insert_Administratori(string nume, string prenume, int grad)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            Administratori admin = new Administratori
            {
                Nume = nume,
                Prenume = prenume,
                ID_Grad = grad
            };

            bd.Administratoris.Add(admin);
            bd.Entry(admin).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
          
        }

        public static void delete_Administratori(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = (from b in bd.Administratoris
                        where b.ID_Admistrator == id
                        select b).First();

            bd.Administratoris.Remove(query);
            bd.Entry(query).State = System.Data.Entity.EntityState.Deleted;
            bd.SaveChanges();
        }

        public static void update_Administratori(int id, string nume, string prenume, int grad)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = (from b in bd.Administratoris
                         where b.ID_Admistrator == id
                         select b).First();
            query.Nume = nume;
            query.Prenume = prenume;
            query.ID_Grad = grad;

            bd.Entry(query).State = System.Data.Entity.EntityState.Modified;

            bd.SaveChanges();
        }
    }
}
