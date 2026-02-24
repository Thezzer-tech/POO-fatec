using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declaração de atributos
        public int numero;
        
        public string titular;

        public double saldo;

        //declaração de funções métodos

        public void Sacar(double valorSacar){
            saldo -= valorSacar;

        }

        public void Depositar(){
            
        }

        public void MostrarAtributos(){
            Console.WriteLine("Número: "+ numero +
                        "\tTitular: " + titular +
                        "\tSaldo: " + saldo);
        }
    }
}