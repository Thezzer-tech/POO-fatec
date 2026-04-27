using ComposicaoBanco;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Banco");
        Banco? meuBanco = new Banco();

        meuBanco.AbrirConta(1000, 500);
        meuBanco.AbrirPoupanca(5000);

        Console.WriteLine("Destruir Banco");
        meuBanco.DrecretarFalencia(); //zera listas

        //remove referencia do banco 
        meuBanco = null;

        //força a recolher objetos sem referencia
        GC.Collect();

        //Aguarda os destrutores agirem antes de fechar
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Fim da execução");



    }
}