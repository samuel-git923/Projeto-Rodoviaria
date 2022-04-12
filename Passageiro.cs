using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRodoviaria
{
    public class Passageiro
    {
        public Passageiro()
        {
            this.Nome = "";
            this.Destino = "";
            this.Passagem = 0;
        }

        public Passageiro(String nome, String destino, Double passagem)
        {
            this.Nome = nome;
            this.Destino = destino;
            this.Passagem = passagem;
        }

        private String nome;

        public String Nome
        {
            get { return this.nome; }
            set { this. nome = value.ToUpper(); }
        }

        public String Destino { get; set; }

        public Double Passagem { get; set; }

        public void ExibirDados()
        {
            Console.WriteLine("Passageiro: " + this.Nome);
            //Console.WriteLine("Destino: " + this.Destino);
            //Console.WriteLine("Passagem: " + this.Passagem);
        }

    }
}
