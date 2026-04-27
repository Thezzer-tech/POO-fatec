using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private List<Poupanca>? poup;
        private List<ContaCorrente>? contas;

        public Banco()
        {
            IniciarBanco();
        }

        public void IniciarBanco()
        {
            poup = new List<Poupanca> ();
            contas = new List<ContaCorrente> ();
            Console.WriteLine("Banco Iniciado com sucesso");
        }

        public void AbrirConta(double saldoInicial, double limiteCheque)
        {
            contas.Add(new ContaCorrente(saldoInicial, limiteCheque));
        }

        public void AbrirPoupanca(double saldoInicial)
        {
            poup.Add(new Poupanca(saldoInicial));
        }

        public void DrecretarFalencia()
        {
            Console.WriteLine("Banco Decretou falência!");

            poup = null;
            contas = null;
        }

        ~Banco()
        {
            poup = null;
            contas = null;
            Console.WriteLine("Destruindo o Banco...");
        }
    }

    
}