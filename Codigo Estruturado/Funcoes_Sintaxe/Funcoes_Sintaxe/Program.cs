using System;

namespace Funcoes_Sintaxe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double result = Maior(n1,n2, n3);
            Console.WriteLine("Maior = "+result);

        }

        static int Maior (int n1, int n2, int n3)
        {
            int m;

            if (n1 > n2 && n1>n3) {
            m = (int)n1;
            }
            else if(n2> n3) { 
                m = (int)n2;
            }
            else
            {
                m = (int)n3;
            }
            return m;
        }
    }
}
