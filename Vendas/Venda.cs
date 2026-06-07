using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas
{
    public class Venda
    {
        private DateTime data;

        private double total;

        private List <ItemVenda> itens;

        private Pagamento pagamento;


        public DateTime Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public Pagamento _Pagamento
        {
            get
            {
                return pagamento;
            }

            set
            {
                pagamento = value;
            }
        }

        public double Total
        {
            get
            {
                return total;
            }
        }


        public Venda()
        {
            this.data = DateTime.Now;

            this.itens = new List<ItemVenda>();

            this.total = 0.0;
        }

        public void AdicionarItem(ItemVenda item)
        {
            this.itens.Add(item);

            CalcularTotal();
        }

        private void CalcularTotal()
        {
            double soma = 0;
            int quantidadeTotalProdutos = 0;

            foreach (var item in itens)
            {
                soma += item.Subtotal;
                quantidadeTotalProdutos += item.Quantidade;
            }

            if (quantidadeTotalProdutos >= 50)
            {
                double desconto = soma * 0.20;
                soma = soma - desconto;
                Console.WriteLine($"-> Desconto de 20% aplicado! Valor descontado: R$ {desconto:F2}");
            }

            this.total = soma;
        }

    }
}