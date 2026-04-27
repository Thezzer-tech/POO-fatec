using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;

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

        public Poupanca(double saldoInicial)
        {
            this.saldo = saldoInicial;
            Console.WriteLine("Poupança criada.");
        }

        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                saldo += valor;
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }

        public void Sacar(double valor)
        {
            if(valor > 0 && saldo >= valor)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente na poupança");
            }
        }

        public void GerarRendimento()
        {
            double rendimento = saldo * 0.05;
            saldo += rendimento;
            Console.WriteLine($"Rendimento aplicado! Novo saldo da poupança: {saldo:F2}");
        }

        ~Poupanca()
        {
            Console.WriteLine("Destruindo a Poupança...");
        }
    }
}