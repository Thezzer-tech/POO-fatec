using agregacaoConta;
internal class Program{

    private static void Main(string[] args){
        Cliente cli = new Cliente();
        cli.Nome = "Ana";
        cli.RG = 212;
        cli.Telefone = 1232132;

        Conta c1 = new Conta();
        c1.Numero = 1;
        c1.Saldo = 1500;
        //titular atributo/Propriedade que quando recebe 
        //objeto cli, titular passa a ser um objeto Cliente
        // e efetiva a agregação 
        c1.Titular = cli;
        

        Conta c2 = new Conta();
        c2.Numero = 2;
        c2.Saldo = 3200;
        c2.Titular = new Cliente();
        c2.Titular.Nome = "Bia";
        c2.Titular.RG = 2321321;
        c2.Titular.Telefone = 999;

        
        

    }
}
