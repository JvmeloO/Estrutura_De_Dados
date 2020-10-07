using System;

namespace Estrutura_de_Dados_Vetor
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var listaSimples = new Lista_Simples<Aluno>();
            var aluno1 = new Aluno("Rodrigo", 1, 15);
            var aluno2 = new Aluno("Joao", 2, 15);
            var aluno3 = new Aluno("Carla", 3, 14);
            var aluno4 = new Aluno("Alan", 4, 14);
            //listaSimples.AdicionaFim(aluno1);
            //listaSimples.AdicionaFim(aluno2);
            //listaSimples.AdicionaFim(aluno3);
            //listaSimples.AdicionaFim(aluno4);
            listaSimples.AdicionaInicio(aluno1);
            listaSimples.AdicionaInicio(aluno2);
            listaSimples.AdicionaInicio(aluno3);
            listaSimples.AdicionaInicio(aluno4);
            //listaSimples.AdicionaFim(aluno1);
            //listaSimples.AdicionaFim(aluno3);
            listaSimples.Adiciona(2, aluno1);
            //listaSimples.Remove(2);
            //listaSimples.RemoveFim();
            //listaSimples.RemoveInicio();
            Console.WriteLine(listaSimples.Vazio());
            //vetor.Limpar();
            //Console.WriteLine(vetor.Vazio());
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Aluno "+i);
                var aluno = listaSimples.Recupera(i);
                Console.WriteLine(aluno.GetNome());
                Console.WriteLine(aluno.GetIdade());
                Console.WriteLine(aluno.GetAno());
            }
        }
    }
}
