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
            string decision = null;
            int idForUpdate = int.MinValue;
            Car tempCar = null;

            DatabaseManager.LoadDatabase();


            Console.WriteLine("Do you want update car parameters?");
            Console.WriteLine("Press 'y/Y' for YES, 'n/N' for NO");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                while (true)
                {
                    Console.WriteLine("Writes car's Id for update");
                    //int.TryParse(Console.ReadLine(), out idForUpdate);
                    if (int.TryParse(Console.ReadLine(), out idForUpdate))
                    {
                        tempCar = DatabaseManager.CarFindById(idForUpdate);
                        Console.WriteLine("You select this car");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        Console.WriteLine($"{tempCar.DescribeMe()}");
                        Console.WriteLine("-------------------------------------------------------------------------------------------------");
                        //  Control of Id return if it is number or null
                        if (tempCar != null)
                        {
                            break;
                        }
                        Console.WriteLine("We dont have car with this Id in database");
                    }
                }
            }


            Console.WriteLine("Do you want to update Company?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What is your name of new Company?");
                tempCar.Company = Console.ReadLine();
            }

            Console.WriteLine("Do you want to update Model?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What is your name of new Model?");
                tempCar.Model = Console.ReadLine();

            }

            Console.WriteLine("Do you want to update Years?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What is the new Years?");
                int tempInt = 0;
                while (!(int.TryParse(Console.ReadLine(), out tempInt)))
                {
                    Console.WriteLine("You need to insert NUMBER value");
                }
                tempCar.YearOfRegistration = tempInt;
            }

            Console.WriteLine("Do you want to update Kilometers?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What are the new Kilometers?");
                int tempInt = 0;
                while (!(int.TryParse(Console.ReadLine(), out tempInt)))
                {
                    Console.WriteLine("You need to insert NUMBER value");
                }
                tempCar.Kilometers = tempInt;
            }

            Console.WriteLine("Do you want to update Price?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What is the new Price?");
                int tempInt = 0;
                while (!(int.TryParse(Console.ReadLine(), out tempInt)))
                {
                    Console.WriteLine("You need to insert NUMBER value");
                }
                tempCar.Price = tempInt;
            }
            Console.WriteLine("Do you want to update Fuel?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What is the new type of fuel?");
                tempCar.Fuel = (Fuel)Enum.Parse(typeof(Fuel), Console.ReadLine(), true);
            }

            Console.WriteLine("Do you want to update City?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What is the new city name?");
                tempCar.City = Console.ReadLine();                
            }

            Console.WriteLine("Do you want to update Doors?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("How much doors have your car?");
                int tempInt = 0;
                while (!(int.TryParse(Console.ReadLine(), out tempInt)))
                {
                    Console.WriteLine("You need to insert NUMBER value");
                }
                tempCar.Doors = tempInt;
            }

            Console.WriteLine("Do you want to update Crashed?");
            Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
            if ((decision = Console.ReadLine()) == "y" || (decision = Console.ReadLine()) == "Y")
            {
                Console.WriteLine("What is new state of car. Is it crashed?");
                Console.WriteLine("Press 'y/Y' for YES, or ENTER for next");
                string crashedDecision;
                if ((crashedDecision = Console.ReadLine()) == "y" || (crashedDecision = Console.ReadLine()) == "Y")
                {
                    tempCar.Crashed = true;
                }
                tempCar.Crashed = false;
            }
            





            //DatabaseManager.CarAdd("Skoda", "Superb", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Fabia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Otavia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Kodiak", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "CityGo", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Favorit", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Karoq", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);
            //DatabaseManager.CarAdd("Skoda", "Octavia", 1993, 280000, 2500, Fuel.Benzin, "Krasno nad Kysucou", 5, false);

            //DatabaseManager.CarRemove(2);

            DatabaseManager.RefreshDatabase();

            Console.ReadLine();
        }
    }
}


