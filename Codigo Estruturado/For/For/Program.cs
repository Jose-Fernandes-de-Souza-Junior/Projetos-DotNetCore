﻿using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Para
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero N e depois N valores inteiros. Mostrar a soma dos N valores digitados.");
            Console.Write("Quantos Valores inteiros vc vai digitar?: ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++)

            {
                Console.Write("Valor {0}: ",i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
           
            Console.WriteLine("Soma = " + soma);
        } 
    }
}