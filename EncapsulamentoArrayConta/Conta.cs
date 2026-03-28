using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoArrayConta
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
                if(value > 0)
                    this.numero = value;
                else
                    Console.WriteLine("Número da conta nunca poderá ser negativo");
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
                this.titular = value;
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

        public void depositar(int valorDepositar){
            saldo += valorDepositar;

        }

        public void MostrarAtributos(){
            Console.WriteLine("Número: "+ numero +
                        "\tTitular: " + titular +
                        "\tSaldo: " + saldo);
        }
    }
}