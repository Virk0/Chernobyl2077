﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Chernobyl2077
{
    class Ending
    {
        public static void End()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            Console.WriteLine("Squid: this is im-mpos-ssible, H-how?!");
            Console.ReadKey();
            Console.WriteLine("Mr.B: You're weak and dabbing is falling out of trend");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Goodbye Squid");
            Console.ReadKey();
            Console.WriteLine("Squid: S-see y-you in he-ell");
            Console.ReadKey();
            Console.WriteLine("*The Squid dies");
            Console.ReadKey();
            Console.WriteLine("*You finally defeat the evil, you got rid of the dab");
            Console.ReadKey();
            Console.WriteLine("*You feel as dabbing is dying around you");
            Console.ReadKey();
            Console.WriteLine("*You're finally done here");
            Console.ReadKey();
            Console.WriteLine("*You can go home");
            Console.ReadKey();
            Console.WriteLine("*You talk to Ol Johnny before leaving");
            Console.ReadKey();
            Console.WriteLine("*You feel happy and relaxed");
            Console.ReadKey();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 1; i < 100000; i++)
            {
                while (true)
                {
                    if (watch.Elapsed.TotalMilliseconds >= 4000)
                        break;
                    using (StreamReader Main_Logo = new StreamReader(path + @"\The_End.txt"))
                    {
                        string MLogo = Main_Logo.ReadToEnd();
                        Console.WriteLine(MLogo);
                        System.Threading.Thread.Sleep(1900);
                        using (StreamReader Main_LogoB = new StreamReader(path + @"\The_EndBad.txt"))
                        {
                            Console.Clear();
                            string MLogoB = Main_LogoB.ReadToEnd();
                            Console.WriteLine(MLogoB);
                            System.Threading.Thread.Sleep(150);
                            Console.Clear();
                            break;
                        }
                    }
                }
            }
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*But what you didn't realise is ...");
            Console.ReadKey();
            Console.WriteLine("*You've been effected by the radiation and dabs");
            Console.ReadKey();
            Console.WriteLine("*You're infected with the dab");
            Console.ReadKey();
            Console.WriteLine("*Bean didn't realise that using his move 'dab' infected him aswell with it");
            Console.ReadKey();
            Console.WriteLine("*What he didn't realise is\nHe\nBecame\nThe\nChosen \nOne");
            Console.ReadKey();
            Console.Clear();


            //Diffrent Endings for now just the end
            using (StreamReader End = new StreamReader(path + @"\The_End.txt"))
            {
                string Tend = End.ReadToEnd();
                Console.WriteLine(Tend);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
