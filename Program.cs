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
            City cityInput = new City();
            Console.WriteLine($"you wrote: {cityInput.SetCity()}");
            Lists ListOfCountries = new Lists();
            ListOfCountries.GetCountry();

            bool looping = true;
            while (looping)
            {
                Console.WriteLine("Do you want to (1) add a country, (2) remove a country, (3) list the countries or (4) exit?");
                switch (Console.ReadLine())
                {
                    case "1":

                        ListOfCountries.AddCountry();
                        break;
                    case "2":

                        ListOfCountries.RemoveCountry();
                        break;
                    case "3":
                        
                        ListOfCountries.GetCountry();
                        break;
                    case "4":                        
                        looping = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;

                }

            }
            
            
            

        }

    }

}
