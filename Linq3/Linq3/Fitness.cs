using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    public class Product
    {
        public string Category { get; set; }
        public int IdProduct { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Product - {IdProduct} {Category} {Country}";
        }
        
        public static List<Product> GenerateData()
        {
            var lst = new List<Product>();
            lst.Add(new Product() 
            { 
                IdProduct = 101, 
                Category = "A", 
                Country = "Canada" 
            });
            lst.Add(new Product()
            {
                IdProduct = 102,
                Category = "A",
                Country = "Russia"
            });
            lst.Add(new Product()
            {
                IdProduct = 103,
                Category = "B",
                Country = "Russia"
            });
            lst.Add(new Product()
            {
                IdProduct = 104,
                Category = "A",
                Country = "China"
            });
            lst.Add(new Product()
            {
                IdProduct = 105,
                Category = "B",
                Country = "China"
            });
            lst.Add(new Product()
            {
                IdProduct = 106,
                Category = "B",
                Country = "China"
            });
            lst.Add(new Product()
            {
                IdProduct = 107,
                Category = "C",
                Country = "China"
            });

            return lst;
        }

    }

    public class Prices
    {
        public int IdProduct { get; set; }
        public int Price { get; set; }
        public string Shop { get; set; }

        public override string ToString()
        {
            return $"Price - {IdProduct} {Shop} {Price}";
        }

        public static List<Prices> GenerateData()
        {
            var lst = new List<Prices>();

            lst.Add(new Prices() { IdProduct = 101, 
                Shop = "Ашан", Price = 100 });
            lst.Add(new Prices() { IdProduct = 102, 
                Shop = "Магнит", Price = 10 }); 
            lst.Add(new Prices() { IdProduct = 104, 
                Shop = "Магнит", Price = 20 }); 
            lst.Add(new Prices() { IdProduct = 105, 
                Shop = "Пятерочка", Price = 40 }); 
            lst.Add(new Prices() { IdProduct = 101, 
                Shop = "Пятерочка", Price = 50 }); 
            lst.Add(new Prices() { IdProduct = 102, 
                Shop = "Пятерочка", Price = 300 });
            lst.Add(new Prices()
            {
                IdProduct = 101,
                Shop = "Пятерочка",
                Price = 60
            });
            lst.Add(new Prices()
            {
                IdProduct = 102,
                Shop = "Пятерочка",
                Price = 80
            });
            lst.Add(new Prices()
            {
                IdProduct = 101,
                Shop = "Перекресток",
                Price = 70
            });
            lst.Add(new Prices()
            {
                IdProduct = 107,
                Shop = "Перекресток",
                Price = 60
            });
            lst.Add(new Prices()
            {
                IdProduct = 207,
                Shop = "Перекресток",
                Price = 160
            });



            return lst;
        }


    }
    

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
