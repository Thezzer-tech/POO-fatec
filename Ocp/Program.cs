using Ocp;

class Program
{
    public static void Main(string[] args)
    {
        Funcionario f = new Funcionario("Carlos", 5000);

        ICalculadoraSalarios funcPerma = new FuncionarioPermanente();
        ICalculadoraSalarios funcCont = new FuncionarioContrato();

        double salarioPerm = funcPerma.CalcularSalario(f);
        double salarioCont = funcCont.CalcularSalario(f);

        Console.WriteLine($"Salário de Carlos (Permanente): {salarioPerm}");
        Console.WriteLine($"Salário de Carlos (Contrato): {salarioCont}");
        
    }
}