using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            var Fila = new Fila<Aluno>(3);
            var aluno1 = new Aluno("Rodrigo", 1, 15);
            var aluno2 = new Aluno("Joao", 2, 15);
            var aluno3 = new Aluno("Carla", 3, 14);
            var aluno4 = new Aluno("Alan", 4, 14);
            Fila.Inserir(aluno1);
            Fila.Inserir(aluno2);
            Fila.Inserir(aluno4);
            //Fila.Alterar(aluno3);
            Fila.Remover();
            Console.WriteLine(Fila.Recuperar().GetNome());
            Console.WriteLine(Fila.Recuperar().GetIdade());
            Console.WriteLine(Fila.Recuperar().GetAno());
            Console.WriteLine(Fila.ExisteDado());
            Console.WriteLine(Fila.IsEmpty());
        }
    }
}
