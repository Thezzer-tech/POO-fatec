using PolimorfismosFuncionario;

Funcionario f = new Funcionario(1000);
Console.WriteLine($"Funcionário {f.CalcularBonificacao():c}");

Secretario a = new Secretario(1000);
Console.WriteLine($"Funcionário {a.CalcularBonificacao():c}");

Gerente b = new Gerente(1000);
Console.WriteLine($"Funcionário {b.CalcularBonificacao():c}");

Diretor c = new Diretor(1000);
Console.WriteLine($"Funcionário {c.CalcularBonificacao():c}");