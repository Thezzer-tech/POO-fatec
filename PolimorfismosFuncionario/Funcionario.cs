using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismosFuncionario
{
    public class Funcionario
    {
        protected double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(double salario)
        {
            Salario = salario;
        }
        
        public virtual double CalcularBonificacao(){
            return Salario * 10/100;
            
        }
    }
}