using Estoque;
using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do Produto.");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.Write("Digite a quantidade de produtos a ser adicionada em estoque: ");
            int qtde = int.Parse(Console.ReadLine());

            p.AdicionarProduto(qtde);

            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("Digite a quantidade de produtos a ser removida em estoque: ");
            qtde = int.Parse(Console.ReadLine());

            p.RemoverProduto(qtde);

            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
