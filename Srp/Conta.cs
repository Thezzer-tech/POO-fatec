using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace Srp
{
    public class Conta
    {

        public string Titular {get; private set;}
        public decimal Saldo {get; private set;}

        public Conta(string titular)
        {
            Titular = titular;
            Saldo = 0;
        }

        public void Deposito(decimal valor)
        {

            if (valor <= 0){
                Console.WriteLine("Valor inválido!");
                return;
            }

            Saldo = Saldo + valor;
        }

        public void Sacar(decimal valor)
        {
            if(valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }
            Saldo -= valor;
        }


    }
}