using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chernobyl2077
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader Squid_image = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\\Squiddab.txt"))
            {
                string fBoss = Squid_image.ReadToEnd();
                Console.WriteLine(fBoss);
                Console.ReadLine();
            }
        }
    }
}
