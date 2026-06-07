using System.ComponentModel;
using Srp;

class Program
{
    public static void Main(string[] args)
    {
        Conta minhaConta = new Conta("Pedro");

        ValidarUsuario validador = new ValidarUsuario();
        GeradorRelatorio gerador = new GeradorRelatorio();

        string usuarioDig = "Pedro";

        if (validador.ValidadorUsuario(minhaConta, usuarioDig))
        {
            Console.WriteLine("Realiza deposito de 1500.10");
            minhaConta.Deposito(1500.10m);

            Console.WriteLine("Realizando saque de 300");
            minhaConta.Sacar(300.00m);

            Console.WriteLine("Tentando relizar saque de 5000");
            minhaConta.Sacar(5000.00m);

            Console.WriteLine("\n---Relatório Conta---");
            string relatorio = gerador.GerarRelatorio(minhaConta);
            Console.WriteLine(relatorio);
        }
        else
        {
            Console.WriteLine("Acesso negado!");
        }

        Console.ReadLine();

    }

}