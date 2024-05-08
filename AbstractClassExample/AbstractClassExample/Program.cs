using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{

    abstract public class Animal
    {
        public abstract void Eat();

        public void display()
        {
            Console.WriteLine("Animal:Display");
        }
    }

    public class Dog: Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog:eating");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Eat();
            dog.display();
            Console.ReadLine();
        }
    }
}
