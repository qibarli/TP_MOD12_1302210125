using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MOD12_1302210125
{
    internal class CTB
    {
        public static string CariTandaBilangan(int a) { 
            if(a == 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else if (a == 0)
            {
                return "Nol";
            }
            return "Input Tidak Valid";           
        }
    }
}
