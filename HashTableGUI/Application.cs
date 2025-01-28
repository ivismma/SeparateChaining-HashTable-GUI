using System;
using System.Windows.Forms;

namespace HashTableGUI
{
    public partial class Application : Form {
        private static Application instance;
        // singleton
        public static Application Instance {
            get {
                if (instance == null) {
                    instance = new Application();
                    return instance;
                }
                else return instance;
            }
        }

        private readonly HashTable ht;
        private readonly TextBox[] IndexInfo;
        private const int defaultHashTypeIndex = 0; // definir var. p/ o método hash padrão (inicializado no programa)
        private Output printer;
        public Output getPrinter(Object obj) {
            if (obj is HashTable)
                return printer;
            else
                throw new UnauthorizedAccessException();
        }

        private Application() {
            InitializeComponent();
            IndexInfo = new TextBox[8] // p/ iterar sobre a exibição dos encadeamentos
            { index0, index1, index2, index3, index4, index5, index6, index7 };
            Output.PrintMessage(eventLog, "Tabela e componentes inicializados.", true);

            // obs: printer precisa ser alocado antes da hash table, pois hash table depende do printer.
            printer = new Output(this);
            Output.PrintMessage(eventLog, "Instância do Output inicializada.", true);
            ht = new HashTable(this);
        }

        private void App_Load(object sender, EventArgs e) {
            hashFunctionType.SelectedIndex = defaultHashTypeIndex;
        }

        public TextBox getLog() {
            return eventLog;
        }

        public TextBox[] getInfo(Object obj) {
            if (obj is Output)
                return IndexInfo;
            else
                throw new UnauthorizedAccessException();
        }
    }
}