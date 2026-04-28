using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classesabstratas
{
    public class Clientejuridico : Cliente
    {
        public int Cnpj { get; set; }

        public Clientejuridico(int codigo, string? nome, int idade) : base(codigo, nome, idade)
        { 
            Cnpj = cnpj;
        }

        public override void VerificarIdade(){
            if (VerificarIdade >= 50){
                Console.WriteLine("CJ - Idade Válidada");
            }
        }
        
    }
}