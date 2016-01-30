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

            var x = query.ToList();
            return query;
        }

        public static void insert_Preturi(string nume, double pret, DateTime data)
        {
            var bd = new DataLayer.Models.ProiectBDContext();

            Preturi pr = new Preturi
            {
                Nume = nume,
                Pret = pret,
                Data = data
            };

            bd.Preturis.Add(pr);
            bd.Entry(pr).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }

        public static void delete_Preturi(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var pr = (from b in bd.Preturis
                      where b.ID_Pret == id
                      select b).First();

            bd.Preturis.Remove(pr);
            bd.Entry(pr).State = System.Data.Entity.EntityState.Deleted;
            bd.SaveChanges();
        }

        public static void update_Preturi(int id, string nume, double pret, DateTime data)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var pr = (from b in bd.Preturis
                      where b.ID_Pret == id
                      select b).First();

            pr.Nume = nume;
            pr.Pret = pret;
            pr.Data = data;

            bd.Entry(pr).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }
        public static bool Exists(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var st = from b in bd.Preturis
                     where b.ID_Pret == id
                     select b;

            var list = st.ToList();
            if (list.Count != 0)
                return true;
            else
                return false;
        }
    }
}
