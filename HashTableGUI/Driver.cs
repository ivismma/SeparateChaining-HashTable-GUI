using System;

namespace HashTableGUI {
    internal static class Driver
    {
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            Application programWindow = Application.Instance;
            System.Windows.Forms.Application.Run(programWindow);
        }
    }
}