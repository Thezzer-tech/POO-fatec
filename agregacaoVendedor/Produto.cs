using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace agregacaoVendedor
{
    public class Produto
    {
        private int codigo;
        private string? nome;
        private double preco;


        public int Codigo
        {
            set
            {
                if(value >= 501){
                    this.codigo = value;
                }
                else
                {
                    Console.WriteLine("ERRO: Código inválido.");
                    this.codigo = 501;
                }
            }
            get
            {
                return this.codigo;
            }
        }

        public string? Nome
        {
            set
            {
                if(!string.IsNullOrWhiteSpace(value)){
                    this.nome = value;
                }
                else
                {
                    Console.WriteLine("ERRO: nome inválido.");
                }
            }
            get
            {
                return this.nome;
            }
        }

        public double Preco
        {
            set
            {
                if(value >= 0)
                {
                    this.preco = value; 
                }
                else
                {
                    Console.WriteLine("O preço não pode ser negativo");
                }
            }
            get
            {
                return this.preco;
            }
        }

        public Produto(int codigo, string? nome, double preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Código do produto: " + codigo + "\tNome do produto : " + nome + "\tPreço do Produto: " + preco);
        }
    
    }

    

}