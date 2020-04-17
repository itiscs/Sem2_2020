﻿using System;
using System.Collections.Generic;
using System.Linq;
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

        public MyHashTable(int size)
        {
            Size = size;
            mas = new List<Elem>[Size];
        }

        public void Insert(Elem el)
        {
            var hash = el.Key.GetHashCode() * 1117 % Size; // Func
            var lst = mas[hash];
            if (lst == null)
               lst = new List<Elem>();                
            lst.Add(el);
            mas[hash] = lst;
        }

        public Elem GetElem(int key)
        {
            var hash = key.GetHashCode() * 1117 % Size; // Func
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
                        Console.Write($"{el.Key} {el.Key.GetHashCode()} {el.Value} ->");
                    Console.WriteLine();
                }
            }
        }






    }





    class Program
    {
        static void Main(string[] args)
        {

            MyHashTable tbl = new MyHashTable(10);
            tbl.Insert(new Elem() { Key = 5, Value = "rrrrrrrrrrr" });
            tbl.Insert(new Elem() { Key = 7, Value = "gggggg" });
            tbl.Insert(new Elem() { Key = 1, Value = "kkkkkkkkkk" });
            tbl.Insert(new Elem() { Key = 46, Value = "aaaaaaaa" });
            tbl.Insert(new Elem() { Key = 333349, Value = "bbbbbbbbbbb" });

            tbl.Show();

            var el = tbl.GetElem(1);
            Console.WriteLine($"{el.Key} {el.Value}");




        }
    }
}