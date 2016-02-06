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
        public static IQueryable<DataLayer.Models.newAdministratori> get_Administratori()
        {
            return DataLayer.Models.Administratori.get_Administratori();
        }
        public static bool insert_Administratori(string nume, string prenume, int grad)
        {
            if (DataLayer.Models.Grade.Exists(grad))
            {
                DataLayer.Models.Administratori.insert_Administratori(nume, prenume, grad);
                return true;
            }
            return false;
        }
        public static void delete_Administratori(int id)
        {
            DataLayer.Models.Administratori.delete_Administratori(id);
        }
        public static bool update_Administratori(int id, string nume, string prenume, int grad)
        {
            if (DataLayer.Models.Grade.Exists(grad))
            {
                DataLayer.Models.Administratori.update_Administratori(id,nume, prenume, grad);
                return true;
            }
            return false;
        }
    }
    public class clsBusiness_get_AlocareHrana
    {
        public static IQueryable<DataLayer.Models.newAlocareHrana> get_AlocareHrana()
        {
            return DataLayer.Models.AlocareHrana.get_AlocareHrana();
        }
        public static bool insert_AlocareHrana(int student, int pret, int admin, int counter)
        {

            if (DataLayer.Models.Student.Exists(student) && (DataLayer.Models.Preturi.Exists(pret)) && (DataLayer.Models.Administratori.Exists(admin)))
            {
                if (DataLayer.Models.AlocareHrana.Exists(student, pret))
                {
                    DataLayer.Models.AlocareHrana.increment_AlocareHrana(student, pret, counter);
                    return true;
                }
                DataLayer.Models.AlocareHrana.insert_AlocareHrana(student, pret, admin, counter);
                return true;
            }
            return false;
            
        }
        public static void delete_AlocareHrana(int student, int pret)
        {
            DataLayer.Models.AlocareHrana.delete_AlocareHrana(student,pret);
        }
        public static bool update_AlocareHrana(int student, int pret, int admin, int counter)
        {
            if (DataLayer.Models.Student.Exists(student) && (DataLayer.Models.Preturi.Exists(pret)) && (DataLayer.Models.Administratori.Exists(admin)))
            {
                DataLayer.Models.AlocareHrana.update_AlocareHrana(student, pret, admin, counter);
                return true;
            }
            return false;
            
        }
    }
    public class clsBusiness_get_Articole_Drepturi
    {
        public static IQueryable<DataLayer.Models.newArticoleDrepturi> get_Articole_Drepturi()
        {
            return DataLayer.Models.ArticoleDrepturi.get_ArticoleDrepturi();
        }
        public static bool insert_ArticoleDrepturi(int id_stud, int id_admin, DateTime data, int savoniera,
                                                    int sapun, int spuma, int aparat, int caiete, int rigla,
                                                    int guma, int crema, int maieu, int agrafe, int capse)
        {
            if (DataLayer.Models.Student.Exists(id_stud) && (DataLayer.Models.Administratori.Exists(id_admin)))
            {
                DataLayer.Models.ArticoleDrepturi.insert_ArticoleDrepturi(id_stud, id_admin, data, savoniera, sapun, spuma, aparat, caiete, rigla, guma, crema, maieu, agrafe, capse);
                return true;
            }
                return false;
        }
    }
    public class clsBusiness_get_ArticoleVest
    {
        public static IQueryable<DataLayer.Models.newArticoleVest> get_ArticoleVest()
        {
            return DataLayer.Models.ArticoleVest.get_ArticoleVest();
        }
        public static bool insert_ArticoleVest(int id_stud, int id_admin, DateTime data, int bocanci,
                                                int capela, int cascheta, int costCamuflaj, int costTercot,
                                                int costCamgarn, int camasaAlba, int camasaArma, int camasaCamo,
                                                int boneta, int fular, int pantofi, int ghete, int nominal, int romania,
                                                int cuc, int cravata, int scurtaO, int scurtaC)
        {
            if (DataLayer.Models.Student.Exists(id_stud) && (DataLayer.Models.Administratori.Exists(id_admin)))
            {
                DataLayer.Models.ArticoleVest.insert_ArticoleVest(id_stud, id_admin, data, bocanci, capela, cascheta, costCamuflaj, costTercot, costCamgarn, camasaAlba, camasaArma, camasaCamo, boneta, fular, pantofi, ghete, nominal, romania, cuc, cravata, scurtaO, scurtaC);
                return true;
            }
            return false;
        }
    }
    public class clsBusiness_get_CDT_Comp
    {
        public static IQueryable<DataLayer.Models.newCDT_Comp> get_CDT_Comp()
        {
            return DataLayer.Models.CDT_Comp.get_CDT_comp();
        }
        public static bool insert_CDT_Comp(string nume, string prenume, int grad)
        {
            if (DataLayer.Models.Grade.Exists(grad))
            {
                DataLayer.Models.CDT_Comp.insert_CDT_Comp(nume, prenume, grad);
                return true;
            }
            return false;
        }
        public static void delete_CDT_Comp(int id)
        {
            DataLayer.Models.CDT_Comp.delete_CDT_Comp(id);
        }
        public static bool update_CDT_Comp(int id, string nume, string prenume, int grad)
        {
            if (DataLayer.Models.Grade.Exists(grad))
            {
                DataLayer.Models.CDT_Comp.update_CDT_Comp(id, nume, prenume, grad);
                return true;
            }
            return false;
            
        }
    }
    public class clsBusiness_get_Companie
    {
        public static IQueryable<DataLayer.Models.newCompanie> get_Companie()
        {
            return DataLayer.Models.Companie.get_Companie();
        }
        public static bool insert_Companie(string nume, int com, int admin)
        {
            if((DataLayer.Models.Administratori.Exists(admin))&&(DataLayer.Models.CDT_Comp.Exists(com)))
            {
                DataLayer.Models.Companie.insert_Companie(nume, com, admin);
                return true;
            }
            return false;
        }
        public static void delete_Companie(int id)
        {
            DataLayer.Models.Companie.delete_Companie(id);
        }
        public static bool update_Companie(int id, string nume, int com, int admin)
        {
            if (DataLayer.Models.Administratori.Exists(admin)&&(DataLayer.Models.CDT_Comp.Exists(com)))
            {
                DataLayer.Models.Companie.update_Companie(id, nume, com, admin);
                return true;
            }
            return false;
            
        }
    }
    public class clsBusiness_get_Grade
    {
        public static IQueryable<DataLayer.Models.Grade> get_Grade()
        {
            return DataLayer.Models.Grade.get_Grade();
        }
        public static bool insert_Grade(string grad)
        {
                DataLayer.Models.Grade.insert_Grade(grad);
                return true;
        }
        public static bool delete_Grade(int id)
        {
            if(DataLayer.Models.Grade.Exists(id))
            {
                DataLayer.Models.Grade.delete_Grade(id);
                return true;
            }
            return false;
        }
    }
    public class clsBusiness_get_Preturi
    {
        public static IQueryable<DataLayer.Models.Preturi> get_Preturi()
        {
            return DataLayer.Models.Preturi.get_Preturi();
        }
        public static void insert_Preturi(string nume, double pret, DateTime data)
        {
            DataLayer.Models.Preturi.insert_Preturi(nume, pret, data);
        }
        public static bool update_Preturi(int id, string nume, double pret, DateTime data)
        {
            if (DataLayer.Models.Preturi.Exists(id))
            {
                DataLayer.Models.Preturi.update_Preturi(id, nume, pret, data);
                return true;
            }
            return false;
        }
        public static bool delete_Preturi(int id)
        {
            if(DataLayer.Models.Preturi.Exists(id))
            {
                DataLayer.Models.Preturi.delete_Preturi(id);
                return true;
            }
            return false;
        }
   }
    public class clsBusiness_get_Student
    {
        public static IQueryable<DataLayer.Models.newStudent> get_Student()
        {
            return DataLayer.Models.Student.get_Student();
        }
        public static bool insert_Student(string nume, string prenume, int grad, string cnp, string adresa, int comp)
        {
            if(DataLayer.Models.Companie.Exists(comp))
            {
                DataLayer.Models.Student.insert_Student(nume, prenume, grad, cnp, adresa, comp);
                return true;
            }
            return false;
        }
        public static bool update_Student(int id, string nume, string prenume, int grad, string cnp, string adresa, int comp)
        {
            if((DataLayer.Models.Student.Exists(id))&&(DataLayer.Models.Companie.Exists(comp))&&DataLayer.Models.Grade.Exists(grad))
            {
                DataLayer.Models.Student.update_Student(id, nume, prenume, grad, cnp, adresa, comp);
                return true;
            }
            return false;
        }
        public static bool delete_Student(int id)
        {
            if(DataLayer.Models.Student.Exists(id))
            {
                DataLayer.Models.Student.delete_Student(id);
                return true;

            }
            return false;
        }
    }
    
    public class clsBusiness_queries
    {
        public static List<DataLayer.AlocariTotale> get_Total(int id)
        {
            if(DataLayer.Models.Student.Exists(id))
            {
                return DataLayer.clsDataLayer.total(id);
            }
            return new List<DataLayer.AlocariTotale>();
        }
        public static IQueryable<DataLayer.Models.newCDT_Comp> get_CDT_comp_by_compname(string name)
        {
            return DataLayer.clsDataLayer.get_CDT_comp_by_compname(name);
        }
        public static IQueryable<SumarCompanie> get_sumar_comp_by_name(string name)
        {
            return DataLayer.clsDataLayer.get_sumar_comp_by_name(name);
        }
        public static IQueryable<DataLayer.Models.newStudent> Get_Student_by_comp(string nume)
        {
            return DataLayer.Models.Student.Get_Student_by_comp(nume);
        }
   }
}
