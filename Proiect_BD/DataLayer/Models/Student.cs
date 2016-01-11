using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
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
    }
}
