using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocp
{
    public class Funcionario
    {
        public string Nome {get; set;}
        public double Salario {get; set;}

        public Funcionario (String nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }
    }
}