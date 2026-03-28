using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorRA
{
    public class Conta
    {

        private string? nome;
        private long ra = 1570482423000;

        private static int contador;

        public static int Contador
        {
            get
            {
                return contador;
            }
        }


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

        public Conta()
        {
            contador++;
            this.ra = contador + ra;
        }

        public Conta(string? nome)
        {
            this.nome = nome;
            this.ra = contador + ra;
            contador++;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Nome: " + nome +
                             "\tRA: " + ra );
        }



    }
}