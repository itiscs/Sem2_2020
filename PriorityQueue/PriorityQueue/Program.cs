using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class Elem
    {
        public int Priority { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Priority} -- {Value}";
        }

    }
   
    public class PriorityQueue
    {
        private List<Elem> lst = new List<Elem>();

        private int HeapSize => lst.Count;

        public bool IsEmpty => HeapSize == 0;

        public void Insert(Elem el)
        {
            lst.Add(el);

            int i = HeapSize - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && 
                lst[parent].Priority < lst[i].Priority)
            {
                var temp = lst[i];
                lst[i] = lst[parent];
                lst[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }
        }

        public Elem Extract()
        {
            if (IsEmpty)
                throw new IndexOutOfRangeException("Queue is empty!");

            var result = new Elem()
            {
                Priority = lst[0].Priority,
                Value = lst[0].Value
            };
            lst[0] = lst[HeapSize - 1];
            lst.RemoveAt(HeapSize - 1);
            Heapify(0);

            return result;
        }       

        public void Heapify(int i)
        {
            int leftChild;
            int rightChild;
            int largestChild;

            while(true)
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;

                if (leftChild < HeapSize && 
                    lst[leftChild].Priority > lst[largestChild].Priority)
                {
                    largestChild = leftChild;
                }

                if (rightChild < HeapSize && 
                    lst[rightChild].Priority > lst[largestChild].Priority)
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                var temp = lst[i];
                lst[i] = lst[largestChild];
                lst[largestChild] = temp;
                
                i = largestChild;
            }
        }

        public override string ToString()
        {
            int i = 1,k=0;
            var sb = new StringBuilder();
            foreach(var el in lst)
            {
                sb.Append($"{el},  ");
                k++;
                if(k==i)
                {
                    sb.AppendLine();
                    i *= 2;
                    k = 0;
                }
            }
            return sb.ToString();
        }

    }


    public class Program
    {
        public static void Main()
        {
            var pr = new PriorityQueue();
            Console.WriteLine(pr.Extract().Value);

            pr.Insert(new Elem() { Priority = 10, Value = "A" });
            pr.Insert(new Elem() { Priority = 6, Value = "B" });
            pr.Insert(new Elem() { Priority = 17, Value = "C" });
            pr.Insert(new Elem() { Priority = 150, Value = "D" });
            pr.Insert(new Elem() { Priority = 62, Value = "E" });
            pr.Insert(new Elem() { Priority = 3, Value = "F" });
            pr.Insert(new Elem() { Priority = 15, Value = "G" });
            pr.Insert(new Elem() { Priority = 36, Value = "H" });
            pr.Insert(new Elem() { Priority = 1, Value = "I" });

            Console.WriteLine(pr);

            Console.WriteLine(pr.Extract().Value);
            Console.WriteLine(pr);
            
            Console.WriteLine(pr.Extract().Value);
            Console.WriteLine(pr);
            pr.Insert(new Elem() { Priority = 16, Value = "K" });
            Console.WriteLine(pr);

            Console.WriteLine(pr.Extract().Value);
            Console.WriteLine(pr);
        }
    }
}
