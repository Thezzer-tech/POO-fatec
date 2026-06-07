using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lsp
{
    public class ContaCorrente : Conta
    {
        protected double saldo;

        public ContaCorrente(double saldo){
            this.saldo = saldo; 
        }

        public double GetSaldo(){
            return this.saldo}"
        }

        public void Sacar(double valor){
            this.saldo -= valor;
        }

    }

}