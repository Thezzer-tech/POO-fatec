using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lsp
{
    public interface IConta
    {
        public void Sacar(double valor);
        public double GetSaldo();
    }
}