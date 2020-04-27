using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{

    public class PowerStation
    {
        private string Name  { get; set; }
        private int CurrentTemp { get; set; }
        private int MaxTemp { get; set; }

        public event Action<string> Boom;

        public PowerStation(string pname, int cur, int max)
        {
            Name = pname;
            CurrentTemp = cur;
            MaxTemp = max;
        }

        public void TempUp()
        {
            CurrentTemp += 100;
            if (CurrentTemp > MaxTemp)
            {
                Boom(Name);
                throw new Exception("Stop");
            }
        }

        public void TempDown()
        {
            if (CurrentTemp > 100)
                CurrentTemp -= 100;
            else
                CurrentTemp = 0;
        }

        public override string ToString()
        {
            return $"{Name} Current - {CurrentTemp}  Max - {MaxTemp}";
        }                          
    }

    public class FireFighters
    {
        public static void Work(string stationName)
        {
            Console.WriteLine($"Пожарные едут в {stationName}!!!");
        }

    }

    public class Ambulance
    {
        public static void Work(string stationName)
        {
            Console.WriteLine($"Скорая помощь едет в {stationName}!!!");
        }

    }
    public class Police
    {
        public static void Work(string stationName)
        {
            Console.WriteLine($"Полиция едет в {stationName}!!!");
        }

    }




}
