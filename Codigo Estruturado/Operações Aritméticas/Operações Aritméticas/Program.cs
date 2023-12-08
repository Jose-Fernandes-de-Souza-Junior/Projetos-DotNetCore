using System;
using System.Threading.Channels;

namespace Operações_Aritmeticas{
    class Program {
        static void Main(string[] args)
        {   //Calculo formula de Bhascara

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (double)(-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (double)(-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);

        }

        }  

    }