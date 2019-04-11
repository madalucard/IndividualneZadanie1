using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Project
{
    class CarRepository
    {
        private static List<Car> _carDetails = new List<Car>();
        private const string CONNECTION_STRING = "Server=TRANSFORMER3\\SQLEXPRESS2016;Database=Autobazar;Trusted_Connection=True;";





        public static List<Car> GetAll()
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                Console.WriteLine("Connection to database opened.");
                using (SqlCommand command = connection.CreateCommand())
                {
                    Console.WriteLine("Downloading Database.");
                    command.CommandText = @"select	id, Company, Model, YearOfRegistration, Kilometers, Price, Fuel, City, Doors, Crashed
                                            from Car";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Car newCar = new Car(reader.GetInt32(0),
                                                    reader.GetString(1),
                                                    reader.GetString(2),
                                                    reader.GetInt32(3),
                                                    reader.GetInt32(4),
                                                    reader.GetInt32(5),
                                                    (Fuel)Enum.ToObject(typeof(Fuel), reader.GetInt32(6)),
                                                    reader.GetString(7),
                                                    reader.GetInt32(8),
                                                    reader.GetBoolean(9));
                            _carDetails.Add(newCar);
                        }




                    }


                    Console.WriteLine("Connection to database Closed.");
                }

                return _carDetails;
            }



            //public int AddNewCar(Car car)
            //{ } 


        }
    }
