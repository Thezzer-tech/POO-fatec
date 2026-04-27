using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        private double chequeEspecial;
        
        public double Saldo
        {
            set
            {
                this.saldo = value;
            }
            get
            {
                return this.saldo;
            }

        }

        public ContaCorrente(double saldoInicial, double limiteCheque)
        {
            this.saldo = saldoInicial;
            this.chequeEspecial = limiteCheque;
            Console.WriteLine("Conta Corrente criada.");

        }

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
               saldo += valor; 
            } 
            
        }

        public void Sacar(double valor)
        {
            if(valor > 0 && (saldo + chequeEspecial) >= valor)
            {
                saldo -= valor; 
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente");
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine($"Conta Corrente - Saldo : R$ {saldo:F2} | Limite : R$ {chequeEspecial:F2}");
        }

        ~ContaCorrente()
        {
            Console.WriteLine("Destruindo a Conta Corrente...");
        }
        
        
    }
}