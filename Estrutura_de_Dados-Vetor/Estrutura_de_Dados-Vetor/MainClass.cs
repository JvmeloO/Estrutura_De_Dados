using System;

namespace Estrutura_de_Dados_Vetor
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var vetor = new Vetor<Aluno>(5);
            var aluno = new Aluno()
            {
                Nome = "Rodrigo",
                Ano = 1,
                Idade = 15
            };
            var aluno2 = new Aluno()
            {
                Nome = "Joao",
                Ano = 2,
                Idade = 15
            };
            var aluno3 = new Aluno()
            {
                Nome = "Carla",
                Ano = 3,
                Idade = 14
            };
            var aluno4 = new Aluno()
            {
                Nome = "Alan",
                Ano = 4,
                Idade = 14
            };
            vetor.AdicionaFim(aluno);
            vetor.AdicionaFim(aluno2);
            vetor.AdicionaFim(aluno3);
            vetor.AdicionaFim(aluno4);
            vetor.AdicionaInicio(aluno4);
            vetor.AdicionaInicio(aluno3);
            vetor.AdicionaInicio(aluno4);
            vetor.AdicionaFim(aluno);
            vetor.AdicionaFim(aluno3);
            vetor.RemoveFim();
            vetor.RemoveInicio();
            Console.WriteLine(vetor.Vazio());
            //vetor.Limpar();
            //Console.WriteLine(vetor.Vazio());
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Aluno "+i);
                var item = vetor.Recupera(i);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Idade);
                Console.WriteLine(item.Ano);
            }
        }
    }
}
