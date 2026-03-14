// See https://aka.ms/new-console-template for more information
using Array;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {

        Conta[] vetConta = new Conta[3];
        for(int i = 0; i < vetConta.Length; i++){

            //instância de cada índice
            vetConta[i]= new Conta();
            Console.WriteLine("Digite o número: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o titular:");
            vetConta[i].titular = Console.ReadLine();
            Console.WriteLine("Digite o saldo: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
        }
        //Some todos os saldos 
        // e mostre

        foreach (Conta i in vetConta)
        {
            
        }
    }
}
