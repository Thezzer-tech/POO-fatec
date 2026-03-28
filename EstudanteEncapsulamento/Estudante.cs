using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EstudanteEncapsulamento
{
    public class Estudante
    {
        private string? nome;
        private Double media;

        public string? Nome
        {
            set
            {
                this.nome = value;
            }
            get
            {
                return this.nome.ToUpper();
            }
        }

        public Double Media
        {
            set
            {
                if(value >= 0 && value <=10){
                    this.media = value;
                }
                else{
                    Console.WriteLine("Valor incorreto, Precisa de um valor > 10 e < 0");
                }
            }
            get
            {
                return this.media;
            }
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Nome do Aluno: " + Nome + 
            "\tMédia: " + Media);
        }

        public bool EstaAprovado()
        {
            return Media >= 6;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Status: " + (EstaAprovado() ? "aprovado" : "Reprovado" ));
        }

    }
}