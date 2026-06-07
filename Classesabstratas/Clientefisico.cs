using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classesabstratas
{
    public class Clientefisico : Cliente
    {
        public int Rg { get; set; }

        public Clientefisico(int codigo, string? nome, int idade) : base(codigo, nome, idade)
        { 
            Rg = rg;
        }


        public override void VerificarIdade(){
            if (VerificarIdade < 50){
                Console.WriteLine("CF - Idade Válidada");
            }
        }

        public override void Mostrar(){
            base.Mostrar();
            Console.WriteLine("Rg: " + Rg);
        }
    
    }
}