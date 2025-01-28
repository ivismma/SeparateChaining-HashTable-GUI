using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HashTableGUI {
    public class Output{
        private readonly TextBox[] info;
        private const String start = "-> ";
        private const String sep = " -> " ;
        private const String LineLimiter = "...";
        StringBuilder listLine;

        private const int MaxLineSize = 52;

        public Output(Application app) {
            info = app.getInfo(this);

            for (int i = 0; i < HashTable.TABLE_SIZE; i++) {
                listLine = new StringBuilder();
                listLine.EnsureCapacity(MaxLineSize);
                info[i].Text = start;
            }
        }

        public static void PrintData(int i, String str, TextBox index) {
            index.Text = str;
        }
        public static void PrintMessage(TextBox log, String str, bool newLine) {
            log.AppendText(str);
            if(newLine)
                log.AppendText(Environment.NewLine);
        }

        public static void PrintEvent(int i, int value, TextBox log, bool success) {
            switch (i) {
                case 1:
                    if(success)
                        log.AppendText("A chave (" + value + ") foi inserida com sucesso.");
                    else
                        log.AppendText("Não foi possível inserir a chave (" + value +") - A chave já consta na tabela hash.");
                    log.AppendText(Environment.NewLine);
                    break;
                case 2:
                    if(success)
                        log.AppendText("A chave (" + value + ") foi removida com sucesso.");
                    else
                        log.AppendText("Não foi possível remover a chave (" + value + ") - A chave não foi encontrada.");
                    log.AppendText(Environment.NewLine);
                    break;
                default:
                    break;
            }
        }

        public void UpdateListString(LinkedList<int> list, int value) {
            int index = HashTable.HashFunction(value);

            // atualizar exibição:
            LinkedListNode<int> it; // iterator
            if (list.Count == 1) {
                info[index].Text = start + value.ToString();
                return;
            }
            else {
                int charOffset = 0; // números negativos ocupam um caracter a mais por causa do sinal
                // esse valor será subtraído do tamanho máximo para compensar.

                bool lineIsFull = false; // flag para definir o comportamento da exibição
                
                // percorrer a lista encadeada p/ exibição
                for (it = list.First; it.Next != null; it = it.Next) {
                    listLine.Append(it.Value.ToString() + sep);
                    if (it.Value < 0)
                        charOffset++;
                    if (it.Next.Value.ToString().Length + listLine.Length >= MaxLineSize-charOffset) {
                        // esse if checa se inserindo esse nó e o que vem logo após, a string
                        // de exibição não ultrapassa o limite definido por MaxLineSize.
                        lineIsFull = true;
                        break;
                    }
                }
                if (!lineIsFull) {
                    listLine.Append(it.Value.ToString());
                    info[index].Text = start + listLine.ToString();
                }
                else {
                    info[index].Text = start + listLine.ToString() + LineLimiter;
                }
            }
            listLine.Clear();
        }
        public void ClearListStrings() {
            for (int i = 0; i < HashTable.TABLE_SIZE; i++) {
                info[i].Text = start;
            }
        }
    }
}
