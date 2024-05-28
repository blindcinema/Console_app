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

                Console.WriteLine("Type in your country:");
                countries.Add(Console.ReadLine());
                GetCountry();


        }
        public void RemoveCountry()
        {
            GetCountry();
            Console.WriteLine("Remove a country using the number");
            int number;
            bool ifTrue = int.TryParse(Console.ReadLine(), out number);
            if (ifTrue & number < countries.Count + 1 & number != 0) {
                countries.RemoveAt(number - 1);
                GetCountry();
            }
            else
            {
                Console.WriteLine("Enter a valid number");
                return;
            }
            
        }
    }
}
