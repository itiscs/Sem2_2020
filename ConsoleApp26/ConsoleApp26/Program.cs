using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{

    public class Elem
    {
        public int Info { get; set; }
        public Elem Next { get; set; }

    }

    public class MyList
    {
        public Elem Head { get; set; }

        public int Length
        {
            get
            {
                //TODO
                return 0;
            }
        }

        public void AddFirst(int x)
        {
            var newElem = new Elem();
            newElem.Info = x;
            newElem.Next = Head;
        
            Head = newElem;
        }

        public void AddLast(int x)
        {
            if (Head == null)
                Head = new Elem() { Info = x };
            else
            {
                var el = Head;
                while (el.Next != null)
                    el = el.Next;

                var newElem = new Elem() { Info = x };
                el.Next = newElem;
            }
        }




        public void AddAfterIndex(int ind, int x)
        {
            throw new NotImplementedException();
        }

        public void DeleteValue(int x)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted()
        {
            throw new NotImplementedException();
        }


        public void DeleteIndex(int k)
        {
            if (Head == null)
                throw new ArgumentOutOfRangeException();

            if (k==0)
            {
                Head = Head.Next;
                return;
            }

            var el = Head;
            for(int i = 0; i < k-1; i++)
            {
                if(el.Next == null)
                    throw new ArgumentOutOfRangeException();
                el = el.Next;
            }

            if (el.Next == null)
                throw new ArgumentOutOfRangeException();
            el.Next = el.Next.Next;

        }


        



        public override string ToString()
        {
            var sb = new StringBuilder();
            var el = Head;
            while (el != null)
            {
                sb.Append($"{el.Info} -> ");
                el = el.Next;
            }
            sb.Append("null");
            return sb.ToString();
        }



      
        

    }


    



    class Program
    {
        static void Main(string[] args)
        {
            MyList lst = new MyList();

            for (int i = 0; i < 10; i++)
                lst.AddLast(i);

            Console.WriteLine(lst);


            Console.WriteLine(lst);




        }
    }
}
