using System;
using System.Collections.Generic;
using System.Text;

namespace caFilaInteiro
{
    class Pilha
    {
        private NohPilha topo;

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

        // método aidiciona elemento à pilha
        public void push(int insertItem)
        {
            if (isEmpty()) // se a pilha está vazia
            {
                topo = new NohPilha(insertItem); // inserir novo elemento
            }

            else
            {
                // NohPilha novoNoh = new NohPilha(insertItem, topo); OU
                NohPilha novoNoh = new NohPilha(insertItem); // atualizar o valor do topo da pilha
                novoNoh.setNext(topo);
                
                topo = novoNoh; // o topo agora aponta para mim -- this
            }
        } // fim do método push


        // método de retirar elemento da pilha
        public int pop()
        {
            if (isEmpty())
            {
                Console.WriteLine("Pilha Vazia");
                return 0;
            }
            else
            {
                int temp = topo.getData();
                topo = topo.getNext();
                return (temp);
            }

        }
        
    }
}
