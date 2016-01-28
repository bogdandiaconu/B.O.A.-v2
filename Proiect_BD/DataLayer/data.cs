using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataLayer
{
    public class clsDataLayer
    {
        public static IQueryable<Models.Administratori> get_Administratori()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Administratoris
                        join c in bd.Grades on b.ID_Grad equals c.ID_Grad
                        where c.Nume.Equals("Plt. Maj.")
                        select b;
            return query;
        }
        public IQueryable<Models.CDT_Comp> get_CDT_comp()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.CDT_Comp
                        select b;
            return query;
        }
        public IQueryable<Models.ArticoleVest> get_ArticoleVest()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.ArticoleVests
                        select b;
            return query;
        }
        public IQueryable<Models.Grade> get_Grade()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Grades
                        select b;
            return query;
        }
        public IQueryable<Models.Preturi> get_Preturi()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Preturis
                        select b;
            return query;
        }
        public IQueryable<Models.AlocareHrana> get_AlocareHrana()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.AlocareHranas
                        select b;
            return query;
        }
        public IQueryable<Models.ArticoleDrepturi> get_ArticoleDrepturi()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.ArticoleDrepturis
                        select b;
            return query;
        }
        public IQueryable<Models.Companie> get_Companie()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Companies
                        select b;
            return query;
        }
        public IQueryable<Models.Student> get_Student()
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            var query = from b in bd.Students
                        select b;
            return query;
        }
    }
}
