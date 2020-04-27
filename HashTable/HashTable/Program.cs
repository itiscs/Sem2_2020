using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Elem
    {
        public int Key { get; set; }
        public string Value { get; set; }

    }

    public class MyHashTable
    {
        public int Size { get; private set; }

        private List<Elem>[] mas;

        private Func<int, int> hashFunc;

        

        public MyHashTable(int size, Func<int,int> hash)
        {
            hashFunc = hash;
            Size = size;
            mas = new List<Elem>[Size];
        }

        public void Insert(Elem el)
        {
            var hash = hashFunc(el.Key) % Size; // Func
            var lst = mas[hash];
            if (lst == null)
            {
                lst = new List<Elem>();
                
            }
            lst.Add(el);
            mas[hash] = lst;
        }

        public Elem GetElem(int key)
        {
            var hash = hashFunc(key) % Size; // Func

            var lst = mas[hash];
            if (lst == null)
                throw new KeyNotFoundException();
            foreach(var el in lst)
            {
                if (el.Key == key)
                    return el;
            }
            throw new KeyNotFoundException();
        }
                              
        public void Show()
        {
            for(int i=0;i<Size;i++)
            {
                var lst = mas[i];
                if (lst == null)
                    Console.WriteLine(i);
                else
                {
                    Console.Write($"{i}--");
                    foreach (var el in lst)
                        Console.Write($"{el.Key} {hashFunc(el.Key)} {el.Value} ->");
                    Console.WriteLine();
                }
            }
        }

                          
    }

         
    class Program
    {
        static void Main(string[] args)
        {

            MyHashTable tbl = new MyHashTable(10, x=>(((x % 1000) * (x % 1000)) 
                                                        %1000)*2153%1000);

            tbl.Insert(new Elem() { Key = 52, Value = "rrrrrrrrrrr" });
            tbl.Insert(new Elem() { Key = 73, Value = "gggggg" });
            tbl.Insert(new Elem() { Key = 16, Value = "kkkkkkkkkk" });
            tbl.Insert(new Elem() { Key = 461, Value = "aaaaaaaa" });
            tbl.Insert(new Elem() { Key = 33349, Value = "bbbbbbbbbbb" });

            tbl.Show();

            var el = tbl.GetElem(73);
            Console.WriteLine($"{el.Key} {el.Value}");




        }
    }
}
