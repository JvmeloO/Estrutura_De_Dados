using Lista_Encadeada;
using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados_Vetor
{
    public class Iterador<T>
    {
        private CelulaDupla Atual { get; set; }

        public Iterador(CelulaDupla atual) 
        {
            Atual = atual;
        }

        public bool HasNext() 
        {
            if (Atual != null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public object Next()
        {
            Object elemento = Atual.GetElemento();
            Atual = Atual.GetProximo();
            return elemento;
        }

        public CelulaDupla GetAtual()
        {
            return Atual;
        }
    }
}
