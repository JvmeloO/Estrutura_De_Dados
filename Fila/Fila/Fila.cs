using System;
using System.Collections.Generic;
using System.Text;

namespace Pilha
{
    public class Fila<T>
    {
        private T[] TFila;
        private int Quantidade = 0;
        private int TamanhoFila = 0;

        public Fila(int Tamanho) 
        {
            TFila = new T[Tamanho];
            TamanhoFila = Tamanho;
        }

        public void Inserir(T elemento)
        {
            TFila[Quantidade] = elemento;
            Quantidade++;
        }

        public bool ExisteDado()
        {
            if (TFila[0] == null)
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

        public T Recuperar() 
        {
            if (IsEmpty() == true)
            {
                throw new Exception("Fila vazia!");
            }

            return TFila[0];
        }

        public void Alterar(T Elemento) 
        {
            if (IsEmpty() == true)
            {
                throw new Exception("Fila vazia!");
            }

            TFila[0] = Elemento;
        }

        public void Remover() 
        {
            var NovaFila = new T[TamanhoFila];
            for (int i = 1; i < Quantidade; i++)
            {
                NovaFila[i-1] = TFila[i];
            }
            TFila = NovaFila;
        }

        public int Tamanho() => Quantidade;

        public void Limpar() 
        {
            Quantidade = 0;
            TFila = new T[TamanhoFila];
        }
    }
}
