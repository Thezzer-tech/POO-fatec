using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas
{
    public class Cheque : Pagamento 
    {
        private long numero;
        private DateTime dataDeposito;
        private int situacao;

        public long Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }

        public DateTime DataDeposito
        {
            get
            {
                return dataDeposito;
            }
            set
            {
                dataDeposito = value;
            }
        }

        public int Situacao
        {
            get
            {
                return situacao;
            }
            set
            {
                situacao = value;
            }
        }

        public Cheque(DateTime data, double total, int situacao, long numero, DateTime dataD) : base (data, total)
        {
            this.numero = numero;
            this.dataDeposito = dataD;
            this.situacao = situacao;
        }
    }
}