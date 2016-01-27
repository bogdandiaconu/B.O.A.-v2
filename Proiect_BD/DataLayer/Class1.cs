using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataLayer
{
    public class Class1
    {
        //public static IQueryable<Models.Administratori> get_Administratori()
        //{
        //    var bd = new DataLayer.Models.ProiectBDContext();
        //    var query = from b in bd.Administratoris
        //                join c in bd.Grades on b.ID_Grad equals c.ID_Grad
        //                where c.Nume.Equals("Plt. Maj.")
        //                select b;
        //    return query;
        //}
        public static IQueryable<Models.CDT_Comp> get_CDT_comp()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.CDT_Comp
                        select b;
            return query;
        }

    }
}
