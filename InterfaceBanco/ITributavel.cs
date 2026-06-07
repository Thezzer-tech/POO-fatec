using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceBanco
{
    public interface ITributavel
    {
        //metodo não recebe parâmetros
        //métodos em interface são publicos e abstratos
        double CalcularTributos();
    }
}