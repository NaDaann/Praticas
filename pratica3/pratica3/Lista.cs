using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratica3
{
    class NoLista
    {
        public int chave;
        public NoLista prox;
        public string nome;
        public NoLista(int c)
        {
            chave = c;
            prox = null;
        }
    }

    class Lista
    {
        private NoLista prim, ult;

        public Lista()
        {
            prim = ult = null;
        }

        public void Inserir(NoLista item,string itemN)
        {
            if (prim == null) { 

                prim = item;
            prim.nome = itemN;
            }
            else { 
                ult.prox = item;
                ult.prox.nome = itemN;
            }
            ult = item;
        }

        public void Imprimir()
        {
            NoLista aux = prim;
            while (aux != null)
            {
                Console.WriteLine(aux.chave);
                Console.WriteLine(aux.nome);

                aux = aux.prox;
            }
        }

        public NoLista Pesquisar(int c)
        {
            NoLista aux = prim;
            while (aux != null && aux.chave != c)
            {
                aux = aux.prox;
            }
            return aux;
        }

        public bool Remover(int c)
        {
            NoLista aux = prim, ant = null;
            while (aux != null && aux.chave != c)
            {
                ant = aux;
                aux = aux.prox;
            }
            if (aux != null)
            {
                if (ant != null) // não é o primeiro 
                    ant.prox = aux.prox;
                else // é o primeiro
                    prim = aux.prox;
                if (aux == ult) // é o último
                    ult = ant;
                aux.prox = null; // desconecta o nó da lista
                return true;
            }
            return false;
        }
    }
}
