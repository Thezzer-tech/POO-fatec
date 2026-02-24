using ClasseConta;
internal class Program{

    private static void Main(string[] args){
        Console.WriteLine("Hello, World!");
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
    }
}
