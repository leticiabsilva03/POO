using System;
using System.Collections.Generic;
using System.Text;

namespace wfaContainers
{
    class Pilha
    {
        private NohPilha topo;
        private int aux = 0;

        // construtor padrão
        public Pilha()
        {
            topo = null;
        }

        // método para ver se há elementos
        public bool isEmpty()
        {
            if (topo == null)
            {
                return (true); // se a pilha está vazia
            }

            else
            {
                return (false); // se a pilha tem elementos
            }
        }

        // método para empilhar
        public void push(int item)
        {
            if (isEmpty())
            {
                topo = new NohPilha(item);
            }
            else
            {
                NohPilha novoNoh = new NohPilha(item); // insere o valor novo do topo da pilha
                novoNoh.setNext(topo); // atualiza para onde aponta

                topo = novoNoh;

            }
            aux++;
        }

        // método para desempilhar
        public int pop()
        {
            if (isEmpty())
            {
                return (0); // pilha vazia
            }
            else
            {
                int temp = topo.getData(); // dado a ser removido
                topo = topo.getNext(); // atualiza o valor do topo
                aux--;
                return (temp);
            }

        }

        // método para imprimir
        public string print()
        {
            string str = "";

            if (isEmpty())
            {
                return (str); // pilha vazia
            }
            else
            {
                NohPilha temp = topo;

                while (temp != null)
                {
                    str = str + temp.getData() + "\r\n";
                    temp = temp.getNext();
                }

                return (str);
            }
        }


        public NohPilha peek()
        {
            
            return (topo);
        }

        public int lenght()
        {
            return (aux);
        }

        public int indexOf(int valor)
        {
            int index = -1; // sem item na pilha

            int index_aux = 0;

            if (!isEmpty())
            {
                NohPilha aux = topo;

                while (aux != null)
                {
                    if (aux.getData() == valor)
                    {
                        index = index_aux; // buscando valor na pilha

                    }

                    aux = aux.getNext();
                    index_aux++;

                }
            }
            return index;

        }

    }
}
