using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace HashTableGUI {
    public class HashTable {
        public static readonly int TABLE_SIZE = 8;

        private Application ap;
        private int Count = 0; // quantos elementos tem em todas os encadeamentos (somados)
        private static LinkedList<int>[] Table = new LinkedList<int>[TABLE_SIZE];
        private static ComboBox hashFunctionType;
        private static CheckBox orderedSortCB;
        private Output printer;

        private bool orderedInsertion;
        public bool OrderedInsertion {
            get { return orderedInsertion; }
            set { orderedInsertion = value; }
        }

        public int ListsWithElements { get; private set; } = 0;
        // Essa var. vai indicar quantos encadeamentos (listas) possuem *pelo menos* 2 elementos.
        // esse valor é alterado eficientemente: só ocorre quando uma das listas passa a
        // possuir 2 elementos e é decrementado apenas quando uma deixa de ter pelo menos 2 elementos.
        // Só será permitido alterar o método de inserção se essa variável for = 0,
        // em outras palavras: se a tabela hash está passível de ter suas "regras" alteradas.
        // Não há problema quando as listas possuem apenas 1 elemento porque teoricamente já estão ordenadas.

        public HashTable(object obj) {
            if (!(obj is Application))
                throw new UnauthorizedAccessException();

            ap = obj as Application;
            if( (printer = ap.getPrinter(this)) == null ) // gerar exceção nesse caso:
                throw new InitializationException("Application possui Output nulo - não inicializado.\n");
            hashFunctionType = ap.getHashFunctionType(this);
            orderedSortCB = ap.getCheckBox1(this);

            // inicialialização dos encadeamentos
            for (int i = 0; i < TABLE_SIZE; i++)
                Table[i] = new LinkedList<int>();
            Output.PrintMessage(ap.EventLog, "Listas encadeadas inicializadas.", true);
        }

        public static int HashFunction(int x) {
            x = (x < 0) ? -x : x;
            // se método da multiplicação por constante está selecionado (bit mixing)...
            if(hashFunctionType.SelectedIndex == 1) {
                x = (x << 13) | (x >> 19);
                x = (int) (x * 0x9e3779b1);
                x = x ^ (x >> 16);
            }
            return x % 8;
        }

        public bool Insert(int value) {
            LinkedList<int> list = Table[HashFunction(value)];
            // Primeiro, verifica o método de inserção:

            if (!orderedInsertion) { // inserção normal (não ordenada)
                if (list.Count == 0) {
                    list.AddLast(value);
                    printer.UpdateListString(list, value);
                    hashFunctionType.Enabled = false; // desativa alteração da função hash (só pode alterar com a tabela vazia)
                    
                    Count++;
                    ap.AlreadyClear = false;
                    return true;
                }

                if (list.Contains(value))
                    return false; // já possui mesma chave

                list.AddLast(value);
                printer.UpdateListString(list, value);
            }
            // inserção ordenada:
            else if (InsertInOrder(value) == false)
                return false; // vai retornar false se mesma chave já foi inserida.

            if (list.Count() == 2) { // Se passou a ter 2...
                ListsWithElements++;
                orderedSortCB.Enabled = false;
            }

            ap.AlreadyClear = false;
            Count++;
            return true;
        }

        public bool InsertInOrder(int value) {
            int index = HashFunction(value);
            LinkedList<int> list = Table[index];

            // 1º caso: lista vazia
            if(list.First == null) {
                list.AddFirst(value);
                printer.UpdateListString(list, value);
                hashFunctionType.Enabled = false; // desativa alteração da função hash (só pode alterar com a tabela vazia)
                return true;
            }
            
            // 2º caso: inserção no meio da lista ordenada.
            // it = nóAtual
            bool inserted = false;
            LinkedListNode<int> it;
            for (it = list.First; it != null; it = it.Next) {
                if (it.Value > value) {
                    list.AddBefore(it, value);
                    inserted = true;
                    printer.UpdateListString(list, value);
                    break;
                }
                else if (it.Value == value)
                    return false; // já consta.
            }
            // 3º caso: Não inseriu, então insere no final (é a maior chave da lista).
            if (inserted == false) {
                list.AddLast(value);
                printer.UpdateListString(list, value);
            }

            return true;
        }

        public bool Remove(int value) {
            int index = HashFunction(value);
            LinkedList<int> list = Table[index];

            if (list.Remove(value) == false)
                return false; // não foi encontrado na lista.

            else if (list.Count() == 1) { // Se ficou só com 1...
                if(--ListsWithElements == 0)
                    orderedSortCB.Enabled = true;
            }

            printer.UpdateListString(list, value);
            if (--Count == 0)
                hashFunctionType.Enabled = true; // reativa
            return true;
        }

        public void Clear() {
            for(int i = 0; i < TABLE_SIZE; i++)
                Table[i].Clear();

            ListsWithElements = 0;
            Count = 0;
            orderedSortCB.Enabled = true;    // reativa interação com checkBox caso esteja desativada.
            hashFunctionType.Enabled = true; // reativa alteração da função hash usada tabela.
            printer.ClearListStrings();
            Output.PrintMessage(ap.getLog(), "A tabela hash foi reinicializada.", true);
        }
    }
}
