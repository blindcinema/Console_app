using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_app
{
    public abstract class Animal
    {
        public abstract string Name();

        public abstract void AnimalSound();
        public void Sleep() {
            Console.WriteLine($"the {Name()} is sleeping... ");

        }
    }  
    

    public class Pig : Animal
    {
        public override string Name() {
            return "Pig";
        }
        public override void AnimalSound()
        {
            Console.WriteLine("The pig makes a sound!");
        }
    }
    public class Dog : Animal
    {
        public override string Name()
        {
            return "Dog";
        }
        public override void AnimalSound()
        {
            Console.WriteLine("The dog makes a sound!");
        }
    }
}
