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
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for (int i = 1; i < 100000; i++)
            {
                while (true)
                {
                    if (watch.Elapsed.TotalMilliseconds >= 2000)
                        break;
                    using (StreamReader Main_Logo = new StreamReader(path + @"\MainLogo.txt"))
                    {
                        using (StreamReader Main_Icon = new StreamReader(path + @"\Icon.txt"))
                        {
                            string Icon = Main_Icon.ReadToEnd();
                            Console.WriteLine(Icon);
                            string MLogo = Main_Logo.ReadToEnd();
                            Console.WriteLine(MLogo);
                            System.Threading.Thread.Sleep(900);
                            using (StreamReader Main_LogoB = new StreamReader(path + @"\MainLogoBad.txt"))
                            {
                                Console.Clear();
                                Console.WriteLine(Icon);
                                string MLogoB = Main_LogoB.ReadToEnd();
                                Console.WriteLine(MLogoB);
                                System.Threading.Thread.Sleep(150);
                                Console.Clear();
                                break;
                            }
                        }
                    }
                }
            }
            watch.Stop();
            MainMenuLoaded:
            using (StreamReader Main_Logo = new StreamReader(path + @"\MainLogo.txt"))  
            {
                using (StreamReader Main_Icon = new StreamReader(path + @"\Icon.txt")) 
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
            using (StreamReader Main_Logo = new StreamReader(path + @"\MainLogo.txt")) 
            {
                using (StreamReader Main_Icon = new StreamReader(path + @"\Icon.txt")) 
                {
                    string Icon = Main_Icon.ReadToEnd();
                    Console.WriteLine(Icon);
                    string MLogo = Main_Logo.ReadToEnd();
                    Console.WriteLine(MLogo);
                }
            }
            Console.WriteLine("1.Start Game\n2.Exit Game");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter your choice:");
            string choise1 = Console.ReadLine();
            if (choise1 == "1")
            {
                //Console.WriteLine("Do you wish to turn on autoscroll?\n1.Yes\n2.No");
                //string ChAS = Console.ReadLine();
                //if (ChAS == "1")
                //{
                //    GameplayAS.GPAS();
                //}
                //if (ChAS == "2")
                //{
                //    GameplayNAS.GPNAS();
                //}
                GameplayNAS.GPNAS();
            }
            if (choise1 == "3")
            {
                using (StreamReader Dev = new StreamReader(path + @"\Development.txt")) 
                {
                    Options.Op(); //Tee optionid kasulikuks kuidagi
                }
            }
            if (choise1 == "2")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                MainMenu.MaMeLoaded();
            }
        }
        public static void MaMeLoaded()
        {
            while (true)
            {
                string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
                using (StreamReader Main_Logo = new StreamReader(path + @"\MainLogo.txt"))
                {
                    using (StreamReader Main_Icon = new StreamReader(path + @"\Icon.txt"))
                    {
                        string Icon = Main_Icon.ReadToEnd();
                        Console.WriteLine(Icon);
                        string MLogo = Main_Logo.ReadToEnd();
                        Console.WriteLine(MLogo);
                    }
                }
                Console.WriteLine("1.Start Game\n2.Exit Game");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Enter your choice:");
                string choise1 = Console.ReadLine();
                if (choise1 == "1")
                {
                    //Console.WriteLine("Do you wish to turn on autoscroll?\n1.Yes\n2.No");
                    //string ChAS = Console.ReadLine();
                    //if (ChAS == "1")
                    //{
                    //    GameplayAS.GPAS();
                    //}
                    //if (ChAS == "2")
                    //{
                    //    GameplayNAS.GPNAS();
                    //}
                    GameplayNAS.GPNAS();
                }
                if (choise1 == "3")
                {
                    using (StreamReader Dev = new StreamReader(path + @"\Development.txt"))
                    {
                        Options.Op();
                    }
                }
                if (choise1 == "2")
                {
                    Environment.Exit(0);
                }
                else
                {
                }
            }
        }
    }
}
