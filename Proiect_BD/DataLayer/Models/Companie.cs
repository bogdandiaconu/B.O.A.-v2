using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Companie
    {
        public Companie()
        {
            this.Students = new List<Student>();
        }

        public int ID_Companie { get; set; }
        public string Nume { get; set; }
        public int ID_Comandant { get; set; }
        public int ID_Administrator { get; set; }
        public virtual Administratori Administratori { get; set; }
        public virtual CDT_Comp CDT_Comp { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
