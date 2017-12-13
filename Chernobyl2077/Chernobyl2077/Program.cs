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
            start:
            Random rand = new Random();

            if (rand.Next(0, 100) <= 90)
                Console.WriteLine("You died");
            else
                Console.WriteLine("You live");
            string dxd=(Console.ReadLine());
            if (dxd == "r")
            {
                goto start;
            }
            
        }
    }
}
