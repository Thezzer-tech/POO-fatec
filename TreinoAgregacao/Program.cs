using TreinoAgregacao;

internal class Program
{
    private static void Main(string[] args)
    {
        Cartao cdc = new Cartao();

        Cliente c = new Cliente();

        c.Nome = "Rodrigo";
        c.Cpf = 14242424;

        cdc.Numero = 12123213;
        cdc.Data = "22/09/2030";

        cdc.Cliente = c;
    } 
}
