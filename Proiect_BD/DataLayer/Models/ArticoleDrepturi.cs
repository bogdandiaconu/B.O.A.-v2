using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class newArticoleDrepturi
    {
        public int ID_Student { get; set; }
        public string Nume_Student { get; set; }
        public int ID_Administrator { get; set; }
        public string Nume_Administrator { get; set; }
        public System.DateTime Data_Alocarii { get; set; }
        public Nullable<int> Savoniera { get; set; }
        public Nullable<int> Sapun { get; set; }
        public Nullable<int> Spuma_ras { get; set; }
        public Nullable<int> Aparat_ras { get; set; }
        public Nullable<int> Caiete { get; set; }
        public Nullable<int> Rigla { get; set; }
        public Nullable<int> Guma { get; set; }
        public Nullable<int> Crema { get; set; }
        public Nullable<int> Maieu { get; set; }
        public Nullable<int> Agrafe { get; set; }
        public Nullable<int> Capse { get; set; }
    }
    public partial class ArticoleDrepturi
    {
        public int ID_Student { get; set; }
        public int ID_Administrator { get; set; }
        public System.DateTime Data_Alocarii { get; set; }
        public Nullable<int> Savoniera { get; set; }
        public Nullable<int> Sapun { get; set; }
        public Nullable<int> Spuma_ras { get; set; }
        public Nullable<int> Aparat_ras { get; set; }
        public Nullable<int> Caiete { get; set; }
        public Nullable<int> Rigla { get; set; }
        public Nullable<int> Guma { get; set; }
        public Nullable<int> Crema { get; set; }
        public Nullable<int> Maieu { get; set; }
        public Nullable<int> Agrafe { get; set; }
        public Nullable<int> Capse { get; set; }
        public virtual Administratori Administratori { get; set; }
        public virtual Student Student { get; set; }
        public static IQueryable<Models.newArticoleDrepturi> get_ArticoleDrepturi()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.ArticoleDrepturis
                        join s in bd.Students on b.ID_Student equals s.ID_Student
                        join a in bd.Administratoris on b.ID_Administrator equals a.ID_Admistrator
                        select new newArticoleDrepturi
                        {
                            ID_Student = b.ID_Student,
                            Nume_Student = s.Nume + " " + s.Prenume,
                            ID_Administrator = b.ID_Administrator,
                            Nume_Administrator = a.Nume + " " + a.Prenume,
                            Data_Alocarii = b.Data_Alocarii,
                            Savoniera = b.Savoniera,
                            Sapun = b.Sapun,
                            Spuma_ras = b.Spuma_ras,
                            Aparat_ras = b.Aparat_ras,
                            Caiete = b.Caiete,
                            Rigla = b.Rigla,
                            Guma = b.Guma,
                            Crema = b.Crema,
                            Maieu = b.Maieu,
                            Agrafe = b.Agrafe,
                            Capse = b.Capse
                        };
            return query;
        }

        public static void insert_ArticoleDrepturi(int id_stud, int id_admin, DateTime data, int savoniera,
                                                    int sapun, int spuma, int aparat, int caiete, int rigla,
                                                    int guma, int crema, int maieu, int agrafe, int capse)
        {
            var bd = new DataLayer.Models.ProiectBDContext();

            ArticoleDrepturi art = new ArticoleDrepturi
            {
                ID_Student = id_stud,
                ID_Administrator = id_admin,
                Data_Alocarii = data,
                Savoniera = savoniera,
                Sapun = sapun,
                Spuma_ras = spuma,
                Aparat_ras = aparat,
                Caiete = caiete,
                Rigla = rigla,
                Guma = guma,
                Crema = crema,
                Maieu = maieu,
                Agrafe = agrafe,
                Capse = capse
            };

            bd.ArticoleDrepturis.Add(art);
            bd.Entry(art).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }
            
    }
}
