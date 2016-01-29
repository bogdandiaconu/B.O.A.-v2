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
        public static void insert_Administratori(string nume, string prenume, int grad)
        {
            DataLayer.Models.Administratori.insert_Administratori(nume,prenume,grad);
        }
        public static void delete_Administratori(int id)
        {
            DataLayer.Models.Administratori.delete_Administratori(id);
        }
        public static void update_Administratori(int id, string nume, string prenume, int grad)
        {
            DataLayer.Models.Administratori.update_Administratori(id, nume, prenume, grad);
        }
    }
    public class clsBusiness_get_AlocareHrana
    {
        public static IQueryable<DataLayer.Models.AlocareHrana> get_AlocareHrana()
        {
            return DataLayer.Models.AlocareHrana.get_AlocareHrana();
        }
        public static void insert_AlocareHrana(int student, int pret, int admin, int counter)
        {
            DataLayer.Models.AlocareHrana.insert_AlocareHrana(student,pret,admin,counter);
        }
        public static void delete_AlocareHrana(int student, int pret)
        {
            DataLayer.Models.AlocareHrana.delete_AlocareHrana(student,pret);
        }
        public static void update_AlocareHrana(int student, int pret, int admin, int counter)
        {
            DataLayer.Models.AlocareHrana.update_AlocareHrana(student, pret, admin, counter);
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
        public void insert_CDT_Comp(string nume, string prenume, int grad)
        {
            DataLayer.Models.CDT_Comp.insert_CDT_Comp(nume, prenume, grad);
        }
        public static void delete_CDT_Comp(int id)
        {
            DataLayer.Models.CDT_Comp.delete_CDT_Comp(id);
        }
        public static void update_CDT_Comp(int id, string nume, string prenume, int grad)
        {
            DataLayer.Models.CDT_Comp.update_CDT_Comp(id, nume, prenume, grad);
        }
    }
    public class clsBusiness_get_Companie
    {
        public static IQueryable<DataLayer.Models.Companie> get_Companie()
        {
            return DataLayer.Models.Companie.get_Companie();
        }
        public static void insert_Companie(string nume, int com, int admin)
        {
            DataLayer.Models.Companie.insert_Companie(nume,com,admin);
        }
        public static void delete_Companie(int id)
        {
            DataLayer.Models.Companie.delete_Companie(id);
        }
        public static void update_Companie(int id, string nume, int com, int admin)
        {
            DataLayer.Models.Companie.update_Companie(id, nume, com, admin);
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
