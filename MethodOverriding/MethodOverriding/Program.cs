using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{

    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Base: eat");
        }
    }

    public class Dog: Animal
    { 
        public override void eat()
        {
            Console.WriteLine("Derived: eat meat");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();

            Console.ReadLine();
        }
    }


}
