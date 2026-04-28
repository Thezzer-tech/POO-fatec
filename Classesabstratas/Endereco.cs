using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classesabstratas
{
    public class Endereco
    {
        public string? Rua { get; set; }

        public int Numero { get; set; }

        public string? Bairro {get; set;}

        public string? Cidade { get; set;}

        public Endereco(string? rua, int n, string? bairro, string? cidade){
            Rua = rua;
            Numero = numero; 
            Bairro = bairro;
            Cidade = cidade;
        }
    }
}