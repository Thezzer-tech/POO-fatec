using agregacaoVendedor;

internal class Program
{
    private static void Main(string[] args)
    {
        Comprador c = new Comprador(20000);
        Vendedor v = new Vendedor();

        int codigoGerador = 501;

        Produto p1 = new Produto(codigoGerador++,"Computador", 3000);
        Produto p2 = new Produto(codigoGerador++,"Moto usada", 8000);
        Produto p3 = new Produto(codigoGerador++,"Fone", 1000);

        Venda venda1 = new Venda(c, v);
        venda1.AdicionarProduto(p1);
        venda1.AdicionarProduto(p2);
        venda1.RealizarVenda();

        Venda venda2 = new Venda(c, v);
        venda2.AdicionarProduto(p3);
        venda2.RealizarVenda();

        venda1.MostrarAtributos();
        venda2.MostrarAtributos();

        c.MostrarAtributos();
        v.MostrarAtributos();
    }
}
