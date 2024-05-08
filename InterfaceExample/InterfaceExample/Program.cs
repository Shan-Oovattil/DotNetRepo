using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IAnimal
    {
        void animalSound(); // interface method (does not have a body)
    }

    // Pig "implements" the IAnimal interface
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal myPig = new Pig();  // Create a Pig object
            myPig.animalSound();

            Console.ReadLine();
        }
    }
}
