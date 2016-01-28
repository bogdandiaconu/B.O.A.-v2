using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer.Models
{
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
        public static IQueryable<Models.ArticoleDrepturi> get_ArticoleDrepturi()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.ArticoleDrepturis
                        select b;
            return query;
        }
    }
}
