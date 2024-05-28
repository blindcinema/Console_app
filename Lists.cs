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
        public List<string> countries = new List<string> {"Hrvatska", "Njemacka", "Italija", "Francuska"};
        public void GetCountry() {
            foreach (string country in countries )
            {
                Console.WriteLine(country);
                
            }
            
        }
        
    }
}
