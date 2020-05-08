using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriorityQueue
{
    public class Elem
    {
        public int Key { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return $"{Key} -- {Value}";
        }
    }

    public class PriorityQueue
    {

        private List<Elem> elems = new List<Elem>();

        public bool IsEmpty => elems.Count == 0;

        public void Insert(Elem elem)
        {
            elems.Add(elem);
            int i = elems.Count - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && elems[parent].Key < elems[i].Key)
            {
                var temp = elems[i];
                elems[i] = elems[parent];
                elems[parent] = temp;

                i = parent;
                parent = (i - 1) / 2;
            }
        }

        private void Heapify(int i)
        {
            int leftChild;
            int rightChild;
            int largestChild;
            while (true)
            {
                leftChild = 2 * i + 1;
                rightChild = 2 * i + 2;
                largestChild = i;

                if (leftChild < elems.Count &&
                    elems[leftChild].Key > elems[largestChild].Key)
                {
                    largestChild = leftChild;
                }

                if (rightChild < elems.Count &&
                    elems[rightChild].Key > elems[largestChild].Key)
                {
                    largestChild = rightChild;
                }

                if (largestChild == i)
                {
                    break;
                }

                var temp = elems[i];
                elems[i] = elems[largestChild];
                elems[largestChild] = temp;
                i = largestChild;
            }

        }


        public string Extract()
        {
            var extrValue = elems[0].Value;

            var temp = elems[0];
            elems[0] = elems[elems.Count-1];
            elems[elems.Count-1] = temp;
            elems.RemoveAt(elems.Count - 1);

            Heapify(0);
            return extrValue;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var el in elems)
                sb.Append($"{el}, ");
            return sb.ToString();
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            var pr = new PriorityQueue();
            pr.Insert(new Elem() { Key = 10, Value = "A" });
            pr.Insert(new Elem() { Key = 4, Value = "B" }); 
            pr.Insert(new Elem() { Key = 16, Value = "C" });
            pr.Insert(new Elem() { Key = 9, Value = "D" });
            pr.Insert(new Elem() { Key = 8, Value = "E" });
            pr.Insert(new Elem() { Key = 35, Value = "F" });

            Console.WriteLine(pr);
            if(! pr.IsEmpty)
              Console.WriteLine(pr.Extract());
            Console.WriteLine(pr);

            if (!pr.IsEmpty)
                Console.WriteLine(pr.Extract());

            Console.WriteLine(pr);

            if (!pr.IsEmpty)
                Console.WriteLine(pr.Extract());

            Console.WriteLine(pr);






        }
    }
}
