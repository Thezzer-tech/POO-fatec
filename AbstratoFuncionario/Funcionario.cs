using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        //declaração dos atributos
        protected int codigo;
        protected string? nome;
        protected double salario;
        private List<Dependente> dependentes;
        //declaração dos métodos
        public Funcionario(int codigo, string? nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;

            this.dependentes = new List<Dependente>();
        }
        public virtual void Mostrar()
        {
            Console.WriteLine($"Código: {Codigo} Nome: {Nome} Salário {Salario:c}");
        }
        public abstract double CalcularSalario(int diasUteis);
        
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
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        
        public int CalcularTotalDependentes()
        {
            return this.dependentes.Count();
        }

        public void AdicionarDependente(Dependente novoDep)
        {
            if(novoDep != null)
            {
                this.dependentes.Add(novoDep);
            }
        }

        public void RemoverDependente(int codigoDependente)
        {
            for(int i = 0; i < dependentes.Count; i++)
            {
                Dependente d = dependentes.ElementAt(i);
                if (codigoDependente == d.Codigo)
                    dependentes.Remove(d);
            }
        }

        public void RemoverDependenteMaiorIdade()
        {
            for(int i = 0; i < dependentes.Count; i++)
            {
                Dependente d = dependentes.ElementAt(i);
                if (d.VerificarMaioridade())
                {
                    dependentes.Remove(d);
                    i--;
                }
            }
        }
        
        public void ListarDependentes()
        {   
            Console.WriteLine("Listagem de dependentes\t");
            for(int i = 0; i < dependentes.Count; i++)
            {
                Dependente d = dependentes.ElementAt(i);
                Console.WriteLine($"Código: {d.Codigo} | Nome : {d.Nome} | Idade : {d.Idade} ");
            }
        }
    }
}