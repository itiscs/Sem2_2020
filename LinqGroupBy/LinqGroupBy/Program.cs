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
                        Sum = g.Sum(f => f.Duration),
                        MonthsCount = g.Select(f=>f.Month).Distinct().Count()
                    }) ;

            int max = gr.Max(k => k.Sum);

            //var res = gr.Where(g => g.Sum == max)
            //    .OrderBy(r=> r.Year).Take(1);

            var res = lst.GroupBy(l => new { l.Year, l.ClientId })
                .Select(g => new
                {
                    g.Key.Year,
                    g.Key.ClientId,
                    Count = g.Count(),
                    Average = g.Average(f => f.Duration)
                });

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
