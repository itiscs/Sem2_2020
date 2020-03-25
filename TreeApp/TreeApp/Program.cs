﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tr = Tree.CreateTree();
            tr.Show();
            Console.WriteLine($"sum={tr.Sum()}");
            Console.WriteLine($"max={tr.Max()}");
        }
    }
}