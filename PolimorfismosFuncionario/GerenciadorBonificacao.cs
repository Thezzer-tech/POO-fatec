using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismosFuncionario
{

    public class GerenciadorBonificacao
    {
        public Funcionario funcionario;

        private double totalbonificacao;
        public double Totalbonificacao
        {
            get { return totalbonificacao; }
            set { totalbonificacao = value; }
        }
        
        
    }
}