using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Chernobyl2077
{
    class GameplayAS
    {
        public static void GPAS()
        {
            using (StreamReader Dev = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Development.txt"))
            {
                Console.Clear();
                string Deve = Dev.ReadToEnd();
                Console.WriteLine(Deve);
                Console.ReadLine();
            }
        }
    }
}
