// Main()
using ConstrutorConta;
Conta c1 = new Conta(); //chamada do construtor padrão
c1.MostrarAtributos();

//chamada do construtor com 1 parâmetro
Conta c2 = new Conta(1);
c2.MostrarAtributos();

Conta c3 = new Conta("Ana", 100);
c3.MostrarAtributos();
Console.WriteLine("Qtde: "+Conta.Contador);
