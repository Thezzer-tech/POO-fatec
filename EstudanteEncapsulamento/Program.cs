using System.Reflection;
using EstudanteEncapsulamento;

internal class Program
{
    public static void Main(String[] args)
    {
        Estudante[] vetAluno = new Estudante[2];

        for(int i = 0; i < vetAluno.Length; i++)
        {
            vetAluno[i] = new Estudante(); 
            Console.WriteLine("Digite nome do aluno: ");
            vetAluno[i].Nome = Console.ReadLine();
            Console.WriteLine("Digite nota de aluno: ");
            vetAluno[i].Media = Convert.ToDouble(Console.ReadLine());
        }

        for(int i = 0; i < vetAluno.Length; i++)
        {
            vetAluno[i].MostrarAtributos();
            vetAluno[i].ExibirInformacoes();
        }
    }
}