using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{

    



    class Program
    {
        static void Main(string[] args)
        {

            MyList lst = new MyList();

            Console.WriteLine(lst.Length);

            for (int i = 0; i < 11; i++)
                lst.AddLast(i);

            Console.WriteLine(lst);

            lst.DeleteIndex(5);

            Console.WriteLine(lst);

        }
    }
}
