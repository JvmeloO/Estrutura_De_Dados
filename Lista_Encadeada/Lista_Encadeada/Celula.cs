using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Encadeada
{
    public class Celula
    {
        private Celula Proximo { get; set; }
        private Object Elemento { get; set; }

        public Celula() { }

        public Celula(Object elemento)
        {
            Elemento = elemento;
        }

        public Celula(Celula proximo, Object elemento)
        {
            Proximo = proximo;
            Elemento = elemento;
        }

        public Celula GetProximo()
        {
            return Proximo;
        }

        public void SetProximo(Celula proximo)
        {
            Proximo = proximo;
        }

        public Object GetElemento()
        {
            return Elemento;
        }

        public void SetElemento(Object elemento)
        {
            Elemento = elemento;
        }
    }
}
