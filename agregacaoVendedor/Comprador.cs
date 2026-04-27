using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace agregacaoVendedor
{
    public class Comprador
    {
      private double verba; 

      public double Verba
      {
        set
        {
          this.verba = value;
        }
        get
        {
          return this.verba;
        }
      }

      public void DiminuirVerba(double valor)
      {
        if(valor <= verba)
        {
          verba = verba - valor;
        }
        else
        {
          Console.WriteLine("Cliente não possui verba suficiente");
        }
      
      }

      public Comprador(double verba)
      {
        this.verba = verba;
      }

      public void MostrarAtributos()
      {
        Console.WriteLine("Verba Cliente: " + verba);
      }
    
    }



}