using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas
{
    public class Especie : Pagamento
    {
        private double quantia;

        private double troco;

        public double Quantia
        {
            get
            {
                return quantia;
            }
            set
            {
                quantia = value;
            }
        }

        public double Troco
        {
            get
            {
                return troco;
            }
            set
            {
                troco = value;
            }
        }

        public Especie(DateTime data, double total, double quantia) : base(data, total)
        {
            this.quantia = quantia;
            CalcularTroco();
        }

        private void CalcularTroco()
        {
            this.troco = this.quantia - this.total;
        }

        
    }
}