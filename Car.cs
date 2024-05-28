using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Console_app
{
     public class Car
    {
        private string color;
        private string name;
        private string year;
        public int carAge;
        private string today = "2024";
        public string Color { get { return color; } set { color = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Year { get { return year; } set { year = value; } }

        public Car() {
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
        }
        public Car(string color , string name, string year) {

            // bad approach due to lack of time, fix later
            int result;
            int.TryParse(today, out carAge);
            int.TryParse(year, out result);
            carAge = carAge - result ;
            Console.WriteLine("Color: "+ color);
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Year: " + year);
            Console.WriteLine(carAge);

        }



    }
}
