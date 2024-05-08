using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Single
{   
    public class Car
    {
        public int tyres = 4;        
    }

    public class BMW: Car
    {
        public int gears = 6;
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            BMW bMW = new BMW();

            Console.WriteLine($"Tyres of BMW:{bMW.tyres}");
            Console.WriteLine($"Gears of BMW:{bMW.gears}");

            Console.ReadLine();
        }
    }





}
