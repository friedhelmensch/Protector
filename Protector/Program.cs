using System;
using System.Windows.Forms;

namespace Protector
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Test 2
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
