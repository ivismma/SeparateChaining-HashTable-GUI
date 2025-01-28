using com.sun.tools.corba.se.idl;
using System;
using System.Windows.Forms;

namespace HashTableGUI
{
    public partial class Application : Form {
		// op <=> operação | 1 - inserção | 2 - remoção
		public int? GetInput(TextBox input, int op) {
			if (string.IsNullOrEmpty(input.Text))
				return null;

			int? value;
            string opMessage = (op == 1)? "inserir" : "remover";
			string message;

			try {
				value = Int32.Parse(input.Text);
			}
            catch (FormatException) {
                message = "Insira uma chave válida do tipo inteiro (Int32).";
                Output.PrintMessage(eventLog, "Não foi possível " + opMessage + " - " + message, true);
				return null;
            }
            catch (OverflowException) {
				message = "Int32 Overflow.";
                Output.PrintMessage(eventLog, "Não foi possível " + opMessage + " - " + message, true);
                return null;
            }

			return value;
		}

	}
}
