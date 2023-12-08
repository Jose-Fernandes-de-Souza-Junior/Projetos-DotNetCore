using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medidas_retangulo
{
    internal class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            double area = largura * altura;
            return area;

        }

        public double Perimetro ()
        {
            return (largura*2) + (altura*2);
        }

        public double Diagonal()
        {
            double diagonal = (largura*largura) + (altura*altura);
            return Math.Sqrt(diagonal);
        }
    }
}
