using Salario_funcionario;
using System;
using System.Runtime.CompilerServices;
using System.Globalization;



/*Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os dados do funcionário (nome e salário líquido).
 Em seguida, aumentar o salário com base na porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do funcionario.*/

namespace Remuneracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario colab = new Funcionario();

            Console.Write("Nome: ");
            colab.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            colab.salario_bruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            colab.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + colab);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            colab.AumentoSalario(porcentagem);
            Console.Write("Dados Atualizados: " + colab);
            



        }
    }
}