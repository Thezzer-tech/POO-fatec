//Main()
using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Leo", 1000, 20);
Comissionado c2 = new Comissionado(4, "Teo", 1000, 30);

//dependentes
Dependente dep1 = new Dependente { Codigo = 101, Nome = "Pedrinho", Idade = 15 };
Dependente dep2 = new Dependente { Codigo = 102, Nome = "José", Idade = 20 };
Dependente dep3 = new Dependente { Codigo = 103, Nome = "Enzo", Idade = 8 };
Dependente dep4 = new Dependente { Codigo = 104, Nome = "Luis", Idade = 12 };

//adicionar ao funcionario dependente
a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep3);
c1.AdicionarDependente(dep2);
c2.AdicionarDependente(dep4);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.Listar();
//d2.Demitir(2);

Console.WriteLine("=== DEPARTAMENTO DE TI ===");
d1.Listar();
Console.WriteLine($"Total Folha TI: {d1.CalcularFolha(30):c}");
// mostrar dependente
d1.MostrarQtdeDependentesFuncionario();

Console.WriteLine("\n=== DEPARTAMENTO DE RH ===");
d2.Listar();
Console.WriteLine($"Total Folha RH: {d2.CalcularFolha(30):c}");
// Mostrar dependente
d2.MostrarQtdeDependentesFuncionario();


Console.WriteLine("\n=== TESTE DE LISTAGEM E REMOÇÃO ===");
a1.ListarDependentes(); 

//teste para remoção de dependentes
Console.WriteLine("\nLéo antes de remover maior de idade:");
c1.ListarDependentes();
c1.RemoverDependenteMaiorIdade();
Console.WriteLine("\nLéo depois de remover maior de idade:");
c1.ListarDependentes();

Console.WriteLine("\n removendo um dependente de Ana");
a1.RemoverDependente(101);
a1.ListarDependentes();