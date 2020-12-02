using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha
{
    public class Pilha<T>
    {
        private T[] TPilha;
        private int Quantidade = 0;
        private int TopoPilha = 0;

        public Pilha(int Tamanho) 
        { 
            TPilha = new T[Tamanho];
            TopoPilha = Tamanho;
        }

        public void Push(T elemento)
        {
            TPilha[Quantidade] = elemento;
            Quantidade++;
        }

        public bool ExisteDado()
        {
            if (TopoPilha != Quantidade)
            {
                return false;
            }

            return true;
        }

        public bool IsEmpty() 
        {
            if (Quantidade != 0)
            {
                return false;
            }

            return true;
        }

        public T Top() 
        {
            if (IsEmpty() == true)
            {
                throw new Exception("Pilha vazia!");
            }

            return TPilha[Quantidade-1];
        }

        public void Pull(T Elemento) 
        {
            if (IsEmpty() == true)
            {
                throw new Exception("Pilha vazia!");
            }

            TPilha[Quantidade-1] = Elemento;
        }

        public void Pop() 
        {
            if (IsEmpty() == true)
            {
                throw new Exception("Pilha vazia!");
            }

            TPilha[Quantidade-1] = (T)Activator.CreateInstance(typeof(T));
            Quantidade--;
        }

        public int Tamanho() => Quantidade;

        public void Limpa() 
        {
            Quantidade = 0;
            TPilha = new T[TopoPilha];
        }
    }
}
