using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;


    namespace Salario_funcionario
    {
        class Funcionario
        {
            public string nome;
            public double salario_bruto;
            public double imposto;
            

            public double Salario_Liquido()
            {
                return salario_bruto - imposto;
            }
            public void AumentoSalario(double porcentagem)
            {
                salario_bruto = salario_bruto + (salario_bruto * porcentagem / 100);

            }
            public override string ToString()
        {
                return nome + ", R$ " + Salario_Liquido().ToString("F2",CultureInfo.InvariantCulture);
        }
        }
    }

   
   
