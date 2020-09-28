using System;
using System.Collections.Generic;
using System.Text;

namespace Estrutura_de_Dados_Vetor
{
    public class Iterador<T>
    {
        T[] itens;
        int posicao = 0;

        public Iterador(T[] itens) 
        {
            this.itens = itens;
        }

        public bool HasNext() 
        {
            if (posicao < 0 || posicao >= itens.Length)
            {
                return false;
            }
            else 
            {
                return true;
            }
        }

        public object Next()
        {
            object item = itens[posicao];
            posicao++;
            return item;
        }
    }
}
