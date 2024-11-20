﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2_NHL_Players
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
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
        // User test
}
