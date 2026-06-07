using Vendas;

internal class Program
{
    static List<Produto> estoqueProdutos = new List<Produto>();
    private static void Main(String[] args)
    {
        estoqueProdutos.Add(new Produto(1, "Teclado", 150.00, 100));
        estoqueProdutos.Add(new Produto(2, "Mouse", 80.00, 100));
        estoqueProdutos.Add(new Produto(3, "Monitor", 80.00, 50));

        bool sistemaRoda = true;

        while (sistemaRoda)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA DE CAIXA ===");
            Console.WriteLine("1 - Cadastrar Novo Produto");
            Console.WriteLine("2 - Realizar Venda");
            Console.WriteLine("3 - Observar Produtos");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Escolha uma opção: ");

            int escolha = Convert.ToInt32(Console.ReadLine());

            if (escolha == 1)
            {
                CadastrarProduto();
            }
            else if (escolha == 2)
            {
                RealizarVenda();
            }
            else if (escolha == 3)
            {
                ObservarProdutos();
            }
            else if(escolha == 4)
            {
                sistemaRoda = false;
            }
            else
            {
                Console.WriteLine("Escolha inválida! Pressione enter para continuar");
                Console.ReadLine();
            }
        }

    }

    static void CadastrarProduto()
    {
        Console.Clear();
        Console.WriteLine("=== CADASTRAR PRODUTO ===");

        Produto novoProduto = new Produto();

        Console.WriteLine("Código do Produto: ");
        novoProduto.Codigo = long.Parse(Console.ReadLine());

        Console.WriteLine("Nome do Produto: ");
        novoProduto.Nome = Console.ReadLine();

        Console.WriteLine("Preço do Produto: ");
        novoProduto.Preco = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Quantidade do Produto em estoque: ");
        novoProduto.Estoque = Convert.ToInt32(Console.ReadLine());

        estoqueProdutos.Add(novoProduto);

        Console.WriteLine("Produto cadastrado com sucesso! Pressione Enter!");
        Console.ReadLine();
    }

    static void RealizarVenda()
    {   
        Console.Clear();
        Console.WriteLine("=== REALIZAR VENDA ===");

        if(estoqueProdutos.Count == 0)
        {
            Console.WriteLine("Nenhum Produto Cadastrado no sistema. Cadastre produto!");
            Console.ReadLine();
            return;
        }

        Venda novaVenda = new Venda();

        bool adicionarItens = true;

        while (adicionarItens)
        {
            Console.WriteLine("\nProdutos disponíveis: ");

            foreach (var p in estoqueProdutos)
            {
                Console.WriteLine($"[{p.Codigo}] {p.Nome} - R$ {p.Preco:F2} (Estoque: {p.Estoque})");
            }

            Console.WriteLine("\nDigite o Código do produto (ou 0 para finalizar os itens):");
            long cod = long.Parse(Console.ReadLine());

            if(cod == 0)
            {
                adicionarItens = false;
            }
            else
            {
                Produto produtoEncontrado = null;

                bool encontrouProduto = false;

                int contador = 0;

                while(contador < estoqueProdutos.Count && encontrouProduto == false)
                {
                    if (estoqueProdutos[contador].Codigo == cod)
                    {
                        produtoEncontrado = estoqueProdutos[contador];

                        encontrouProduto = true;
                    }

                    contador++;
                }


                if (produtoEncontrado != null)
                {
                    Console.WriteLine("Quantidade a vender: ");
                    int qtd = int.Parse(Console.ReadLine());

                    if (produtoEncontrado.BaixarEstoque(qtd))
                    {
                        ItemVenda item = new ItemVenda(produtoEncontrado, qtd);
                        novaVenda.AdicionarItem(item);
                        Console.WriteLine($"Item adicionado! Subtotal do item {item.Subtotal:F2}");
                    }
                }
                else
                {
                    Console.WriteLine("Erro: Produto não Encontrado!");
                }

            }
        }

        if (novaVenda.Total == 0)
        {
            Console.WriteLine("\nVenda cancelada (Nenhum item foi adicionado). Pressione Enter...");
            Console.ReadLine();
            return;
        }

        Console.WriteLine($"\n=== TOTAL DA VENDA: R$ {novaVenda.Total:F2} ===");

        Console.WriteLine("\nFormas de Pagamento:");
        Console.WriteLine("1 - Espécie (Dinheiro)");
        Console.WriteLine("2 - Cartão");
        Console.WriteLine("3 - Cheque");
        Console.WriteLine("Escolha a forma de pagamento: ");
        int formaPagamento = Convert.ToInt32(Console.ReadLine());

        Pagamento pag = null; 

        DateTime dataAtual = DateTime.Now;

        if (formaPagamento == 1)
        {
            Console.WriteLine("Valor entregue pelo cliente (R$): ");
            double valorEntregue = double.Parse(Console.ReadLine());
            
            Especie esp = new Especie(dataAtual, novaVenda.Total, valorEntregue);
            Console.WriteLine($"Troco do cliente: R$ {esp.Troco:F2}");
            pag = esp; 
        }
        else if (formaPagamento == 2)
        {
            Console.Write("Dados da Transação (ex: NSU do recibo): ");
            string dados = Console.ReadLine();
            
            pag = new Cartao(dataAtual, novaVenda.Total, dados, 1); 
        }
        else if (formaPagamento == 3)
        {
            Console.Write("Número do Cheque: ");
            long numCheque = long.Parse(Console.ReadLine());
            
            pag = new Cheque(dataAtual, novaVenda.Total, 1, numCheque, dataAtual);
        }
        else
        {
            Console.WriteLine("Opção inválida, assumindo Espécie no valor exato por padrão.");
            pag = new Especie(dataAtual, novaVenda.Total, novaVenda.Total);
        }

        novaVenda._Pagamento = pag;

        Console.WriteLine("\n>>> VENDA FINALIZADA COM SUCESSO! <<<");
        Console.WriteLine("Pressione Enter para voltar ao menu principal.");
        Console.ReadLine();
    }

    static void ObservarProdutos()
    {
        if (estoqueProdutos.Count == 0)
        {
            Console.WriteLine("Atenção: Nenhum produto cadastrado no momento.");
        }
        else
        {
            Console.WriteLine("CÓDIGO | NOME DO PRODUTO          | PREÇO (R$) | ESTOQUE");
            Console.WriteLine("--------------------------------------------------------");

            foreach (Produto p in estoqueProdutos)
            {
                Console.WriteLine($"{p.Codigo,-6} | {p.Nome,-24} | {p.Preco,-10:F2} | {p.Estoque}");
            }
        }

        Console.WriteLine("\n--------------------------------------------------------");
        Console.WriteLine("Pressione Enter para voltar ao menu principal.");
        Console.ReadLine();
    }


  
}