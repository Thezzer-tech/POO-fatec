using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    //  Subclasse : superclasse
    //  Classe derivada : classe base
    public class ClienteFisico : Cliente
    {
        private int rg;
        public int Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public override void MostrarAtributos(){
            base.MostrarAtributos();
            Console.WriteLine("CPF:" + cpf);
        }
        
    }
}