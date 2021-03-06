﻿using System;
using static System.Console;


namespace yt_dl
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] argus = new string[2];
            if (Environment.GetCommandLineArgs().Length == 1)
            {
                argus[0] = Environment.GetCommandLineArgs()[0];
                argus[1] = null;
            }
            else if (Environment.GetCommandLineArgs().Length == 2)
            {
                argus = Environment.GetCommandLineArgs();
            }

            if (argus[1] == "--help" || argus[1] == "-h" || argus[1] == "-?")
            {
                Call.Help();
                Environment.Exit(0);
            }
            else if (argus[1] == null)
            {
                Menu menu = new Menu();

                menu.Start();
                Environment.Exit(0);
            }
            else if (argus[1] == "--paths" || argus[1] == "-p")
            {
                Call.Paths();
            }
            else
            {
                WriteLine("Neplatný argument: {1}", argus[1]);
                Call.Help();
                Environment.Exit(0);
            }
        }


    }
}
