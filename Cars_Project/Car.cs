using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Project
{
    public enum Fuel
    {
        Benzin,
        Diesel,
        Plyn,
        Elekrika
    }
    class Car
    {
        public int Id { get; private set; }
        public string Company { get; set; }
        public string Model { get; set; }        
        public int YearOfRegistration { get; set; }
        public int Kilometers { get; set; }
        public int Price { get; set; }
        public Fuel Fuel { get; set; }
        public string City { get; set; }
        public int Doors { get; set; }
        public bool Crashed { get; set; }


        
        public Car(int id, string company, string model, int year, int kms, int price, Fuel fuel, string city, int doors, bool crashed  )
        {

            Id = id;
            Company = company;
            Model = model;
            YearOfRegistration = year;
            Kilometers = kms;
            Price = price;
            Fuel = fuel;
            City = city;
            Doors = doors;
            Crashed = crashed;
        }

        public Car( string company, string model, int year, int kms, int price, Fuel fuel, string city, int doors, bool crashed)
        {

            Id = DatabaseManager._lastID;
            Company = company;
            Model = model;
            YearOfRegistration = year;
            Kilometers = kms;
            Price = price;
            Fuel = fuel;
            City = city;
            Doors = doors;
            Crashed = crashed;
        }

        public string DescribeMe()
        {
            StringBuilder sb = new StringBuilder();
            // DescribeMe in one line (clean version)
            sb.AppendLine(
                $"{Id}\t" +
                $"{Company}\t" +
                $"{Model}\t" +
                $"{YearOfRegistration}\t" +
                $"{Kilometers}\t" +
                $"{Price}\t" +
                $"{Enum.GetName(Fuel.GetType(), Fuel)}\t" +
                $"{City}\t" +
                $"{Doors}\t" +
                $"{Crashed}");
            
            #region vypisy
            //// DescribeMe in one line
            //sb.AppendLine(
            //    $"Car - Id: {Id}, " +
            //    $"Year: {YearOfRegistration}, " +
            //    $"Kilometers: {Kilometers}, " +
            //    $"Company: {Company}, " +
            //    $"Model: {Model}, " +
            //    $"Fuel: {Enum.GetName(_fuel.GetType(), _fuel)}: " +
            //    $"Price: {Price}, " +
            //    $"City: {City}, " +
            //    $"Doors: {Doors}, " +
            //    $"Crashed: {Crashed}.");
            //// DescribeMe structured 
            //sb.AppendLine(
            //   $"Car:- Id: {Id}, \n" +
            //   $"Year: {YearOfRegistration}, \n" +
            //   $"Kilometers: {Kilometers}, \n" +
            //   $"Company: {Company}, \n" +
            //   $"Model: {Model}, \n" +
            //   $"Fuel: {Enum.GetName(_fuel.GetType(), _fuel)}: \n" +
            //   $"Price: {Price}, \n" +
            //   $"City: {City}, \n" +
            //   $"Doors: {Doors}, \n" +
            //   $"Crashed: {Crashed}.\n");
            #endregion

            return sb.ToString();
        }
        public override string ToString()
        {
            return DescribeMe();
        }

    }
}
