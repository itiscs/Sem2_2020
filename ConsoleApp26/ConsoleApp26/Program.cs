using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{

    class Student:IComparable
    {
        public int Id { get; set; }
        public string Fio { get; set; }

        public int Age { get; set; }
        public int CompareTo(object obj)
        {
            var st = obj as Student;
            var fl = Id.CompareTo(st.Id);
            if (fl == 0)
                return Fio.CompareTo(st.Fio);
            return fl;
        }

        public override string ToString()
        {
            return $"{Id} {Fio} {Age}";
        }


    }


    class Program
    {
        public static List<Student> lst = new List<Student>();
        delegate bool MyComparer(Student s1, Student s2); 


        static void Sort(MyComparer comp)
        {
            bool fl = true;
            while (fl)
            {
                fl = false;
                for (int i = 0; i < lst.Count - 1; i++)
                {
                    if (!comp.Invoke(lst[i], lst[i + 1]))
                    {
                        var st = lst[i];
                        lst[i] = lst[i + 1];
                        lst[i + 1] = st;
                        fl = true;
                    }
                }
            }

        }


        static void Main(string[] args)
        {



            //Console.WriteLine(lst.Length);

            //lst.AddLast(new Student() { Id = 5, Fio = "Ivanov 1" });

            //lst.AddLast(new Student() { Id = 1, Fio = "Ivanov 2" });
            //lst.AddLast(new Student() { Id = 1, Fio = "Ivanov 3" });
            //lst.AddLast(new Student() { Id = 4, Fio = "Ivanov 4" });

            lst.Add(new Student() { Id = 5, Fio = "Ivanov 10", Age=24 });
            lst.Add(new Student() { Id = 1, Fio = "Ivanov 2", Age = 15 });
            lst.Add(new Student() { Id = 2, Fio = "Ivanov 3", Age = 30 });
            lst.Add(new Student() { Id = 4, Fio = "Ivanov 4", Age = 18 });
            
            for (int i = 0; i < lst.Count; i++)
                Console.WriteLine(lst[i]);

           
            Console.WriteLine("***********************");

            Sort((s1, s2) =>  s1.Fio.CompareTo(s2.Fio) < 0 );


            for (int i = 0; i < lst.Count; i++)
                Console.WriteLine(lst[i]);


            //Console.WriteLine(lst);

            //lst.DeleteIndex(5);
            //lst.AddLast("a");
            //lst.AddLast("aaa");
            //lst.AddLast("aac");
            //lst.AddLast("aab");

            //Console.WriteLine(lst);

            //Console.WriteLine(lst.IsSorted());

        }
    }
}
