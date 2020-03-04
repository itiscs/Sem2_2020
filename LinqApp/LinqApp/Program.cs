using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{

    class Student 
    {
        public int Id { get; set; }
        public string Fio { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Id} {Fio} {Age}";
        }

        public static bool Met(Student s)
        {
            return s.Age < 20;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<Student>();
            lst.Add(new Student() { Id = 5, Fio = "Иванов", Age = 24 });
            lst.Add(new Student() { Id = 1, Fio = "Петров", Age = 15 });
            lst.Add(new Student() { Id = 2, Fio = "Марков", Age = 30 });
            lst.Add(new Student() { Id = 4, Fio = "Сидоров", Age = 18 });


            var newlst = lst.Where(st => st.Age < 20);

            foreach (var st in  newlst)
            {
                Console.WriteLine(st);
            }




        }
    }
}
