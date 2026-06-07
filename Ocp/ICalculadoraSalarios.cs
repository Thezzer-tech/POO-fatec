using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ocp
{
    public interface ICalculadoraSalarios
    {
        double CalcularSalario(Funcionario funcionario);
    }
}