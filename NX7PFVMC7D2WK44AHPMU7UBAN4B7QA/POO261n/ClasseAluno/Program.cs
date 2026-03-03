using ClasseAluno;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        Console.Write("Digite o RA: ");
        a1.ra = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o nome: ");
        a1.nome = Console.ReadLine();
        Console.Write("Digite a P1: ");
        a1.p1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Digite a P2: ");
        a1.p2 = Convert.ToDouble(Console.ReadLine());
        a1.MostrarAtributos();
        a1.CalcularMedia();
        a1.MostrarAtributos();
    }
}