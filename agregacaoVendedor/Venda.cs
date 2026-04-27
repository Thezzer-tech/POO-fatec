using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace agregacaoVendedor
{
    public class Venda
    {
        private Comprador compra;
        private Vendedor venda;
        private List<Produto> vetProd;

        public Venda(Comprador compra, Vendedor venda)
        {
            this.compra = compra;
            this.venda = venda;
            vetProd = new List<Produto>();
        }

        public void AdicionarProduto(Produto p)
        {
            vetProd.Add(p);
        }

        public void RealizarVenda()
        {
            double total = 0;

            foreach (var p in vetProd)
            {
                total += p.Preco;
            }

            compra.DiminuirVerba(total);
            venda.CalcularComissao(total);
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Produtos");
            foreach (var p in vetProd)
            {
                p.MostrarAtributos();
            }
        }

    }

}