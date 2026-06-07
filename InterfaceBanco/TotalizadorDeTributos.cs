using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceBanco
{
    public class TotalizadorDeTributos
    {
        //guarda total acumulado
        public double Total {get; private set;}

        //o metodo recebe a interface como parâmetro
        public void Adiciona(ITributavel t)
        {
            this.Total += t.CalcularTributos();
        }
    }
}