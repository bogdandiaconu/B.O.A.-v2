using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
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
        public static IQueryable<Models.ArticoleVest> get_ArticoleVest()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.ArticoleVests
                        select b;
            return query;
        }
    }
}
