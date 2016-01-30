using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
    public partial class newArticoleVest
    {
        public int ID_Student { get; set; }
        public string Nume_Student { get; set; }
        public int ID_Administrator { get; set; }
        public string Nume_Administrator { get; set; }
        public System.DateTime Data_Alocarii { get; set; }
        public Nullable<int> Bocanci { get; set; }
        public Nullable<int> Capela { get; set; }
        public Nullable<int> Cascheta { get; set; }
        public Nullable<int> Costum_Camuflaj { get; set; }
        public Nullable<int> Costum_Tercot { get; set; }
        public Nullable<int> Costum_Camgarn { get; set; }
        public Nullable<int> Camasa_Alba { get; set; }
        public Nullable<int> Camasa_Arma { get; set; }
        public Nullable<int> Camasa_Camuflaj { get; set; }
        public Nullable<int> Boneta { get; set; }
        public Nullable<int> Fular { get; set; }
        public Nullable<int> Pantofi { get; set; }
        public Nullable<int> Ghete { get; set; }
        public Nullable<int> Ecuson_Nominal { get; set; }
        public Nullable<int> Ecuson_Romania { get; set; }
        public Nullable<int> Cuc { get; set; }
        public Nullable<int> Cravata { get; set; }
        public Nullable<int> Scurta_Oras { get; set; }
        public Nullable<int> Scurta_Camuflat { get; set; }
    }
    public partial class ArticoleVest
    {
        public int ID_Student { get; set; }
        public int ID_Administrator { get; set; }
        public System.DateTime Data_Alocarii { get; set; }
        public Nullable<int> Bocanci { get; set; }
        public Nullable<int> Capela { get; set; }
        public Nullable<int> Cascheta { get; set; }
        public Nullable<int> Costum_Camuflaj { get; set; }
        public Nullable<int> Costum_Tercot { get; set; }
        public Nullable<int> Costum_Camgarn { get; set; }
        public Nullable<int> Camasa_Alba { get; set; }
        public Nullable<int> Camasa_Arma { get; set; }
        public Nullable<int> Camasa_Camuflaj { get; set; }
        public Nullable<int> Boneta { get; set; }
        public Nullable<int> Fular { get; set; }
        public Nullable<int> Pantofi { get; set; }
        public Nullable<int> Ghete { get; set; }
        public Nullable<int> Ecuson_Nominal { get; set; }
        public Nullable<int> Ecuson_Romania { get; set; }
        public Nullable<int> Cuc { get; set; }
        public Nullable<int> Cravata { get; set; }
        public Nullable<int> Scurta_Oras { get; set; }
        public Nullable<int> Scurta_Camuflat { get; set; }
        public virtual Administratori Administratori { get; set; }
        public virtual Student Student { get; set; }
        public static IQueryable<Models.newArticoleVest> get_ArticoleVest()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.ArticoleVests
                        join s in bd.Students on b.ID_Student equals s.ID_Student
                        join a in bd.Administratoris on b.ID_Administrator equals a.ID_Admistrator
                        select new newArticoleVest
                        {
                            ID_Student = b.ID_Student,
                            Nume_Student = s.Nume+" "+s.Prenume,
                            ID_Administrator = b.ID_Administrator,
                            Nume_Administrator = a.Nume+" "+a.Prenume,
                            Data_Alocarii = b.Data_Alocarii,
                            Bocanci = b.Bocanci,
                            Capela = b.Capela,
                            Cascheta = b.Cascheta,
                            Costum_Camuflaj = b.Costum_Camuflaj,
                            Costum_Tercot = b.Costum_Tercot,
                            Costum_Camgarn = b.Costum_Camgarn,
                            Camasa_Alba = b.Camasa_Alba,
                            Camasa_Arma = b.Camasa_Arma,
                            Camasa_Camuflaj = b.Camasa_Camuflaj,
                            Boneta = b.Boneta,
                            Fular = b.Fular,
                            Pantofi =b.Pantofi,
                            Ghete = b.Ghete,
                            Ecuson_Nominal= b.Ecuson_Nominal,
                            Ecuson_Romania = b.Ecuson_Romania,
                            Cuc = b.Cuc,
                            Cravata = b.Cravata,
                            Scurta_Oras =b.Scurta_Oras,
                            Scurta_Camuflat = b.Scurta_Camuflat
                        };
            return query;
        }

        public static void insert_ArticoleVest(int id_stud, int id_admin, DateTime data, int bocanci,
                                                int capela, int cascheta, int costCamuflaj, int costTercot,
                                                int costCamgarn, int camasaAlba, int camasaArma, int camasaCamo,
                                                int boneta, int fular, int pantofi, int ghete, int nominal, int romania,
                                                int cuc, int cravata, int scurtaO, int scurtaC)
        {
            var bd = new DataLayer.Models.ProiectBDContext();

            ArticoleVest art = new ArticoleVest
            {
                ID_Student = id_stud,
                ID_Administrator = id_admin,
                Data_Alocarii = data,
                Bocanci =bocanci,
                Capela = capela,
                Cascheta = cascheta,
                Costum_Camuflaj = costCamuflaj,
                Costum_Tercot = costTercot,
                Costum_Camgarn = costCamgarn,
                Camasa_Alba = camasaAlba,
                Camasa_Camuflaj = camasaCamo,
                Camasa_Arma =camasaArma,
                Boneta = boneta,
                Fular = fular,
                Pantofi = pantofi,
                Ghete = ghete,
                Ecuson_Nominal = nominal,
                Ecuson_Romania = romania,
                Cuc = cuc,
                Cravata = cravata,
                Scurta_Oras = scurtaO,
                Scurta_Camuflat = scurtaC
            };

            bd.ArticoleVests.Add(art);
            bd.Entry(art).State = System.Data.Entity.EntityState.Added;
            bd.SaveChanges();
        }
    }
}
