using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using TreinoAgregacao;

namespace TreinoAgregacao
{
    public class Cliente
    {
        private string? nome;
        private int cpf;

        public string? Nome
        {
            set
            {
                this.nome = value;
            }

            get
            {
                return this.nome;
            }
        }

        public int Cpf
        {
            set
            {
                this.cpf = value;
            }

            get
            {
                return this.cpf;
            }
        }
    }
}