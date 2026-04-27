using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregacaoConta
{
    public class Conta
    {

        //encapsulamento compacto
        public int Numero { get; set; }
        //Estabelecimento de agregação
        public Cliente Titular { get; set; }

        public double Saldo{ get; set; }
    }


}