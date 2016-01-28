using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class clsBusiness_get_Administratori
    {
        public static IQueryable<DataLayer.Models.Administratori> get_Administratori()
        {
            return DataLayer.Models.Administratori.get_Administratori();
        }
    }
    public class clsBusiness_get_AlocareHrana
    {
        public static IQueryable<DataLayer.Models.AlocareHrana> get_AlocareHrana()
        {
            return DataLayer.Models.AlocareHrana.get_AlocareHrana();
        }
    }
    public class clsBusiness_get_Articole_Drepturi
    {
        public static IQueryable<DataLayer.Models.ArticoleDrepturi> get_Articole_Drepturi()
        {
            return DataLayer.Models.ArticoleDrepturi.get_ArticoleDrepturi();
        }
    }
    public class clsBusiness_get_ArticoleVest
    {
        public static IQueryable<DataLayer.Models.ArticoleVest> get_ArticoleVest()
        {
            return DataLayer.Models.ArticoleVest.get_ArticoleVest();
        }
    }
    public class clsBusiness_get_CDT_Comp
    {
        public static IQueryable<DataLayer.Models.CDT_Comp> get_CDT_Comp()
        {
            return DataLayer.Models.CDT_Comp.get_CDT_comp();
        }
    }
    public class clsBusiness_get_Companie
    {
        public static IQueryable<DataLayer.Models.Companie> get_Companie()
        {
            return DataLayer.Models.Companie.get_Companie();
        }
    }
    public class clsBusiness_get_Grade
    {
        public static IQueryable<DataLayer.Models.Grade> get_Grade()
        {
            return DataLayer.Models.Grade.get_Grade();
        }
    }
    public class clsBusiness_get_Preturi
    {
        public static IQueryable<DataLayer.Models.Preturi> get_Preturi()
        {
            return DataLayer.Models.Preturi.get_Preturi();
        }
    }
    public class clsBusiness_get_Student
    {
        public static IQueryable<DataLayer.Models.Student> get_Student()
        {
            return DataLayer.Models.Student.get_Student();
        }
    }
}
