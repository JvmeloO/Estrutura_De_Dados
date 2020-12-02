using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            var Pilha = new Pilha<Aluno>(3);
            var aluno1 = new Aluno("Rodrigo", 1, 15);
            var aluno2 = new Aluno("Joao", 2, 15);
            var aluno3 = new Aluno("Carla", 3, 14);
            var aluno4 = new Aluno("Alan", 4, 14);
            Pilha.Push(aluno1);
            Pilha.Push(aluno2);
            Pilha.Pull(aluno3);
            Pilha.Push(aluno4);
            Pilha.Pop();
            //Pilha.Limpa();
            Console.WriteLine(Pilha.Top().GetNome());
            Console.WriteLine(Pilha.Top().GetIdade());
            Console.WriteLine(Pilha.Top().GetAno());
            Console.WriteLine(Pilha.ExisteDado());
            Console.WriteLine(Pilha.IsEmpty());
            Console.WriteLine(Pilha.Tamanho());            
        }
    }
}
