using System;
using System.Collections.Generic;

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
    }
}
