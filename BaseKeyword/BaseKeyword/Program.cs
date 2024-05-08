using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKeyword
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating...");
        }
    }

    public class Dog : Animal
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("eating bread...");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.eat();
            Console.ReadLine();
        }
    }
}
