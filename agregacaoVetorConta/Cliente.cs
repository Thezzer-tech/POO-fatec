using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregacaoVetorConta
{
    public class Cliente
    {
        public string? Nome { get; set; }
        public int RG { get; set; }
        public int Telefone { get; set; }

        public void MostrarAtributos(){
            Console.WriteLine("Nome: " + Nome + " \tRg: " + RG + "\tTelefone: " + Telefone);
        }
    }
}