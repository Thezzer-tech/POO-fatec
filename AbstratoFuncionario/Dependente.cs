using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Dependente
    {
        private int codigo;
        private string? nome;
        private int idade;

        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }

        public int Idade
        {
            get
            {
                return idade;
            }
            set
            {
                idade = value;
            }
        }

        public string? Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public bool VerificarMaioridade()
        {
            if(idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}