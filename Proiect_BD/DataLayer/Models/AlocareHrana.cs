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

        public static void insert_AlocareHrana(int student, int pret, int admin, int counter)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            AlocareHrana aloc = new AlocareHrana
            {
                ID_Student = student,
                ID_Pret = pret,
                ID_Administrator = admin,
                Counter = counter
            };

            bd.AlocareHranas.Add(aloc);
            bd.Entry(aloc).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }

        public static void delete_AlocareHrana(int student, int pret)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var aloc = (from b in bd.AlocareHranas
                        where b.ID_Student == student &&
                              b.ID_Pret == pret
                        select b).First();

            bd.AlocareHranas.Remove(aloc);
            bd.Entry(aloc).State = System.Data.Entity.EntityState.Deleted;
            bd.SaveChanges();
        }

        public static void update_AlocareHrana(int student, int pret, int admin, int counter)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var aloc = (from b in bd.AlocareHranas
                        where b.ID_Student == student &&
                              b.ID_Pret == pret
                        select b).First();

            aloc.ID_Administrator = admin;
            aloc.Counter = counter;

            bd.Entry(aloc).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }
    }
}
