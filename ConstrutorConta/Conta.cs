using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;
        private static int contador;
        public static int Contador{//propriedade
            get{
                return contador;
            }
        }
        public Conta() //construtor padrão
        {   //não tem parâmetro e é concedido
            //de forma automática à você
            contador ++;
        }
        
        public Conta(int numero)
        { //  atributo = parâmetro
            this.numero = numero;
            contador ++;
        }
        
        public Conta(string? titular, double saldo)
        { //  atributo = parâmetro
            this.titular = titular;
            this.saldo = saldo;
            contador ++;
        }
        public void MostrarAtributos(){
            Console.WriteLine("Número: "+ numero +
                        " Titular: " + titular +
                        "Saldo: " + saldo);
        } //fecha o método
    }// fecha a classe
}//fecha da namespace