using System.ComponentModel;
using ArrayProduto;

internal class Program{

    private static void Main(string[] args){

        estoque[] vetEst = new estoque[3];

        for(int i = 0; i < vetEst.Length; i++){
            vetEst[i] = new estoque();
            Console.WriteLine("Digite o código: ");
            vetEst[i].codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite nome: ");
            vetEst[i].nome = Console.ReadLine();
        }
    }
}