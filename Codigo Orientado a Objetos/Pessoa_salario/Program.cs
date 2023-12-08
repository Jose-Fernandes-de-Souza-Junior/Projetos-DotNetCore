using System;
using System.Globalization;
using System.Runtime.CompilerServices;

/* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.*/

namespace Pessoa_salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa nome1, salario1,nome2,salario2;

            nome1 = new Pessoa();
            salario1 = new Pessoa();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            nome1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nome2 = new Pessoa();
            salario2 = new Pessoa();

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            nome2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            salario2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario_medio = (salario1.salario + salario2.salario) / 2.0;
            Console.WriteLine("Salário Medio = " + salario_medio);

        }
    }
}
