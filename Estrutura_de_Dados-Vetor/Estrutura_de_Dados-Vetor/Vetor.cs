using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados_Vetor
{
    public class Vetor<T>
    {
        private T[] vetor;

        private int qntElementos = 0;

        public Vetor(int tam) 
        {
            vetor = new T[tam];
        }
        public bool ExisteDado(int pos)
        {
            return vetor[pos] != null;
        }

        public int Tamanho()
        {
            return qntElementos;
        }

        public T Recuperar(int pos)
        {
            if ((pos < 0 && pos > Tamanho()) || (!ExisteDado(pos)))
            {
                throw new Exception("Posição Inválida");
            }
            return vetor[pos];
        }

        public bool Vazio()
        {
            return Tamanho() == 0;
        }

        public void Adiciona(T elemento, int posicao)
        {
            if ((posicao < 0 && posicao > Tamanho()))
            {
                throw new Exception("Posição Inválida");
            }

            vetor[posicao] = elemento;
        }

        //Método que adiciona no vetor
        public void AdicionarInicio(T elemento)
        {
            if (Tamanho() == vetor.Length)
            {
                Redimensionar();
            }

            T elementoInicio;
            elementoInicio = vetor[0];
            vetor[0] = elemento;

            Iterador<T> it = new Iterador<T>(vetor);
            int i = 1;
            T elementoAnterior = vetor[i];
            while (it.HasNext())
            { //percorrendo o vetor usando iterador
                if (it.Next() != null)
                {              
                    if (i != 1)
                    {
                        T elementoAtual = vetor[i];
                        vetor[i] = elementoAnterior;
                        elementoAnterior = elementoAtual;
                    }
                    else
                    {                        
                        vetor[i] = elementoInicio;
                    }
                }
                i++;
            }
            qntElementos++;
        }

        public void AdicionarFim(T elemento)
        {
            if (Tamanho() == vetor.Length)
            {
                Redimensionar();
            }

            vetor[qntElementos] = elemento;
            qntElementos++;
        }

        //Método que remove do vetor em uma determinada posição
        public void Remover(int posicao)
        {
            if ((posicao < 0 && posicao > Tamanho()) || (!ExisteDado(posicao)))
            {
                throw new Exception("Posição Inválida");
            }

            Iterador<T> it = new Iterador<T>(vetor);
            int i = 0;
            while (it.HasNext())
            { //percorrendo o vetor usando iterador
                T item;
                item = (T)Convert.ChangeType(it.Next(), typeof(T));
                if (item != null)
                {                    
                    if (EqualityComparer<T>.Default.Equals(item, vetor[posicao]))
                    {
                        vetor[i] = vetor[i + 1];
                    }
                }
                i++;
            }
            qntElementos--;
        }

        //Método que remove do início do vetor
        public void RemoverInicio()
        {
            Iterador<T> it = new Iterador<T>(vetor);
            int i = 0;
            while (it.HasNext())
            { //percorrendo o vetor usando iterador
                if (it.Next() != null)
                {
                    vetor[i] = vetor[i + 1];
                }
                i++;
            }
            qntElementos--;
        }

        //Método que remove do fim do vetor
        public void RemoverFim()
        {
            T[] vetorNovo = new T[qntElementos];
            Iterador<T> it = new Iterador<T>(vetor);
            int i = 0;
            while (it.HasNext())
            { //percorrendo o vetor usando iterador
                if (it.Next() != null)
                {
                    if (i != qntElementos)
                    {
                        vetorNovo[i] = vetor[i];
                    }
                }
                i++;
            }
            qntElementos--;
        }

        //Método que limpa/apaga todas as posições do vetor
        public void Limpar()
        {
            vetor = new T[qntElementos];
            qntElementos = 0;
        }

        //Método que dobra o tamanho do vetor caso ele atinja o seu tamanho.
        public void Redimensionar()
        {
            T[] vetorCopia = new T[qntElementos];
            vetorCopia = vetor;
            vetor = new T[qntElementos*2];
            Iterador<T> it = new Iterador<T>(vetorCopia);
            int i = 0;
            while (it.HasNext())
            { //percorrendo o vetor usando iterador
                if (it.Next() != null)
                {
                    vetor[i] = vetorCopia[i];
                }
                i++;
            }
        }
    }
}
