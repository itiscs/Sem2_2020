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
            //MyTree tr = MyTree.CreateTree();
            MyTree tr = new MyTree("(145,(23,-4,(56,8,)),(3,6,7))");
            tr.ShowTree();
            Console.WriteLine(tr.Sum());
            Console.WriteLine(tr.Min());

        }
    }
}
