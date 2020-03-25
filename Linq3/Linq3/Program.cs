using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            var lst = Fitness.GenerateData();

            double p = 0.1;

            var years = lst.GroupBy(f => f.Year).Select(g =>
                new
                {
                    Year = g.Key,
                    Sum = g.Sum(f => f.Duration),
                    Ms = g.GroupBy(f => f.Month)
                    .Select(h => new { Month = h.Key, SumMonth = h.Sum(k => k.Duration) })

                });



            foreach (var g in years)
            {
                Console.WriteLine($" {g.Year} {g.Sum}");
                foreach (var m in g.Ms)
                    Console.WriteLine($"    {g.Year} {m}");
            }


        }
    }
}
