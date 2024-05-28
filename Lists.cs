using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_app
{
    public class Lists
    {
        public List<string> countries = new List<string> { "Croatia", "Germany", "France", "Italy" };
        public void GetCountry() {
            foreach (string country in countries)
            {
                Console.WriteLine($"{country}  {countries.IndexOf(country) + 1}");
            }

        }
        public void AddCountry() {
            Console.WriteLine("Do you want to add a country? Y/N");


            if (Console.ReadLine() == "Y")
            {
                Console.WriteLine("Type in your country:");
                countries.Add(Console.ReadLine());
                GetCountry();
            }
            else if (Console.ReadLine() == "N")
            {

                return;
            }
        }
        public void RemoveCountry()
        {
            GetCountry();
            Console.WriteLine("Remove a country using the number");
            int number;
            int.TryParse(Console.ReadLine(), out number);
            countries.RemoveAt(number - 1);
            GetCountry();
        }
    }
}
