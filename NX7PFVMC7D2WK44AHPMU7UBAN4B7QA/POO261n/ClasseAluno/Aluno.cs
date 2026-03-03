using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAluno
{
    public class Aluno
    {
        //Criar a classe Aluno com atributos: ra, nome,
        //p1, p2, media
        //Criar os métodos MostrarAtributos() e
        //CalcularMedia()
        //Instancie 2 objetos e digite os atributos ra,
        //nome, p1 e p2 
        //declaração de atributos
        public int ra;
        public string? nome; 
        public double p1;
        public double p2;
        public double media;
        //declaração dos métodos
        public void MostrarAtributos()
        {
            Console.WriteLine("Ra: "+ ra +
                        "\tNome: " + nome +
                        "\tP1: " + p1 + "\tP2: " + p2 +
                        "\tMédia: " + media);
        }
        public void CalcularMedia()
        {
            media = (p1 + p2) / 2;
        }        
    }
}