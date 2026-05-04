using PolimorfismosFuncionario;

Funcionario f = new Funcionario(1000);
Console.WriteLine($"Funcionário {f.CalcularBonificacao():c}");

Secretario a = new Secretario(1000);
Console.WriteLine($"Funcionário {a.CalcularBonificacao():c}");

Gerente b = new Gerente(1000);
Console.WriteLine($"Funcionário {b.CalcularBonificacao():c}");

Diretor c = new Diretor(1000);
Console.WriteLine($"Funcionário {c.CalcularBonificacao():c}");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

gerenciador.Totalizadorbonificacao(f); // Usa o método Funcionario
gerenciador.Totalizadorbonificacao(a); // Usa o método Secretario
gerenciador.Totalizadorbonificacao(b); // Usa o método Gerente
gerenciador.Totalizadorbonificacao(c); // Usa o método Diretor

Console.WriteLine($"\nTotal de Bonificações da Empresa: {gerenciador.Totalbonificacao:c}");