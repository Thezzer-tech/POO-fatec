using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismosFuncionario
{

    public class GerenciadorBonificacao
    {

        private double totalbonificacao;
        public double Totalbonificacao
        {
            get { return this.totalbonificacao; }
            set { this.totalbonificacao = value; }
        }

        public void Totalizadorbonificacao(Funcionario funcionario)
        {
            this.Totalbonificacao += funcionario.CalcularBonificacao();
        }

        public void Totalizadorbonificacao(Secretario secretario)
        {
            this.Totalbonificacao += secretario.CalcularBonificacao();
        }

        public void Totalizadorbonificacao(Gerente gerente)
        {
            this.Totalbonificacao += gerente.CalcularBonificacao();
        }

        public void Totalizadorbonificacoa(Diretor diretor)
        {
            this.Totalbonificacao += diretor.CalcularBonificacao();
        }
        
        
    }
}