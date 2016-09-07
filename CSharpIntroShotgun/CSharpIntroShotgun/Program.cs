using System;
using System.Windows.Forms;

namespace Shotgun {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //public static bool isClosing = false;
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
