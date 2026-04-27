using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregacaoVendedor
{
    public class Vendedor
    {
        private double comissao;



        public void CalcularComissao(double precoP)
        {

            comissao = comissao + (precoP * 0.02);
        }

        public double Comissao
        {
            set
            {
                this.comissao = value;
            }
            get
            {
                return this.comissao;
            }  

        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Valor da comissão: " + comissao);
        }

    }

}