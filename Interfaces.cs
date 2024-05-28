using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app
{   interface ICity
    {
        string SetCity();

    }

    public class City : ICity
    {
        public string SetCity()

        {
            Console.WriteLine("Write a City");
            string city = Console.ReadLine();
            return city;
        }


    }
}

