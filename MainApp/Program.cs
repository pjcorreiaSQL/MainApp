﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number 1 (one):");
            int val1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 (two):");
            int val2 = int.Parse(Console.ReadLine());

            Console.WriteLine(MainLib.MainClass.BigMethod(val1, val2));
            Console.ReadLine();
        }
    }
}
