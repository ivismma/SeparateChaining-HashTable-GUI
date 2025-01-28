using System;
using System.Windows.Forms;

// essa parte da classe (Application.checkBox) lida com as checkboxes da interface
// e define o comportamento pelas interações com o usuário, inserção, remoção, checagem, etc.

namespace HashTableGUI {
    public partial class Application : Form {
        // inOrder: Inserção ordenada:
        private void InOrder_CheckedChanged(object sender, EventArgs e) {
            if (checkBox1.Checked == true) {
                ht.OrderedInsertion = true;
                Output.PrintMessage(eventLog, "As regras de inserção foram alteradas para manter as listas ordenadas.", true);
            }
            else {
                if (ht.ListsWithElements != 0) {
                    DialogResult dr = MessageBox.Show("Tem certeza que deseja desativar a inserção ordenada? Só será possível " +
                        "reativá-la novamente quando todas as listas não possuírem mais de um elemento.",
                        "Confirmação", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes) {
                        ht.OrderedInsertion = false;
                        checkBox1.Enabled = false; // Desabilitar uso da checkBox.
                        Output.PrintMessage(eventLog, "O método de inserção ordenada foi desativado.", true);
                    }
                    else {
                        // Manter ativada após mensagem de confirmação
                        checkBox1.Checked = true;
                    }
                }
                else {
                    ht.OrderedInsertion = false;
                    Output.PrintMessage(eventLog, "O método de inserção ordenada foi desativado.", true);
                }
            }
        }
    }
}
