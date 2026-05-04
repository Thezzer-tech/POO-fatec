using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {

        //declaração atributos
        private int codigo;
        private string? nome;

        
        //declaração métodos
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public virtual void MostrarAtributos(){
            Console.WriteLine("Código: " + codigo + "\tNome: " + nome);
        }

        
    }
}