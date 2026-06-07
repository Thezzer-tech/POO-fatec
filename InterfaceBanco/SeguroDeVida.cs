using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceBanco
{
    public class SeguroDeVida : ITributavel
    {
        //seguro de vida devolve valor de 75
        public double CalcularTributos()
        {
            return 75.0;
        }
    }
}