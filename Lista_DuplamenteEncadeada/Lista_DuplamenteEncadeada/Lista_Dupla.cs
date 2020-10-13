using Lista_Encadeada;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados_Vetor
{
    public class Lista_Dupla<T>
    {
        private CelulaDupla Inicio { get; set; }

        private CelulaDupla Fim { get; set; }
        private int TamanhoLista { get; set; }


        public Lista_Dupla() { }

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
                CelulaDupla nova = new CelulaDupla(elemento);
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
                        nova.SetAnterior(it.GetAtual());
                        nova.SetProximo(it.GetAtual().GetProximo());                        
                        it.GetAtual().SetProximo(nova);
                        it.GetAtual().GetProximo().GetProximo().SetAnterior(it.GetAtual().GetProximo());
                        i++;
                    }
                }
                TamanhoLista++;
            }
        }

        //Método que adiciona no inicio da lista
        public void AdicionaInicio(T elemento)
        {
            CelulaDupla nova = new CelulaDupla(elemento);

            if (TamanhoLista == 0)
            {
                Inicio = Fim = nova;
                TamanhoLista++;
            }
            else
            {
                nova.SetProximo(Inicio); //O próximo do novo Nó será o atual primeiro
                Inicio.SetAnterior(nova);//O anterior do atual primeiro será o novo Nó
                Inicio = nova; // Atualiza-se o primeiro para o novo Nó
                TamanhoLista++; // incrementa o tamanho da lista
            }
        }

        public void AdicionaFim(T elemento)
        {
            CelulaDupla nova = new CelulaDupla(elemento);
            if (TamanhoLista == 0)
            {
                Inicio = Fim = nova;
                TamanhoLista++;
            }
            else
            {
                nova.SetAnterior(Fim); //O anterior do novo Nó será o atual ultimo
                Fim.SetProximo(nova); //O proximo do atual ultimo será o novo Nó
                Fim = nova;          // Atualiza-se o ultimo para o novo Nó
                TamanhoLista++; // incrementa o tamanho da lista
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
                        it.GetAtual().GetProximo().GetProximo().SetAnterior(it.GetAtual());
                        it.GetAtual().SetProximo(it.GetAtual().GetProximo().GetProximo());
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
                Fim = Fim.GetAnterior();
                TamanhoLista--;
            }
        }

        //Método que limpa/apaga todas as posições da lista
        public void Limpar()
        {
            Inicio = new CelulaDupla();
            Fim = new CelulaDupla();
            TamanhoLista = 0;
        }
    }
}
