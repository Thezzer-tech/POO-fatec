using InterfaceBanco;

class Program
{
    public static void Main(string[] args)
    {
        //instanciando classes
        ContaCorrente conta = new ContaCorrente(2000);
        SeguroDeVida seguro = new SeguroDeVida();

        Console.WriteLine($"Tributo da conta corrente (5%): R$ {conta.CalcularTributos()}");
        Console.WriteLine($"Tributo do seguro de vida: R$ {seguro.CalcularTributos()}");

        TotalizadorDeTributos totalizador = new TotalizadorDeTributos();

        //adicionando ao totalizador
        totalizador.Adiciona(conta);
        totalizador.Adiciona(seguro);

        Console.WriteLine($"Total de tributos acumulados: R$ {totalizador.Total}");

    }
}
