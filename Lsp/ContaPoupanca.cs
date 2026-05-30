using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lsp
{
    public class ContaPoupanca : IConta
    {
        protected double saldo;

        public ContaPoupanca(double saldo){
            this.saldo = saldo;
        }

        public double GetSaldo(){
            return this.saldo;
        }

        public void Sacar(double valor){
            this.saldo -= valor;
        }
    }
}