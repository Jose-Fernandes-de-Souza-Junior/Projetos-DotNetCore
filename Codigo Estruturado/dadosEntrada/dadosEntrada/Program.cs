using System;
using System.Globalization;
using System.Formats;


namespace Entrada{
    public class Program
    {
        public static void Main(string[]args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3],CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura);

            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou: "+n1);

            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine("Voce digitou: " + ch);

            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);
        }
    } 
}
