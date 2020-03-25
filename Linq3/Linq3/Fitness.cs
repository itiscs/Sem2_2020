using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    public class Fitness
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Duration { get; set; }
        public int ClientId { get; set; }

        public override string ToString()
        {
            return $"{Year} {Month} {Duration} {ClientId}";
        }


        public static List<Fitness> GenerateData()
        {
            var lst = new List<Fitness>();
            lst.Add(new Fitness() { Year = 2020, Month = 1, ClientId = 101, Duration = 20 });
            lst.Add(new Fitness() { Year = 2020, Month = 1, ClientId = 102, Duration = 25 });
            lst.Add(new Fitness() { Year = 2020, Month = 2, ClientId = 103, Duration = 30 });
            lst.Add(new Fitness() { Year = 2020, Month = 3, ClientId = 101, Duration = 40 });
            lst.Add(new Fitness() { Year = 2020, Month = 3, ClientId = 102, Duration = 15 });
            lst.Add(new Fitness() { Year = 2019, Month = 1, ClientId = 103, Duration = 22 });
            lst.Add(new Fitness() { Year = 2019, Month = 2, ClientId = 101, Duration = 10 });
            lst.Add(new Fitness() { Year = 2019, Month = 2, ClientId = 102, Duration = 50 });
            lst.Add(new Fitness() { Year = 2018, Month = 1, ClientId = 101, Duration = 120 });

            return lst;
        }


    }
}
