using Assignment2_NHL_Players.Forms;
using System;
using System.Windows.Forms;

namespace Assignment2_NHL_Players
{
    internal static class Program
    {
        /// <summary>
        /// O ponto de entrada da aplicacao
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    public class Player
    {
    public string PlayerName { get; set; }
    public string Team { get; set; }
    public string Pos { get; set; }
    public int GP { get; set; }  // Games Played
    public int G { get; set; }   // Goals
    public int A { get; set; }   // Assists
    }
}

