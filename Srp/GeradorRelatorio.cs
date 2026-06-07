using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Srp
{
    public class GeradorRelatorio
    {
        public string GerarRelatorio(Conta conta)
        {
            return $"Titular: {conta.Titular}\tSaldo: R$ {conta.Saldo}";
        }
    }
}