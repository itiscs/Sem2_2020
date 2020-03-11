using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = Fitness.GenerateData();


            var gr = lst.GroupBy(f => f.Year).Select(g =>
                    new
                    {
                        Year = g.Key,
                        Sum = g.Sum(f => f.Duration)
                    });

            var res = gr.Where(g => g.Sum == gr.Max(k => k.Sum))
                    .OrderBy(r=> r.Year).Take(1);



            foreach (var g in res)
            {
                Console.WriteLine(g);
                //Console.WriteLine(g.Key);
                //foreach (var f in g)
                //    Console.WriteLine($"      {f}");

            }




        }
    }
}
