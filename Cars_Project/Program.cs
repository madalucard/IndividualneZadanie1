using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Project
{
    class Program
    {
        static void Main(string[] args)
        {

            DatabaseManager.LoadDatabase();

            //DatabaseManager.CarRemove(10);

            //DatabaseManager.CarAdd("Skoda", "Otavia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            DatabaseManager.CarAdd("Skoda", "Fabia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            DatabaseManager.CarAdd("Skoda", "Otavia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Otavia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Otavia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);

            //Car c = new Car("Skoda", "Otavia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //Console.WriteLine(c.DescribeMe());

            Console.ReadLine();
        }
    }
}


    