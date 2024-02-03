/*Faça um programa para ler a cotação do dolar, e depois um valor em dolares para ser comprado por uma pessoa em reais.
 Informar quantos reais a pessoa vai pagar pelos dolares, considerando ainda que a pessoa devera pagar 6% de IOF sobre o valor do dolar.
Criar uma classe ConversorDeMoeda para ser responsavel pelos calculos.*/

using System.Globalization;

namespace CotacaoDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dolar? R$ ");
            ConversorDeMoeda.real = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantos Dolares vai comprar? $ ");
            ConversorDeMoeda.dolar = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Valor a ser pago em reais = R$ "+ ConversorDeMoeda.Converter().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

