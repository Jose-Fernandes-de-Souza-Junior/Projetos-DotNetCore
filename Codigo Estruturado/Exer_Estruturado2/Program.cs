using System;
using System.Globalization;
using System.Runtime.CompilerServices;

/* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.*/

namespace Exerc_Estruturado2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Salário: ");
            double salario1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Salário: ");
           double salario2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double salario_medio = (salario1 + salario2) / 2.0;
            Console.WriteLine("Salário Medio = " + salario_medio);

        }
    }
}