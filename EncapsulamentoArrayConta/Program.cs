//Main()

using System.ComponentModel;
using EncapsulamentoArrayConta;

//Declaração de vetor
Conta[] vetConta = new Conta[2];

for(int i = 0; i < vetConta.Length; i++)
{
    vetConta[i] = new Conta();
    Console.WriteLine("Digite o número: ");
    vetConta[i].Numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite nome do Titular:");
    vetConta[i].Titular = Console.ReadLine();
    Console.WriteLine("Digite o saldo: ");
    vetConta[i].Saldo = Convert.ToDouble(Console.ReadLine());
}
