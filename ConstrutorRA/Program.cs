using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;
using ConstrutorRA;

internal class Program{
    
    public static void Main(String[] args)
    {
        Conta[] c1 = new Conta[3];
        for(int i = 0; i < c1.Length; i++)
        {
            c1[i] = new Conta();
            Console.WriteLine("Digite nome:");
            c1[i].Nome = Console.ReadLine();
        }

        for(int i = 0; i < c1.Length; i++)
        {
            c1[i].MostrarAtributos();
        }
    }
}