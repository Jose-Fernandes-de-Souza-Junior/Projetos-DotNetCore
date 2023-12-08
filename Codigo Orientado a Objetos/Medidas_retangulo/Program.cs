using Medidas_retangulo;
using System;
using System.Globalization;

/*Faça um programa para ler a largura e altura de um retangulo. Em seguida, mostrar na tela o valor de sua area, perímetro e diagonal.
 Use uma classe como mostrado no projeto:
Retangulo:
Atributos: Largura, Altura
Metodos: Area, Perimetro, Diagonal*/

namespace MedidaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retang = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            retang.largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            retang.altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double areaRet = retang.Area();
            double perimRet = retang.Perimetro();
            double diagRet= retang.Diagonal();

            Console.WriteLine("AREA: " + areaRet);
            Console.WriteLine("PERIMETRO: " + perimRet);
            Console.WriteLine("DIAGONAL: " + diagRet);
        } 
    }
}
