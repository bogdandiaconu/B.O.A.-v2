using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class newStudent
    {
        public int ID_Student { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ID_Grad { get; set; }
        public string Grad { get; set; }
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public int ID_Companie { get; set; }
        public string Companie { get; set; }
    }
    public partial class Student
    {
        public Student()
        {
            this.AlocareHranas = new List<AlocareHrana>();
            this.ArticoleDrepturis = new List<ArticoleDrepturi>();
            this.ArticoleVests = new List<ArticoleVest>();
        }

        public int ID_Student { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ID_Grad { get; set; }
        public string CNP { get; set; }
        public string Adresa { get; set; }
        public int ID_Companie { get; set; }
        public virtual ICollection<AlocareHrana> AlocareHranas { get; set; }
        public virtual ICollection<ArticoleDrepturi> ArticoleDrepturis { get; set; }
        public virtual ICollection<ArticoleVest> ArticoleVests { get; set; }
        public virtual Companie Companie { get; set; }
        public virtual Grade Grade { get; set; }
        public static IQueryable<Models.newStudent> get_Student()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Students
                        join g in bd.Grades on b.ID_Grad equals g.ID_Grad
                        join c in bd.Companies on b.ID_Companie equals c.ID_Companie
                        select new newStudent
                        {
                            ID_Student = b.ID_Student,
                            Nume = b.Nume,
                            Prenume = b.Prenume,
                            ID_Grad = b.ID_Grad,
                            Grad = g.Nume,
                            CNP = b.CNP,
                            Adresa = b.Adresa,
                            ID_Companie = b.ID_Companie,
                            Companie = c.Nume
                        };
            return query;
        }

        public static void insert_Student(string nume, string prenume, int grad, string cnp, string adresa, int comp)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            Student st = new Student
            {
                Nume = nume,
                Prenume = prenume,
                ID_Grad = grad,
                CNP = cnp,
                Adresa = adresa,
                ID_Companie = comp
            };

            bd.Students.Add(st);
            bd.Entry(st).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }

        public static void delete_Student(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var st = (from b in bd.Students
                     where b.ID_Student == id
                     select b).First();

            bd.Students.Remove(st);
            bd.Entry(st).State = System.Data.Entity.EntityState.Deleted;
            bd.SaveChanges();
        }

        public static void update_Student(int id, string nume, string prenume, int grad, string cnp, string adresa, int comp)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var st = (from b in bd.Students
                      where b.ID_Student == id
                      select b).First();

            st.Nume = nume;
            st.Prenume = prenume;
            st.ID_Grad = grad;
            st.CNP = cnp;
            st.Adresa = adresa;
            st.ID_Companie = comp;

            bd.Entry(st).State = System.Data.Entity.EntityState.Modified;
            bd.SaveChanges();
        }

    }
}
