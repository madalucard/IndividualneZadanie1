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
        private int Id { get; }
        public string Company { get; set; }
        public string Model { get; set; }        
        public int YearOfRegistration { get; set; }
        public int Kilometers { get; set; }
        public int Price { get; set; }
        public Fuel _fuel;
        public string City { get; set; }
        public int Doors { get; set; }
        public bool Crashed { get; set; }

        
        public Car(int id, string company, string model, int year, int kms, int price, Fuel fuel, string city, int doors, bool crashed  )
        {

            Id = id;
            YearOfRegistration = year;
            Kilometers = kms;
            Company = company;
            Model = model;
            _fuel = fuel;
            Price = price;
            City = city;
            Doors = doors;
            Crashed = crashed;
        }

        public Car( string company, string model, int year, int kms, int price, Fuel fuel, string city, int doors, bool crashed)
        {

            Id = DatabaseManager._lastID;
            YearOfRegistration = year;
            Kilometers = kms;
            Company = company;
            Model = model;
            _fuel = fuel;
            Price = price;
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
                $"{Enum.GetName(_fuel.GetType(), _fuel)}\t" +
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
