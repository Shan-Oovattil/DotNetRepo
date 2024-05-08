// Hello World! program
using System.Data;
using System.Runtime.InteropServices;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            // aabbcc
            //op: a2b2c2

            string str = "aabbcc";
            int count = 0;
            Dictionary<char,int> map = new Dictionary<char,int>();

            char[] chars = str.ToCharArray();

            for(int i=0;i<chars.Length;i++)
            {
                if (map.ContainsKey(chars[i]))
                    map[chars[i]]++;
               // else
                   // map[chars[i] =1;
            }

            Console.WriteLine("Display Results");

            for(int i=0;i < map.Count;i++) 
            {
                Console.WriteLine(map.Keys.ElementAt(i));
                Console.WriteLine(map.Values.ElementAt(i));
            }



            


        }
    }
}

