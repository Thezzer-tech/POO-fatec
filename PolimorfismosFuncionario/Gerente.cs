using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismosFuncionario
{
    public class Gerente : Funcionario
    {
        public Gerente(double salario) : base (salario)
        {
            
        }   

        public override double CalcularBonificacao(){
            return salario * 15/100;
        }
    }
}