using System;

namespace Condicoes
{
    class Program
    {
        static void Main(string[] args)

        {

            int horas = int.Parse(Console.ReadLine());

            if (horas <12) {

                Console.WriteLine(horas);
                Console.WriteLine("Bom dia!");
            }

            else if (horas >=12 && horas <18)
            {
                Console.WriteLine(horas);
                Console.WriteLine("Boa tarde!");
            }

            else if (horas>=18 && horas<=24) {

                Console.WriteLine(horas);
                Console.WriteLine("Boa noite!");

            }
            

        }
    }
}
