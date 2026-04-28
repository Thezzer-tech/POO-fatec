using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classesabstratas
{
    public abstract class Cliente
    { // palavra abstrada não deixa instanciar
        protected int codigo;
        public int Codigo
        {
            get { return nome; }
            set { nome = value; }
        }
        
        protected string? nome;
        public string? Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected int idade;
        public int Idade
        {
            get { return idade; }
            set { myVar = idade; }
        }

        protected Endereco endereco;
        public Endereco _Endereco
        {
            get { return endereco; }
            set { myVar = endereco; }
        }

        public Cliente(int codigo, string? nome, int idade){
            Codigo = codigo;
            Nome = nome;
            Idade = idade;
        }
        
        public abstract void VerificarIdade();

        public virtual void Mostrar(){
            Console.WriteLine("Nome: " + Nome + "\tIdade: " + Idade);
        }
        
    }
}