internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.Write("Digite o ano de nascimento: ");
        int ano = Convert.ToInt32(  Console.ReadLine()   );
        int idade = 2026 - ano;
        Console.WriteLine("Sua idade é: " + idade);
        if (idade >= 18)
            Console.WriteLine("Pode tirar habilitação");
        else if (idade == 0)
            Console.WriteLine("Nunca tirar habilitação");
        else
        {
            Console.WriteLine("Não pode tirar habilitação");
        }
        switch (idade)
        {
            case 18: Console.WriteLine("Pode dirigir");
                     break;
            case 17: Console.WriteLine("Não pode");    
                     break;        
            default: Console.WriteLine("Não tem permissão");    
                     break;
        }
        while (contador <= 10)
        {
            Console.WriteLine(tabuada + " X " + contador + " = " + tabuada * contador);
            contador ++; //incremento contador = contador + 1
        }
        for (contador = 1; contador <= 10; contador ++)
            Console.WriteLine(tabuada + " X " + contador + " = " + tabuada * contador);
        Console.WriteLine("Contador: " + contador);*/
        //Estrutura de repetição do .. while
        int tabuada = 6;
        int contador = 1;
        do
        {
            Console.WriteLine(tabuada + " X " + contador + " = " + tabuada * contador);
            contador += 1; //incremento contador ++;
        } while (contador <= 10);

    }
}