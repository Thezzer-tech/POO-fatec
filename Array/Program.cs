// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using Array;

internal class Program
{
    private static void Main(string[] args)
    {

        Conta[] vetConta = new Conta[3];
        for(int i = 0; i < vetConta.Length; i++){
            vetConta[i]= new Conta();
            Console.WriteLine("Digite o número: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o titular:");
            vetConta[i].titular = Console.ReadLine();
            Console.WriteLine("Digite o saldo: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < vetConta.Length; i++){
            vetConta[i].MostrarAtributos();
        }
        foreach(Conta c in vetConta){
            c.MostrarAtributos();
        }
    }
}
