using System;
using System.Collections.Generic;
using System.Text;

namespace Lista_Encadeada
{
    public class CelulaDupla
    {
        private CelulaDupla Anterior { get; set; }
        private CelulaDupla Proximo { get; set; }
        private Object Elemento { get; set; }

        public CelulaDupla() { }

        public CelulaDupla(Object elemento)
        {
            Elemento = elemento;
        }

        public CelulaDupla(CelulaDupla proximo, Object elemento)
        {
            Proximo = proximo;
            Elemento = elemento;
        }

        public CelulaDupla GetProximo()
        {
            return Proximo;
        }

        public CelulaDupla GetAnterior()
        {
            return Anterior;
        }

        public void SetProximo(CelulaDupla proximo)
        {
            Proximo = proximo;
        }

        public void SetAnterior(CelulaDupla anterior)
        {
            Anterior = anterior;
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
