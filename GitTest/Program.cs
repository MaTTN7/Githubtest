﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papousek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zdar,jsem virtuální papoušek Sára, ráda opakuji");
            Console.WriteLine("Napiš něco: ");
            string vstup;
            vstup = Console.ReadLine();
            string vystup;
            vystup = vstup + ", " + vstup + "!";
            Console.WriteLine(vystup);
            Console.ReadKey();
        }
    }
}