using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agregacaoVetorConta
{
    public class Conta
    {
        //encapsulamento compacto
        public int Numero { get; set; }
        //Estabelecimento de agregação
        public List <Cliente> VetTitular { get; set; }

        public double Saldo{ get; set; }
    }
}