using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegApp
{
    class ArOper
    {
        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }

        public static void Hello1()
        {
            Console.WriteLine("Hello 1");
        }

        public static void Hello2()
        {
            Console.WriteLine("Hello 2");
        }


    }



    class Program
    {
        public delegate int Oper(int x, int y);
        delegate void Hello();

        static void Main(string[] args)
        {
            ArOper a = new ArOper();

            Oper op = new Oper(ArOper.Sum);
            
            Console.WriteLine(op(5, 3));

            //op = ArOper.Sub;
            //Console.WriteLine(op(5, 3));

            //op = a.Mult;
            //Console.WriteLine(op(5, 3));

            //op = ArOper.Div;
            //Console.WriteLine(op(5, 3));

            op = (x,y) => x - y;

            Console.WriteLine(op(5, 3));

            op = (x,y) => { return x * y;};

            Console.WriteLine(op(5, 3));
            
            op = (x, y) => x / y;

            Console.WriteLine(op(5, 3));


            Hello he = ArOper.Hello1;
            he += ArOper.Hello2;
            he += delegate ()
            {
                Console.WriteLine("Hello from anonym method");
            };

            he += () =>
            {
                Console.WriteLine("Hello from lambda");
            };
            
            //he -= ArOper.Hello2;
            //he -= ArOper.Hello1;

            he.Invoke();


        }

        public static int MyMethod(Oper op)
        {
            
            return 0;
        }


    }
}
