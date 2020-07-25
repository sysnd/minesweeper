using System;
using System.Windows.Forms;

namespace Minesweeper.Forms
{
    static class Minesweeper
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectLevel());
        }
    }
}
