using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas
{
    public class ItemVenda
    {
        private int quantidade;

        private double preco;

        private double subtotal;

        private Produto produto;

        public Produto _Produto
        {
            get
            {
                return produto;
            }
            set
            {
                produto = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value;
                CalcularSubtotal();
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }
            set
            {
                preco = value;
                CalcularSubtotal();
            }
        }

        public double Subtotal
        {
            get 
            { 
                return subtotal; 
            }
        }

        public ItemVenda(Produto produto, int quantidade)
        {
            this.produto = produto;
            this.quantidade = quantidade;

            this.preco = produto.Preco;

            CalcularSubtotal();
        }
        
        private void CalcularSubtotal()
        {
            this.subtotal = this.quantidade * this.preco;
        }

    }
}