using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class Grade
    {
        public Grade()
        {
            this.Administratoris = new List<Administratori>();
            this.CDT_Comp = new List<CDT_Comp>();
            this.Students = new List<Student>();
        }

        public int ID_Grad { get; set; }
        public string Nume { get; set; }
        public virtual ICollection<Administratori> Administratoris { get; set; }
        public virtual ICollection<CDT_Comp> CDT_Comp { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public static IQueryable<Models.Grade> get_Grade()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Grades
                        select b;
            return query;
        }

        public static void insert_Grade(string grad)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            Grade gr = new Grade { Nume = grad };

            bd.Grades.Add(gr);
            bd.Entry(gr).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }

        public static void delete_Grade(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var gr = (from g in bd.Grades
                      where g.ID_Grad == id
                      select g).First();

            bd.Grades.Remove(gr);
            bd.Entry(gr).State = System.Data.Entity.EntityState.Deleted;
            bd.SaveChanges();
        }

        public static void update_Grade(int id, string nume)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var gr = (from g in bd.Grades
                     where g.ID_Grad == id
                     select g).First();

            gr.Nume = nume;

            bd.Entry(gr).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }
    }
}
