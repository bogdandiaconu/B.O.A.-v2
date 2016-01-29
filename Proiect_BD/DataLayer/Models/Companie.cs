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

        public static void insert_Companie(string nume, int com, int admin)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            Companie comp = new Companie
            {
                Nume = nume,
                ID_Comandant = com,
                ID_Administrator = admin
            };

            bd.Companies.Add(comp);
            bd.Entry(comp).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }


        public static void delete_Companie(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var comp = (from b in bd.Companies
                         where b.ID_Companie == id
                         select b).First();

            bd.Companies.Remove(comp);
            bd.Entry(comp).State = System.Data.Entity.EntityState.Deleted;
            bd.SaveChanges();
        }

        public static void update_Companie(int id, string nume, int com, int admin)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var comp = (from b in bd.Companies
                        where b.ID_Companie == id
                        select b).First();

            comp.Nume = nume;
            comp.ID_Comandant = com;
            comp.ID_Administrator = admin;

            bd.Entry(comp).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }
    }
}
