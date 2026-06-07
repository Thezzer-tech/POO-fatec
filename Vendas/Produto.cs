using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas
{
    public class Produto
    {
        private long codigo; 

        private string? nome;

        private double preco;

        private int estoque;

        public long Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
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
            }
        }

        public string? Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public int Estoque
        {
            get
            {
                return estoque;
            }
            set
            {
                estoque = value;
            }
        }

        public Produto()
        {
            
        }

        public Produto(long codigo, string nome, double preco, int estoqueInicial)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.preco = preco;
            this.estoque = estoqueInicial;
        }

        public bool BaixarEstoque(int quantidadeVendida)
        {
            if(this.estoque >= quantidadeVendida)
            {
                this.estoque -= quantidadeVendida;
                return true;
            }
            else
            {
                Console.WriteLine($"Aviso, Estoque insuficiente do produto {this.nome}!");
                return false;
            }
        }

    }
}