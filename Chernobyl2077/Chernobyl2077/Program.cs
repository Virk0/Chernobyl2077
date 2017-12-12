using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            if (rand.Next(0, 2) == 0)
                Console.WriteLine("You died");
            else
                Console.WriteLine("You live");
            Console.ReadLine();
        }
    }
}
