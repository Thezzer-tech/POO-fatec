using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public List<Funcionario> VetF { get; set; }
        public Departamento(int codigo, string? nome)
        {
            Codigo = codigo;
            Nome = nome;
        }
        public void Admitir(Funcionario f)
        {
            VetF.Add(f);
        }
        public void Listar()
        {
            foreach (var f in VetF)
            {
                f.Mostrar();   
            }
        }
        public void Demitir(int codigo)
        {
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt(i);
                if (codigo == f.Codigo)
                    VetF.Remove(f);
            }
        }
        public double CalcularFolha(int diasUteis)
        {
            double folha = 0;
            for (int i = 0; i < VetF.Count; i++)
            {
                Funcionario f = VetF.ElementAt(i);
                folha += f.CalcularSalario(diasUteis);
            }
            return folha;
        }

        public void MostrarQtdeDependentesFuncionario()
        {
            Console.WriteLine($"\n--- Dependentes no Departamento: {this.Nome} ---");

            foreach(var func in this.VetF)
            {
                
                int quantidade = func.CalcularTotalDependentes();

                Console.WriteLine($"Funcionário: {func.Nome}  |  Total de Dependentes: {quantidade}");
            }

            Console.WriteLine("--------------------------------------------------");
        }
    }
}