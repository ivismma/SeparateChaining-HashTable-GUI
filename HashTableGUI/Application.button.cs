using System;
using System.Windows.Forms;

namespace HashTableGUI
{
    public partial class Application : Form{

        private bool AlreadyTriedToClear = true; // evitar spam de mensagens ao clicar repetidas vezes
        // Reinicialização/Limpeza:
        public bool AlreadyClear {
            get { return AlreadyTriedToClear; }
            set { AlreadyTriedToClear = value; }
        }
        
        private void clear_Click(object sender, EventArgs e) {
            if (!AlreadyTriedToClear) {
                ht.Clear();
                AlreadyTriedToClear = true;
            }
        }

        // Inserção:
        private void toInsert_Click(object sender, EventArgs e){
            int? value = GetInput(toInsert, 1);
            if (!value.HasValue)
                return;

            bool success = ht.Insert(value.Value);
            if (success)
                Output.PrintEvent(1, value.Value, eventLog, true);
            else
                Output.PrintEvent(1, value.Value, eventLog, false);
            toInsert.Text = string.Empty;
        }

        // Remoção:
        private void toRemove_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(toRemove.Text))
                return;

            int? value = GetInput(toRemove, 2);
            if (!value.HasValue)
                return;

            bool success = ht.Remove(value.Value);
            if (success)
                Output.PrintEvent(2, value.Value, eventLog, true);
            else
                Output.PrintEvent(2, value.Value, eventLog, false);

            toRemove.Text = string.Empty;
        }
    }
}
