using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Class1
    {
        public static IQueryable<Models.Administratori> get_Administratori()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Administratoris

                        select b;
            return query;
        }
    }
}
