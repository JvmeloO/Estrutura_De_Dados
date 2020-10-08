using Lista_Encadeada;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados_Vetor
{
    public class Lista_Simples<T>
    {
        private Celula Inicio { get; set; }

        private Celula Fim { get; set; }
        private int TamanhoLista { get; set; }


        public Lista_Simples() { }

        public bool ExisteDado()
        {
            return TamanhoLista != 0;
        }

        public int Tamanho()
        {
            return TamanhoLista;
        }

        public T Recupera(int posicao)
        {
            if (TamanhoLista == 0)
            {
                throw new Exception("A lista está vazia!!");
            }
            else if (posicao < 0 || posicao >= Tamanho())
            {
                throw new Exception("A Posição " + posicao + " é Inválida!");
            }
            else
            {
                Iterador<T> it = new Iterador<T>(Inicio);
                int i = 0;
                while (it.HasNext())
                {
                    if (i != posicao)
                    {
                        it.Next();
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }

                return (T)it.GetAtual().GetElemento();
            }
        }

        public bool Vazio()
        {
            return Tamanho() == 0;
        }

        public void Adiciona(int posicao, T elemento)
        {
            if (posicao < 0 || posicao >= Tamanho())
            {
                throw new Exception("A Posição " + posicao + " é Inválida!");
            }
            else
            {
                Celula nova = new Celula(elemento);
                Iterador<T> it = new Iterador<T>(Inicio);
                int i = 0;
                while (it.HasNext())
                {
                    if (i != posicao-1)
                    {
                        it.Next();
                        i++;
                    }
                    else
                    {
                        nova.SetProximo(it.GetAtual().GetProximo());
                        it.GetAtual().SetProximo(nova);
                        i++;
                    }
                }
                TamanhoLista++;
            }
        }

        //Método que adiciona no inicio da lista
        public void AdicionaInicio(T elemento)
        {
            Celula nova = new Celula(elemento);
            if (TamanhoLista == 0)
            {
                Inicio = Fim = nova;
                TamanhoLista++;
            }
            else
            {
                nova.SetProximo(Inicio);
                Inicio = nova;
                TamanhoLista++;
            }
        }

        public void AdicionaFim(T elemento)
        {
            Celula nova = new Celula(elemento);
            if (TamanhoLista == 0)
            {
                Inicio = Fim = nova;
                TamanhoLista++;
            }
            else
            {
                Fim.SetProximo(nova);
                Fim = nova;
                TamanhoLista++;
            }
        }

        //Método que remove da lista em uma determinada posição
        public void Remove(int posicao)
        {
            if (posicao < 0 || posicao >= Tamanho())
            {
                throw new Exception("A Posição " + posicao + " é Inválida!");
            }
            else
            {
                Celula novoInicio = new Celula(Inicio.GetProximo(), Inicio.GetElemento());
                Iterador<T> it = new Iterador<T>(Inicio);
                Iterador<T> itNovoInicio = new Iterador<T>(novoInicio);
                int i = 0;
                while (it.HasNext())
                {
                    if (i != posicao-1)
                    {
                        itNovoInicio.Next();
                        it.Next();
                        i++;
                    }
                    else
                    {
                        itNovoInicio.Next();
                        it.GetAtual().SetProximo(itNovoInicio.GetAtual().GetProximo());
                        i++;
                    }
                }
                TamanhoLista--;
            }
        }

        //Método que remove do início da lista 
        public void RemoveInicio()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A lista está vazia!");
            }
            else if (Inicio == Fim)
            {
                Inicio = Fim = null;
                TamanhoLista--;
            }
            else
            {
                Inicio = Inicio.GetProximo();
                TamanhoLista--;
            }
        }

        //Método que remove do fim da lista
        public void RemoveFim()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A lista está vazia!");
            }
            else if (Inicio == Fim)
            {
                Inicio = Fim = null;
                TamanhoLista--;
            }
            else
            {
                Celula penultimaPos = new Celula(Recupera(TamanhoLista-2));
                Fim = Fim.GetProximo();
                Fim = penultimaPos;
                TamanhoLista--;
            }
        }

        //Método que limpa/apaga todas as posições da lista
        public void Limpar()
        {
            Inicio = new Celula();
            Fim = new Celula();
            TamanhoLista = 0;
        }
    }
}
