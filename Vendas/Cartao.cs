using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas
{
    public class Cartao : Pagamento
    {
        private string? dadosTransacao;
        private int resultadoTransacao;

        public string? DadosTransacao
        {
            get
            {
                return dadosTransacao;
            }
            set
            {
                dadosTransacao = value;
            }
        }

        public int ResultadoTransacao
        {
            get
            {
                return resultadoTransacao;
            }
            set
            {
                resultadoTransacao = value;
            }
        }

        public Cartao(DateTime data, double total, string dados, int resultado) : base(data, total)
        {
            this.dadosTransacao = dados;
            this.resultadoTransacao = resultado;
        }
    }
}