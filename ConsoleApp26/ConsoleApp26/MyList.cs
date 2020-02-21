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
        public Elem Head {get; set; }

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
            Elem elem = new Elem();
            elem.Info = x;
            elem.Next = Head;
            Head = elem;
        }

        public void AddLast(int x)
        {
            if(Head == null)
            {
                Head = new Elem() { Info = x };
                return;
            }

            var elem = Head;
            while (elem.Next != null)
            {
                elem = elem.Next;
            }
            Elem newEl = new Elem() { Info = x };
            elem.Next = newEl;

        }

        public void AddAfterK(int k, int x)
        {
            throw new NotImplementedException();
        }

        public void DeleteIndex(int k)
        {
            if (Head == null)
                throw new IndexOutOfRangeException($"в списке отсутствует {k} элемент");
            if( k == 0 )
            {
                Head = Head.Next;
                return;
            }
            var elem = Head;
            for(int i = 0; i < k-1; i++)
            {
                if (elem == null)
                    throw new IndexOutOfRangeException($"в списке отсутствует {k} элемент");
                elem = elem.Next;

            }
            if (elem.Next == null)
                throw new IndexOutOfRangeException($"в списке отсутствует {k} элемент");
            elem.Next = elem.Next.Next;

        }

        public void DeleteValue(int x)
        {
            throw new NotImplementedException();
        }


        public bool IsSorted()
        {
            throw new NotImplementedException();
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            var elem = Head;
            while(elem != null)
            {
                sb.Append($"{elem.Info} -> ");
                elem = elem.Next;
            }
            sb.Append("null");
            return sb.ToString();
        }



    }
}
