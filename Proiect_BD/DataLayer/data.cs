using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace DataLayer
{
    public class AlocariTotale
    {
        public Nullable<int> ID_Student { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public double Masa { get; set; }
        public double Savoniera { get; set; }
        public double Sapun { get; set; }
        public double Spuma_ras { get; set; }
        public double Aparat_ras { get; set; }
        public double Caiete { get; set; }
        public double Rigla { get; set; }
        public double Guma { get; set; }
        public double Crema { get; set; }
        public double Maieu { get; set; }
        public double Agrafe { get; set; }
        public double Capse { get; set; }
        public double Bocanci { get; set; }
        public double Capela { get; set; }
        public double Cascheta { get; set; }
        public double Costum_Camuflaj { get; set; }
        public double Costum_Tercot { get; set; }
        public double Costum_Camgarn { get; set; }
        public double Camasa_Alba { get; set; }
        public double Camasa_Arma { get; set; }
        public double Camasa_Camuflaj { get; set; }
        public double Boneta { get; set; }
        public double Fular { get; set; }
        public double Pantofi { get; set; }
        public double Ghete { get; set; }
        public double Ecuson_Nominal { get; set; }
        public double Ecuson_Romania { get; set; }
        public double Cuc { get; set; }
        public double Cravata { get; set; }
        public double Scurta_Oras { get; set; }
        public double Scurta_Camuflat { get; set; }

        public AlocariTotale()
        {
            Masa = 0;
            Savoniera = 0;
            Sapun = 0;
            Spuma_ras = 0;
            Aparat_ras = 0;
            Caiete = 0;
            Rigla = 0;
            Guma = 0;
            Crema = 0;
            Maieu = 0;
            Agrafe = 0;
            Capse = 0;
            Bocanci = 0;
            Capela = 0;
            Cascheta = 0;
            Costum_Camuflaj = 0;
            Costum_Tercot = 0;
            Costum_Camgarn = 0;
            Camasa_Alba = 0;
            Camasa_Arma = 0;
            Camasa_Camuflaj = 0;
            Boneta = 0;
            Fular = 0;
            Pantofi = 0;
            Ghete = 0;
            Ecuson_Nominal = 0;
            Ecuson_Romania = 0;
            Cuc = 0;
            Cravata = 0;
            Scurta_Oras = 0;
            Scurta_Camuflat = 0;
        }

    }
    public class clsDataLayer
    {
        public static List<AlocariTotale> total(int id)
        {
            var bd = new DataLayer.Models.ProiectBDContext();
            AlocariTotale aloc = new AlocariTotale();
            AlocariTotale suma = new AlocariTotale();
            double sumaTotala = 0;

            var query = from b in bd.Students
                        where b.ID_Student == id
                        select b;
            var query2 = from p in bd.Preturis
                         select p;

            var x = query.ToList();
            var y = query2.ToList();

            aloc.ID_Student = x[0].ID_Student;
            aloc.Nume = x[0].Nume;
            aloc.Prenume = x[0].Prenume;

            foreach (var i in x[0].AlocareHranas)
            {
                aloc.Masa += i.Counter;
                foreach (var j in y)
                    if (j.ID_Pret == i.ID_Pret)
                    {
                        suma.Masa += i.Counter * j.Pret; break;
                        
                    }
            }
            

            foreach (var i in x[0].ArticoleDrepturis)
            {
                aloc.Savoniera += i.Savoniera == null ? default(int) : (double)i.Savoniera;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Savoniera"))
                    { suma.Savoniera += i.Savoniera == null ? default(int) : (double)i.Savoniera * j.Pret; break; }

                aloc.Sapun += i.Sapun == null ? default(int) : (double)i.Sapun;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Sapun"))
                    { suma.Sapun += i.Sapun == null ? default(int) : (double)i.Sapun * j.Pret; break; }
                
                aloc.Spuma_ras += i.Spuma_ras == null ? default(int) : (double)i.Spuma_ras;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Spuma_ras"))
                    { suma.Spuma_ras += i.Spuma_ras == null ? default(int) : (double)i.Spuma_ras * j.Pret; break; }
                
                aloc.Aparat_ras += i.Aparat_ras == null ? default(int) : (double)i.Aparat_ras;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Aparat_ras"))
                    { suma.Aparat_ras += i.Aparat_ras == null ? default(int) : (double)i.Aparat_ras * j.Pret; break; }
                
                aloc.Caiete += i.Caiete == null ? default(int) : (double)i.Caiete;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Caiete"))
                    { suma.Caiete += i.Caiete == null ? default(int) : (double)i.Caiete * j.Pret; break; }
               
                aloc.Rigla += i.Rigla == null ? default(int) : (double)i.Rigla;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Rigla"))
                    { suma.Rigla += i.Rigla == null ? default(int) : (double)i.Rigla * j.Pret; break; }
                
                aloc.Guma += i.Guma == null ? default(int) : (double)i.Guma;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Guma"))
                    { suma.Guma += i.Guma == null ? default(int) : (double)i.Guma * j.Pret; break; }
                
                aloc.Crema += i.Crema == null ? default(int) : (double)i.Crema;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Crema"))
                    { suma.Crema += i.Crema == null ? default(int) : (double)i.Crema * j.Pret; break; }
                
                aloc.Maieu += i.Maieu == null ? default(int) : (double)i.Maieu;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Maieu"))
                    { suma.Maieu += i.Maieu == null ? default(int) : (double)i.Maieu * j.Pret; break; }
                
                aloc.Agrafe += i.Agrafe == null ? default(int) : (double)i.Agrafe;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Agrafe"))
                    { suma.Agrafe += i.Agrafe == null ? default(int) : (double)i.Agrafe * j.Pret; break; }
                
                aloc.Capse += i.Capse == null ? default(int) : (double)i.Capse;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Capse"))
                    { suma.Capse += i.Capse == null ? default(int) : (double)i.Capse * j.Pret; break; }
                
            }
            foreach (var i in x[0].ArticoleVests)
            {
                aloc.Bocanci += i.Bocanci == null ? default(int) : (double)i.Bocanci;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Bocanci"))
                    { suma.Bocanci += i.Bocanci == null ? default(int) : (double)i.Bocanci * j.Pret; break; }
                
                aloc.Capela += i.Capela == null ? default(int) : (double)i.Capela;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Capela"))
                    { suma.Capela += i.Capela == null ? default(int) : (double)i.Capela * j.Pret; break; }
                
                aloc.Cascheta += i.Cascheta == null ? default(int) : (double)i.Cascheta;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Cascheta"))
                    { suma.Cascheta += i.Cascheta == null ? default(int) : (double)i.Cascheta * j.Pret; break; }
                
                aloc.Costum_Camuflaj += i.Costum_Camuflaj == null ? default(int) : (double)i.Costum_Camuflaj;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Costum_Camuflaj"))
                    { suma.Costum_Camuflaj += i.Costum_Camuflaj == null ? default(int) : (double)i.Costum_Camuflaj * j.Pret; break; }
                
                aloc.Costum_Tercot += i.Costum_Tercot == null ? default(int) : (double)i.Costum_Tercot;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Costum_Tercot"))
                    { suma.Costum_Tercot += i.Costum_Tercot == null ? default(int) : (double)i.Costum_Tercot * j.Pret; break; }
                
                aloc.Costum_Camgarn += i.Costum_Camgarn == null ? default(int) : (double)i.Costum_Camgarn;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Costum_Camgarn"))
                    { suma.Costum_Camgarn += i.Costum_Camgarn == null ? default(int) : (double)i.Costum_Camgarn * j.Pret; break; }
                
                aloc.Camasa_Alba += i.Camasa_Alba == null ? default(int) : (double)i.Camasa_Alba;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Camasa_Alba"))
                    { suma.Camasa_Alba += i.Camasa_Alba == null ? default(int) : (double)i.Camasa_Alba * j.Pret; break; }
                
                aloc.Camasa_Arma += i.Camasa_Arma == null ? default(int) : (double)i.Camasa_Arma;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Camasa_Arma"))
                    { suma.Camasa_Arma += i.Camasa_Arma == null ? default(int) : (double)i.Camasa_Arma * j.Pret; break; }
                
                aloc.Camasa_Camuflaj += i.Camasa_Camuflaj == null ? default(int) : (double)i.Camasa_Camuflaj;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Camasa_Camuflaj"))
                    { suma.Camasa_Camuflaj += i.Camasa_Camuflaj == null ? default(int) : (double)i.Camasa_Camuflaj * j.Pret; break; }
                
                aloc.Boneta += i.Boneta == null ? default(int) : (double)i.Boneta;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Boneta"))
                    { suma.Boneta += i.Boneta == null ? default(int) : (double)i.Boneta * j.Pret; break; }
                
                aloc.Fular += i.Fular == null ? default(int) : (double)i.Fular;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Fular"))
                    { suma.Fular += i.Fular == null ? default(int) : (double)i.Fular * j.Pret; break; }
                
                aloc.Pantofi += i.Pantofi == null ? default(int) : (double)i.Pantofi;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Pantofi"))
                    { suma.Pantofi += i.Pantofi == null ? default(int) : (double)i.Pantofi * j.Pret; break; }
                
                aloc.Ghete += i.Ghete == null ? default(int) : (double)i.Ghete;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Ghete"))
                    { suma.Ghete += i.Ghete == null ? default(int) : (double)i.Ghete * j.Pret; break; }
                
                aloc.Ecuson_Nominal += i.Ecuson_Nominal == null ? default(int) : (double)i.Ecuson_Nominal;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Ecuson_Nominal"))
                    { suma.Ecuson_Nominal += i.Ecuson_Nominal == null ? default(int) : (double)i.Ecuson_Nominal * j.Pret; break; }
                
                aloc.Ecuson_Romania += i.Ecuson_Romania == null ? default(int) : (double)i.Ecuson_Romania;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Ecuson_Romania"))
                    { suma.Ecuson_Romania += i.Ecuson_Romania == null ? default(int) : (double)i.Ecuson_Romania * j.Pret; break; }
                
                aloc.Cuc += i.Cuc == null ? default(int) : (double)i.Cuc;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Cuc"))
                    { suma.Cuc += i.Cuc == null ? default(int) : (double)i.Cuc * j.Pret; break; }
                
                aloc.Cravata += i.Cravata == null ? default(int) : (double)i.Cravata;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Cravata"))
                    { suma.Cravata += i.Cravata == null ? default(int) : (double)i.Cravata * j.Pret; break; }
                
                aloc.Scurta_Oras += i.Scurta_Oras == null ? default(int) : (double)i.Scurta_Oras;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Scurta_Oras"))
                    { suma.Scurta_Oras += i.Scurta_Oras == null ? default(int) : (double)i.Scurta_Oras * j.Pret; break; }
                
                aloc.Scurta_Camuflat += i.Scurta_Camuflat == null ? default(int) : (double)i.Scurta_Camuflat;
                foreach (var j in y)
                    if (j.Data <= i.Data_Alocarii && j.Nume.Contains("Scurta_Camuflat"))
                    { suma.Scurta_Camuflat += i.Scurta_Camuflat == null ? default(int) : (double)i.Scurta_Camuflat * j.Pret; break; }
            }

            sumaTotala += suma.Masa;
            sumaTotala += suma.Savoniera;
            sumaTotala += suma.Sapun;
            sumaTotala += suma.Spuma_ras;
            sumaTotala += suma.Aparat_ras;
            sumaTotala += suma.Caiete;
            sumaTotala += suma.Rigla;
            sumaTotala += suma.Guma;
            sumaTotala += suma.Crema;
            sumaTotala += suma.Maieu;
            sumaTotala += suma.Agrafe;
            sumaTotala += suma.Capse;
            sumaTotala += suma.Bocanci;
            sumaTotala += suma.Capela;
            sumaTotala += suma.Cascheta;
            sumaTotala += suma.Costum_Camuflaj;
            sumaTotala += suma.Costum_Tercot;
            sumaTotala += suma.Costum_Camgarn;
            sumaTotala += suma.Camasa_Alba;
            sumaTotala += suma.Camasa_Arma;
            sumaTotala += suma.Camasa_Camuflaj;
            sumaTotala += suma.Boneta;
            sumaTotala += suma.Fular;
            sumaTotala += suma.Pantofi;
            sumaTotala += suma.Ghete;
            sumaTotala += suma.Ecuson_Nominal;
            sumaTotala += suma.Ecuson_Romania;
            sumaTotala += suma.Cuc;
            sumaTotala += suma.Cravata;
            sumaTotala += suma.Scurta_Oras;
            sumaTotala += suma.Scurta_Camuflat;

            suma.Nume = "PRETURI";
            suma.Prenume = "Suma Totala= " + sumaTotala.ToString();

            List < AlocariTotale > list = new List<AlocariTotale>();
            list.Add(aloc);
            list.Add(suma);
            return list;
        }
    }
}
