using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BussinessLayer
{
    public class clsBusinessLayer
    {
        public static IQueryable<DataLayer.Models.Administratori> get_Administratori()
        {
            return DataLayer.Models.Administratori.get_Administratori();
        }
    }
}
