using System;
    namespace Entrada_Dados
    {
        class Program
        {
            static void Main(string[] args)
            {
                string s = Console.ReadLine();
                string[] vetor = s.Split(' ');
                string a = vetor[0];
                string b = vetor[1];
                string c = vetor[2];
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
            }
        }
    }
