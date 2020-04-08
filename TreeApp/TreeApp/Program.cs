using System;
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
            //Tree tr = new Tree("(1,(2,4,5),(3,,6))");
            //tr.Show();
            //Console.WriteLine($"sum={tr.Sum()}");
            //Console.WriteLine($"max={tr.Max()}");

            SearchTree st = new SearchTree(10);
            st.Show();
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(st.Contains(x));
        }
    }
}
