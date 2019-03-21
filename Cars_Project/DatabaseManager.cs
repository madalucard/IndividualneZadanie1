using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Project
{
    class DatabaseManager
    {
        private static string _filePath = "CarDatabase.txt";
        public static string[] Lines { get; set; }
        private static List<String> _carDatabaseString = new List<string>();     //nahrada string[] Lines;
        private static List<Car> _carDetails = new List<Car>();
        private static int _idTemp;
        public static int _lastID;

        public static void LoadDatabase()
        {
            //using (FileStream fs = File.Open(_filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            using (File.Open(_filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {                
            }

            _carDatabaseString = File.ReadAllLines(_filePath).ToList();
            _lastID = 0;
            foreach (string l in _carDatabaseString)
            {
                // Parste data from database file to List<Car>
                char[] separator = { '\t' };
                string[] temp = l.Split(separator);
                int id = int.Parse(temp[0]);
                string company = temp[1];
                string model = temp[2];
                int year = int.Parse(temp[3]);
                int kms = int.Parse(temp[4]);
                int price = int.Parse(temp[5]);
                Fuel fuel = (Fuel)Enum.Parse(typeof(Fuel), temp[6]);
                string city = temp[8];
                int doors = int.Parse(temp[9]);
                bool crashed = bool.Parse(temp[10]);

                Car car = new Car(id, company, model, year, kms, price, fuel, city, doors, crashed);
                _lastID = int.Parse(temp[0]);                               
            }
        }
        public static void CarAdd( string company, string model, int year, int kms, int price, Fuel fuel, string city, int doors, bool crashed)
        {

            Car c = new Car(_lastID, company, model, year, kms, price, fuel, city, doors, crashed);
            _carDetails.Add(c);
            _lastID++;
            foreach (var item in _carDetails)
            {
                File.AppendAllText(_filePath, item.ToString());
            }
            //File.AppendAllText(_filePath,c.ToString());
            ////Refresh Lines in program memory after ADDING
            //Lines = File.ReadAllLines(_filePath);
        }
        //public static void CarAdd(int id ,string company, string model, int year, int kms, int price, Fuel fuel, string city, int doors, bool crashed)
        //{

        //    Car c = new Car(id,company, model, year, kms, price, fuel, city, doors, crashed);
        //    File.AppendAllText(_filePath, c.DescribeMe());
        //    //Refresh Lines in program memory after ADDING
        //    Lines = File.ReadAllLines(_filePath);
        //}


        #region stary kod
        //public static int CheckId()

        //{
        //    using (FileStream fs = File.Open(_filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        //    { }
        //    carDatabase = File.ReadAllLines(_filePath).ToList();
        //    // Lines = File.ReadAllLines(_filePath);


        //    //try
        //    //{
        //    //using (FileStream fs = File.Open(_filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        //    //{

        //    //        Lines = File.ReadAllLines(_filePath);

        //    //        //byte[] array = new byte[fs.Length];
        //    //        //fs.Read(array, 0, array.Length);
        //    //        //string result1 = System.Text.Encoding.UTF8.GetString(array);
        //    //    }

        //    //}
        //    //catch (Exception e)
        //    //{

        //    //    Console.WriteLine(e.Message);
        //    //}
        //    //looking for last index in LINES
        //    foreach (string l in Lines)
        //        {
        //            char[] separator = { '\t' };
        //            string[] temp = l.Split(separator);
        //            _idTemp = int.Parse(temp[0]);
        //        }
        //    _lastID = _idTemp + 1;
        //    return _lastID;

        //}

        //public static void CarAdd(string company, string model, int year, int kms, decimal price, Fuel fuel, string city, int doors, bool crashed)
        //{

        //    Car c = new Car(company, model, year, kms, price, fuel, city, doors, crashed);
        //    File.AppendAllText(_filePath, c.DescribeMe());
        //    //Refresh Lines in program memory after ADDING
        //    Lines = File.ReadAllLines(_filePath);            
        //}

        //public static void CarRemove(int Id)
        //{   
        //    Lines = File.ReadAllLines(_filePath);
        //    //Looking for specific Line in Lines for remove
        //    foreach (string l in Lines)
        //    {

        //        char[] separator = { '\t' };
        //        string[] temp = l.Split(separator);
        //        if (l == "")
        //        {
        //            continue;
        //        }
        //        Console.WriteLine(l.ToString());
        //        _idTemp = int.Parse(temp[0]);
        //        if (_idTemp == Id)
        //        {
        //            Lines[_idTemp] = Lines[_idTemp].Remove(0);

        //        }
        //        if (temp[0] == "")
        //        {
        //            continue;
        //        }
        //    }

        //    File.WriteAllLines(_filePath,Lines);
        //    //Refresh Lines in program memory after ADDING
        //    Lines = File.ReadAllLines(_filePath);
        //}

        //public static void CarRenameProp()
        //{

        //}

        //public static void CarShow()
        //{
        //    Lines = File.ReadAllLines(_filePath);
        //    foreach (string l in Lines)
        //    {
        //        if (l == "")
        //        {
        //            continue;
        //        }
        //        Console.WriteLine(l.ToString());
        //    }
        //    }
        #endregion
    }
}
