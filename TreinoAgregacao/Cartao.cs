using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreinoAgregacao;

namespace TreinoAgregacao
{
    public class Cartao
    {
        private int numero;
        private string? data;

        public Cliente cliente {get; set;}

        public int Numero
        {
            set
            {
                this.numero = value;
            }
            get
            {
                return this.numero;
            }
        }

        public string? Data
        {
            set
            {
                this.data = value;
            }
            get
            {
                return this.data;
            }
        }
    }
}