using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Srp
{
    public class ValidarUsuario
    {
        public bool ValidadorUsuario(Conta conta, string nome)
        {
            return conta.Titular == nome;
        }
    }
}