using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Conta
    {
        private int numero;
        
        private string? titular;

        private double saldo;

        public int Numero //propriedade 
        {
            set
            {//value representa qualquer tipo 
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }

        public string? Titular{

            get
            {
                return this.titular;
            }
            set
            {
                this.Titular = value;
            }
        }

        public double Saldo{
            
            set{
                this.saldo = value;
            }
            get{
                return this.saldo;
            }
        }
         
        public void sacar(double valorSacar){
            saldo -= valorSacar;   
        }

        public void depositar(){

        }

        public void MostrarAtributos(){
            Console.WriteLine("Número: "+ numero +
                        "\tTitular: " + titular +
                        "\tSaldo: " + saldo);
        }
    }
}