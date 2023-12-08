using System;
using System.Globalization;

namespace PrimeiroProjeto // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            ///char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            /*Console.WriteLine("Hello World!");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4",CultureInfo.InvariantCulture)); ///Esta função serve para printar a divisão de casas decimais com ponto
            Console.WriteLine(nome);*/

            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine("{0} tem {1} anos e R$ {2:F2} em seu saldo bancário",nome,idade,saldo);///Juntando variáveis com placeholder '{}'

            Console.WriteLine($"{nome} tem {idade} anos e R$ {saldo:F2} em seu saldo bancário");///Juntando variáveis com interpolação

            Console.WriteLine(nome + " tem " + idade + " anos  e R$ " +saldo.ToString("F2",CultureInfo.InvariantCulture)+ " em seu saldo bancário");///Juntando variáveis com concatenação




        }
    }
}