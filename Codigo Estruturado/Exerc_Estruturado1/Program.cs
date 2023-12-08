using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Idade: ");
            int idade2 = int.Parse(Console.ReadLine());

            if (idade1 > idade2)
            {
                Console.Write("Pessoa mais velha é: " + nome1);
            }

            else
            {
                Console.Write("Pessoa mais velha é: " + nome2);
            }
        }
    }
}