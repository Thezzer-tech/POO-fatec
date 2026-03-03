using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //instância de objeto
        Conta c1 = new Conta();
        c1.numero = 1;
        c1.titular = "Fatec";
        c1.saldo = 100;
        c1.MostrarAtributos();
        c1.Sacar(30);
        c1.MostrarAtributos();
        Conta c2 = new Conta();
        c2.MostrarAtributos();
        c2.Depositar(500);
        c2.MostrarAtributos();
        Console.Write("Digite o número da conta: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o titular da conta: ");
        c2.titular = Console.ReadLine();
        c2.MostrarAtributos();
    }
}