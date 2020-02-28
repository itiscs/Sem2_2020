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
            return $"{Id} {Fio}";
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            
            MyList<Student> lst = new MyList<Student>();

            Console.WriteLine(lst.Length);

            lst.AddLast(new Student() { Id = 5, Fio = "Ivanov 1" });

            lst.AddLast(new Student() { Id = 1, Fio = "Ivanov 2" });
            lst.AddLast(new Student() { Id = 1, Fio = "Ivanov 3" });
            lst.AddLast(new Student() { Id = 4, Fio = "Ivanov 4" });

            //for (int i = 0; i < 10; i++)
            //    lst.AddLast(i.ToString());

            Console.WriteLine(lst);

            //lst.DeleteIndex(5);
            //lst.AddLast("a");
            //lst.AddLast("aaa");
            //lst.AddLast("aac");
            //lst.AddLast("aab");

            //Console.WriteLine(lst);

            Console.WriteLine(lst.IsSorted());

        }
    }
}
