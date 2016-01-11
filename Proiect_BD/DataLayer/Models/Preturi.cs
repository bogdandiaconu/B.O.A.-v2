using System;
using System.Collections.Generic;

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
    }
}
