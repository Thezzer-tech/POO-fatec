using agregacaoVetorConta;

internal class Program
{
    private static void Main(string[] args)
    {
        Cliente cli1 = new Cliente();
        cli1.Nome = "Ana";
        cli1.RG = 111;
        cli1.Telefone = 999;

        Cliente cli2 = new Cliente();
        cli2.Nome = "Bia";
        cli2.RG = 222;
        cli2.Telefone = 998;

        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Saldo = 10000;
        c1.VetTitular = new List<Cliente>();
        c1.VetTitular.Add(cli1);
        c1.VetTitular.Add(cli2);

        foreach(var item in c1.VetTitular){
            item.MostrarAtributos();
        }
    }
}