using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceBanco
{
    public class ContaCorrente : ITributavel 
    {
        public double Saldo {get; set;}

        public ContaCorrente(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        //5% do saldo
        public double CalcularTributos()
        {
            return Saldo * 0.05;
        }
    }

}