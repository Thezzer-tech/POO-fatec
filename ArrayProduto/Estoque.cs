using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayProduto;
//declarar


namespace ArrayProduto{
    
    public class estoque{
        public int codigo;
            
        public string nome;
        public double precoUnitario;

        public int quantidade;

        public double total;

    }

    public void MostrarAtributos(){
        Console.WriteLine("Código: " + codigo +
        "\tNome: " + nome +
        "\tPreço unitário: " + precoUnitario +
        "\tQuantidade: " + quantidade);
    }

    public void CalcularAumentoPreco(double porcentagem){
        aumento = (precoUnitario * porcentagem)/100;
        precoUnitario = precoUnitario + aumento;
        Console.WriteLine("Valor do aumento: "+ aumento +
        "\tValor total atual: "+ precoUnitario);

    }

    public void EntradaEstoque(int entrada){
        quantidade = quantidade + entrada;
    }

    public void SaidaEstoque(int saida){
        quantidade = quantidade - saida;
    }

    public void CalcularTotal(){
        total = precoUnitario * quantidade;
    }

    public void EstoqueMin(){
        if(quantidade < 3){
            MostrarAtributos();
        }
    }
}

