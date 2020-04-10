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



            //foreach (var g in years)
            //{
            //    Console.WriteLine($" {g.Year} {g.Sum}");
            //    foreach (var m in g.Ms)
            //        Console.WriteLine($"    {g.Year} {m}");
            //}

            var prods = Product.GenerateData();
            var prices = Prices.GenerateData();

            //var result = prods.Join(prices,
            //    prod => prod.IdProduct,
            //    pric => pric.IdProduct,
            //    (prod, pric) => new
            //    {
            //        ID = prod.IdProduct,
            //        prod.Category,
            //        prod.Country,
            //        pric.Shop,
            //        pric.Price
            //    });

            var result = prices.Join(prods,
                pric => pric.IdProduct,
                prod => prod.IdProduct,
                (pric, prod) => new
                {
                    ID = prod.IdProduct,
                    prod.Category,
                    prod.Country,
                    pric.Shop,
                    pric.Price
                })
                .GroupBy(r => r.Country)
                .Select(g => new
                {
                    Country = g.Key,
                    Count = g.Select(f => f.Shop).Distinct().Count(),
                    Min = g.Min(f=>f.Price)
                });


            foreach (var r1 in result)
            {
                Console.WriteLine(r1);
            }


            foreach (var pr in prods)
            {
                if (prods.Select(p1 => p1.IdProduct)
                    .Except(prices.Select(pr1 => pr1.IdProduct))
                    .Contains(pr.IdProduct))
                    Console.WriteLine(pr);
            }






        }
    }
}
