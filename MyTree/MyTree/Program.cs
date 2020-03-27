using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{  
    class Program
    {
        static void Main(string[] args)
        {
            MyTree tr = MyTree.CreateTree();
            tr.ShowTree();
            Console.WriteLine(tr.Sum());
            Console.WriteLine(tr.Min());

        }
    }
}
