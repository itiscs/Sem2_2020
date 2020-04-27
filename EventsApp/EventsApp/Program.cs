using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PowerStation ps2 = new PowerStation("Station 2", 100, 1000);
            ps2.Boom += FireFighters.Work;
            ps2.Boom += Ambulance.Work;
            ps2.Boom += Police.Work;


            for (int i=0; i<20; i++)
            {
                ps2.TempUp();
                Console.WriteLine(ps2);
            }



        }
    }
}
