using Pessoa_Idade;
using System;
using System.Globalization;
using System.Security.Cryptography;

namespace Pessoa_idade
{ /* EXERCÍCIO 01:
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha */
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa nome1, idade1;
            nome1 = new Pessoa();
            idade1 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            nome1.nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade1.idade = int.Parse(Console.ReadLine());

            Pessoa nome2, idade2;
            nome2 = new Pessoa();
            idade2 = new Pessoa();

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            nome2.nome = Console.ReadLine();

            Console.Write("Idade: ");
            idade2.idade = int.Parse(Console.ReadLine());

            if (idade1.idade>idade2.idade) {
                Console.WriteLine("A pessoa mais velha é: " + nome1.nome);
            }
            else
            {
                Console.WriteLine("A pessoa mais velha é: " + nome2.nome);
            }

            
        }
       
    }
}

