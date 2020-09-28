using System;

namespace Estrutura_de_Dados_Vetor
{
    class ClassMain
    {
        static void Main(string[] args)
        {
            var vetor = new Vetor<Aluno>(5);
            var aluno = new Aluno()
            {
                Nome = "Rodrigo",
                Ano = 9,
                Idade = 15
            };
            var aluno2 = new Aluno()
            {
                Nome = "Joao",
                Ano = 9,
                Idade = 15
            };
            var aluno3 = new Aluno()
            {
                Nome = "Carla",
                Ano = 8,
                Idade = 14
            };
            var aluno4 = new Aluno()
            {
                Nome = "Alan",
                Ano = 8,
                Idade = 14
            };
            vetor.AdicionarFim(aluno);
            vetor.AdicionarFim(aluno2);
            vetor.AdicionarInicio(aluno3);
            vetor.AdicionarInicio(aluno4);
            vetor.AdicionarFim(aluno);
            vetor.AdicionarFim(aluno);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Aluno "+i);
                var item = vetor.Recuperar(i);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Idade);
                Console.WriteLine(item.Ano);
            }
        }
    }
}
