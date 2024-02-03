using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueEncapsulado
{
    internal class Produto
    {
        private string _nome;
        public double Preco { get; private set; } //Auto Properties para proibir o Preço e a Quantidade de serem alterados em outros arquivos
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {                //Propertie para controlar o acesso ao atributo nome em outros arquivos
            get { return _nome;} 

            set { if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        } 
         

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome + ", R$ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + " unidades, Total: R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}



