// See https://aka.ms/new-console-template for more information
using Array;
using System.ComponentModel;
using System.Runtime.InteropServices;

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
        
        for (int i = 0; i < vetConta.Length; i++){
            vetConta[i].MostrarAtributos();
        }

        float soma = 0;
        foreach(Conta c in vetConta){
            c.MostrarAtributos();
            soma = soma + c.saldo;
        }
        Console.WriteLine($"Total {soma:c}");

    }
}
