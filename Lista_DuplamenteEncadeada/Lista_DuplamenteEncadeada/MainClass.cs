using System;

namespace Estrutura_de_Dados_Vetor
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var listaDupla = new Lista_Dupla<Aluno>();
            var aluno1 = new Aluno("Rodrigo", 1, 15);
            var aluno2 = new Aluno("Joao", 2, 15);
            var aluno3 = new Aluno("Carla", 3, 14);
            var aluno4 = new Aluno("Alan", 4, 14);
            listaDupla.AdicionaFim(aluno1);
            listaDupla.AdicionaFim(aluno2);
            listaDupla.AdicionaFim(aluno3);
            listaDupla.AdicionaFim(aluno4);
            listaDupla.AdicionaInicio(aluno2);
            listaDupla.AdicionaInicio(aluno3);
            listaDupla.AdicionaInicio(aluno4);
            listaDupla.TrocaPosicao(6);
            //listaSimples.AdicionaFim(aluno3);
            //listaSimples.AdicionaFim(aluno3);
            //listaDupla.Adiciona(2, aluno1);
            //listaDupla.Remove(2);
            //listaDupla.RemoveInicio();
            //listaDupla.RemoveFim();
            //listaSimples.Adiciona(2, aluno4);
            //listaSimples.RemoveInicio();
            Console.WriteLine(listaDupla.Vazio());
            //vetor.Limpar();
            //Console.WriteLine(vetor.Vazio());
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Aluno "+i);
                var aluno = listaDupla.Recupera(i);
                Console.WriteLine(aluno.GetNome());
                Console.WriteLine(aluno.GetIdade());
                Console.WriteLine(aluno.GetAno());
            }
        }
    }
}
