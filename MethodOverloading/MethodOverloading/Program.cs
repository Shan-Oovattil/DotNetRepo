using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pgm = new Program();

            pgm.add(10, 20, 2.5);
            pgm.add(2, 5, 8);

            Console.ReadLine();
        }


        void add(int n1, int n2)
        {
            Console.WriteLine($"n1 + n2 = {n1 + n2}");
        }

        void add(int n1, int n2 , int n3)
        {
            Console.WriteLine($"n1 + n2 + n3 = {n1 + n2 + n3}");
        }

        void add(int n1, int n2, double n3)
        {
            Console.WriteLine($"n1 + n2 + n3 = {n1 + n2 + n3}");
        }

    }
}
