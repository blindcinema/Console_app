using System.Drawing;
using System.Runtime.InteropServices;

namespace Console_app
{
    internal class Program
    {

            static void Main(string[] args)
        {



            Car miata = new Car("Red", "Miata", "1991");

            /* Console.WriteLine("Enter new car color:");
               string color = Console.ReadLine();
               Console.WriteLine("Enter new car name:");
               string name = Console.ReadLine();
               Console.WriteLine("Enter new car year:");
               string year = Console.ReadLine();
               Car inputCar = new Car(color, name, year);
            */


            Animal piggy = new Pig();
            Animal dogg = new Dog();
            piggy.AnimalSound();
            dogg.AnimalSound();
            dogg.Sleep();
            City osijek = new City();
            Console.WriteLine($"you wrote: {osijek.SetCity()}");
            Lists ListOfCountries = new Lists();
            ListOfCountries.GetCountry();
            ListOfCountries.AddCountry();
            ListOfCountries.RemoveCountry();

        }

    }

}
