using Assignment2_NHL_Players.Forms;
using System;
using System.Windows.Forms;

namespace Assignment2_NHL_Players
{
    internal static class Program
    {
        /// <summary>
        /// The application's entry point
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

