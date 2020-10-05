using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados_Vetor
{
    public class Aluno
    {
        private string Nome { get; set; }

        private int Idade { get; set; }

        private int Ano { get; set; }

        public Aluno() { }

        public Aluno(string nome, int idade, int ano) 
        {
            Nome = nome;
            Idade = idade;
            Ano = ano;
        }

        public string GetNome()
        {
            return Nome;
        }

        public int GetIdade()
        {
            return Idade;
        }

        public int GetAno() 
        {
            return Ano;
        }
    }
}
