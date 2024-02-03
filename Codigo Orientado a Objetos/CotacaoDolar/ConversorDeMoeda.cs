using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static double dolar;
        public static double real;

        static public double Converter(){
            double valor = real * dolar;
            
            return valor+(valor*0.06);
            
        }
    }
}
