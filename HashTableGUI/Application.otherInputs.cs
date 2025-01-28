using System;
using System.Windows.Forms;

namespace HashTableGUI {
    public partial class Application : Form {
        private void toInsert_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) {
                toInsert_Click(this, new EventArgs());
                e.SuppressKeyPress = true; // Evitar som de "erro"
            }
        }

        private void toRemove_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                toRemove_Click(this, new EventArgs());
                e.SuppressKeyPress = true; // Evitar som de "erro"
            }
        }

        private void toInsert_TextChanged(object sender, EventArgs e) {
            // pode ser útil no futuro
        }
        private void toRemove_TextChanged(object sender, EventArgs e) {
            // pode ser útil no futuro
        }

        int previousSelectedIndex = defaultHashTypeIndex; // garantir que selecionar a mesma opção não exiba a mensagem
        bool[] alreadySawMessage = new bool[2] { false, false }; // garantir que as mensagens só apareçam uma vez durante a exec. do programa.
        private void hashFunctionType_SelectedIndexChanged(object sender, EventArgs e) {
            int selected = hashFunctionType.SelectedIndex;
            if (selected == previousSelectedIndex)
                return;

            if (selected == 0) {
                if (!alreadySawMessage[0]) {
                    Output.PrintMessage(eventLog, "A função hash foi alterada para o método da divisão => h(x) = |x| mod 8.", true);
                    alreadySawMessage[0] = true;
                }
                else return;
                
                previousSelectedIndex = 0;
            }
            else if (selected == 1) {
                if (!alreadySawMessage[1]) {
                    Output.PrintMessage(eventLog, "A função hash foi alterada para garantir maior uniformidade (bit mixing).", true);
                    alreadySawMessage[1] = true;
                }
                else return;

                previousSelectedIndex = 1;
            }
        }
    }
}

