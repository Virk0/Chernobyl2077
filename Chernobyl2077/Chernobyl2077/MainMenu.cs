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
    class MainMenu
    {
        public static void MaMe()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 1; i < 100000; i++)
            {
                mainArt:
                if (watch.Elapsed.TotalMilliseconds >= 6000)
                    break;
                using (StreamReader Main_Logo = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\MainLogo.txt")) //Vaheta User opilaseks [opilane][User]
                {
                    using (StreamReader Main_Icon = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Icon.txt")) //Vaheta User opilaseks [opilane]
                    {
                        string Icon = Main_Icon.ReadToEnd();
                        Console.WriteLine(Icon);
                        string MLogo = Main_Logo.ReadToEnd();
                        Console.WriteLine(MLogo);
                        System.Threading.Thread.Sleep(2900);
                        using (StreamReader Main_LogoB = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\MainLogoBad.txt")) //Vaheta User opilaseks [opilane]
                        {
                            Console.Clear();
                            Console.WriteLine(Icon);
                            string MLogoB = Main_LogoB.ReadToEnd();
                            Console.WriteLine(MLogoB);
                            System.Threading.Thread.Sleep(150);
                            Console.Clear();
                            goto mainArt;
                        }
                    }

                }
                Console.WriteLine("This is test no. " + i + "\n");
            }
            watch.Stop();
            MainMenuLoaded:
            using (StreamReader Main_Logo = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\MainLogo.txt")) //Vaheta User opilaseks [opilane] 
            {
                using (StreamReader Main_Icon = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Icon.txt")) //Vaheta User opilaseks [opilane]
                { 
                    string Icon = Main_Icon.ReadToEnd();
                    Console.WriteLine(Icon);
                    string MLogo = Main_Logo.ReadToEnd();
                    Console.WriteLine(MLogo);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                                                                                 Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            using (StreamReader Main_Logo = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\MainLogo.txt")) //Vaheta User opilaseks [opilane]
            {
                using (StreamReader Main_Icon = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Icon.txt")) //Vaheta User opilaseks [opilane]
                {
                    string Icon = Main_Icon.ReadToEnd();
                    Console.WriteLine(Icon);
                    string MLogo = Main_Logo.ReadToEnd();
                    Console.WriteLine(MLogo);
                }
            }
            Console.WriteLine("1.Start Game \n2.Options \n3.Exit Game");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice:");
            string choise1 = Console.ReadLine();
            if (choise1 == "1")
            {
                Console.WriteLine("Do you wish to turn on autoscroll?\n1.Yes\n2.No");
                string ChAS = Console.ReadLine();
                if (ChAS == "1")
                {
                    GameplayAS.GPAS();
                }
                if (ChAS == "2")
                {
                    GameplayNAS.GPNAS();
                }
            }
            if (choise1 == "2")
            {
                using (StreamReader Dev = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Development.txt")) //Vaheta User opilaseks [opilane]
                {
                    Options.Op();
                }
            }
            if (choise1 == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                goto MainMenuLoaded;
            }
        }
        public static void MaMeLoaded()
        {
            MainMenuLoaded:
            using (StreamReader Main_Logo = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\MainLogo.txt")) //Vaheta User opilaseks [opilane]
            {
                using (StreamReader Main_Icon = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Icon.txt")) //Vaheta User opilaseks [opilane]
                {
                    string Icon = Main_Icon.ReadToEnd();
                    Console.WriteLine(Icon);
                    string MLogo = Main_Logo.ReadToEnd();
                    Console.WriteLine(MLogo);
                }
            }
            Console.WriteLine("1.Start Game \n2.Options \n3.Exit Game");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice:");
            string choise1 = Console.ReadLine();
            if (choise1 == "1")
            {
                Console.WriteLine("Do you wish to turn on autoscroll?\n1.Yes\n2.No");
                string ChAS = Console.ReadLine();
                if (ChAS == "1")
                {
                    GameplayAS.GPAS();
                }
                if (ChAS == "2")
                {
                    GameplayNAS.GPNAS();
                }
            }
            if (choise1 == "2")
            {
                using (StreamReader Dev = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Development.txt")) //Vaheta User opilaseks [opilane]
                {
                    Options.Op();
                }
            }
            if (choise1 == "3")
            {
                Environment.Exit(0);
            }
            else
            {
                goto MainMenuLoaded;
            }
        }
    }
}
