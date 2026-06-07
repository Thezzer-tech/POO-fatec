using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocp
{
    public class FuncionarioPermanente : ICalculadoraSalarios
    {
        public double CalcularSalario(Funcionario funcionario)
        {
            return Salario * 1.3;
        }
    }
}