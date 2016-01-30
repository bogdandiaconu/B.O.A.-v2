using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class newAlocareHrana
    {
        public int ID_Student { get; set; }
        public string Nume_Student { get; set; }
        public int ID_Pret { get; set; }
        public string Nume_Produs { get; set; }
        public double Pret { get; set; }
        public int ID_Administrator { get; set; }
        public string Nume_Administrator { get; set; }
        public int Counter { get; set; }
    }
    public partial class AlocareHrana
    {
        public int ID_Student { get; set; }
        public int ID_Pret { get; set; }
        public int ID_Administrator { get; set; }
        public int Counter { get; set; }
        public virtual Administratori Administratori { get; set; }
        public virtual Preturi Preturi { get; set; }
        public virtual Student Student { get; set; }
        public static IQueryable<Models.newAlocareHrana> get_AlocareHrana()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from a in bd.AlocareHranas
                        join s in bd.Students on a.ID_Student equals s.ID_Student
                        join p in bd.Preturis on a.ID_Pret equals p.ID_Pret
                        join adm in bd.Administratoris on a.ID_Administrator equals adm.ID_Admistrator
                        select new newAlocareHrana
                        {
                            ID_Student = s.ID_Student,
                            Nume_Student = s.Nume + " " + s.Prenume,
                            ID_Pret = p.ID_Pret,
                            Nume_Produs = p.Nume,
                            Pret = p.Pret,
                            ID_Administrator = adm.ID_Admistrator,
                            Nume_Administrator = adm.Nume + " " + adm.Prenume,
                            Counter = a.Counter
                        };
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
        public static bool Exists(int student,int pret)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var st = from b in bd.AlocareHranas
                     where b.ID_Student == student &&
                           b.ID_Pret == pret
                     select b;

            var list = st.ToList();
            if (list.Count != 0)
                return true;
            else
                return false;
        }
    }
}
