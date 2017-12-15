using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chernobyl2077
{
    public class squiddd
    {
        public static void Squidd()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            using (StreamReader Squid_image = new StreamReader(path + @"\Squiddab.txt"))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                string fBoss = Squid_image.ReadToEnd();
                Console.WriteLine(fBoss);
                Squid Squidward = new Squid();
                MrBean MrBean = new MrBean();
                int i = 0;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                while (true)
                {
                    i = i + 1;
                    if (i % 2 == 0)//enemy's special attack
                    {
                        Console.WriteLine("\nThe Squid is gonna dab!\n");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("The Squid: " + Squidward.SquidHP);
                        Console.WriteLine("Mr Bean: " + MrBean.mrBeanHP);
                        Console.WriteLine("\nWhat will Mr Bean do?" + "\n1.Fight\n2.Dodge");
                        string choice3 = (Console.ReadLine());
                        if (choice3 == "1")
                        {
                            Console.WriteLine("\n1.Attack\n2.Heavy Attack\n3.Dab\n4.Shield Attack");
                            string choice4 = (Console.ReadLine());
                            if (choice4 == "1")
                            {
                                Console.WriteLine("The Squid dabs!");
                                System.Threading.Thread.Sleep(1200);
                                Console.WriteLine("Mr Bean tried to attack, but he was too slow!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Mr Bean dies!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    string answeer = Console.ReadLine();
                                    if (answeer == "1")
                                    {
                                        squiddd.Squidd();
                                    }
                                    if (answeer == "2")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                    }
                                }

                            }
                            else if (choice4 == "2")
                            {
                                Console.WriteLine("The Squid dabs!");
                                System.Threading.Thread.Sleep(1200);
                                Console.WriteLine("Mr Bean tried to attack, but he was too slow!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Mr Bean dies!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    string answeer = Console.ReadLine();
                                    if (answeer == "1")
                                    {
                                        squiddd.Squidd();
                                    }
                                    if (answeer == "2")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                    }
                                }
                            }
                            else if (choice4 == "3")
                            {
                                Console.WriteLine("Mr Bean tried to dab, but it was ineffective!");
                                System.Threading.Thread.Sleep(1500);
                                Squidward.Dab();
                                Console.WriteLine("Mr Bean dies!");
                                System.Threading.Thread.Sleep(1500);
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    string answeer = Console.ReadLine();
                                    if (answeer == "1")
                                    {
                                        squiddd.Squidd();
                                    }
                                    if (answeer == "2")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                    }
                                }
                            }
                            else if (choice4 == "4")
                            {
                                Console.WriteLine("Mr Bean tries to defend himself, but The Squid's dab goes through his defense!");
                                Console.WriteLine("Mr Bean dies!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    string answeer = Console.ReadLine();
                                    if (answeer == "1")
                                    {
                                        squiddd.Squidd();
                                    }
                                    if (answeer == "2")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Mr Bean stood still, confused.");
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("The Squid dabs, doing " + Squidward.SquidDabAP + " damage!");
                                System.Threading.Thread.Sleep(1500);
                                Console.WriteLine("Mr Bean dies!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    string answeer = Console.ReadLine();
                                    if (answeer == "1")
                                    {
                                        squiddd.Squidd();
                                    }
                                    if (answeer == "2")
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                    }
                                }
                            }
                        }
                        else if (choice3 == "2")
                        {
                            Console.WriteLine("The Squid dabs!");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Mr Bean dodges!");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("The Squids dab was ineffective!");

                        }
                        else
                        {
                            Console.WriteLine("Mr Bean stood still, confused.");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("The Squid dabs, doing " + Squidward.SquidDabAP + " damage!");
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("Mr Bean dies!");
                            while (true)
                            {
                                Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                string answeer = Console.ReadLine();
                                if (answeer == "1")
                                {
                                    squiddd.Squidd();
                                }
                                if (answeer == "2")
                                {
                                    Environment.Exit(0);
                                }
                                else
                                {
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Squid: " + Squidward.SquidHP);
                        Console.WriteLine("Mr Bean: " + MrBean.mrBeanHP);
                        Console.WriteLine("\nWhat will Mr Bean do?\n1.Fight\n2.Dodge");
                        string choice1 = (Console.ReadLine());
                        if (choice1 == "1")
                        {
                            Console.WriteLine("\n1.Attack\n2.Heavy Attack\n3.Dab\n4.Shield Attack");
                            string choice2 = (Console.ReadLine());
                            if (choice2 == "1")
                            {
                                MrBean.Attackk();
                                System.Threading.Thread.Sleep(1200);
                                Squidward.TakeDamage();
                                System.Threading.Thread.Sleep(1200);
                                Squidward.SquidHP = Squidward.SquidHP - MrBean.mrBeanAP;
                                if (Squidward.SquidHP <= 0)
                                {
                                    Console.WriteLine("The Squid died!");//battle end
                                    break;
                                }
                                else
                                {
                                    Squidward.SqAttack();
                                    System.Threading.Thread.Sleep(1200);
                                    Console.WriteLine("Mr Bean takes 20 damage!");
                                    System.Threading.Thread.Sleep(1200);
                                    MrBean.mrBeanHP = MrBean.mrBeanHP - Squidward.SquidAP;
                                    if (MrBean.mrBeanHP <= 0)
                                    {
                                        Console.WriteLine("Mr Bean died!");
                                        while (true)
                                        {
                                            Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                            string answeer = Console.ReadLine();
                                            if (answeer == "1")
                                            {
                                                squiddd.Squidd();
                                            }
                                            if (answeer == "2")
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                            }
                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            else if (choice2 == "2")
                            {
                                Random rand = new Random();

                                MrBean.HeavyAttack();
                                if (rand.Next(0, 100) <= 25)
                                {
                                    System.Threading.Thread.Sleep(1200);
                                    Squidward.TakeHeavyDamage();
                                    System.Threading.Thread.Sleep(1200);
                                    Squidward.SquidHP = Squidward.SquidHP - MrBean.mrBeanHeavyAP;
                                    if (Squidward.SquidHP <= 0)
                                    {
                                        Console.WriteLine("The Squid died!");
                                        break;
                                    }
                                    else
                                    {
                                        Squidward.SqAttack();
                                        System.Threading.Thread.Sleep(1200);
                                        Console.WriteLine("Mr Bean takes 20 damage!");
                                        System.Threading.Thread.Sleep(1200);
                                        MrBean.mrBeanHP = MrBean.mrBeanHP - Squidward.SquidAP;
                                        if (MrBean.mrBeanHP <= 0)
                                        {
                                            Console.WriteLine("Mr Bean died!");
                                            while (true)
                                            {
                                                Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                                string answeer = Console.ReadLine();
                                                if (answeer == "1")
                                                {
                                                    squiddd.Squidd();
                                                }
                                                if (answeer == "2")
                                                {
                                                    Environment.Exit(0);
                                                }
                                                else
                                                {
                                                }
                                            }
                                        }
                                        else
                                        {
                                        
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("But it missed!");
                                }
                            }
                            else if (choice2 == "3")
                            {
                                Console.WriteLine("Mr Bean tried to dab, but it was ineffective!");
                                Squidward.SqAttack();
                                System.Threading.Thread.Sleep(1200);
                                Console.WriteLine("Mr Bean takes 20 damage!");
                                System.Threading.Thread.Sleep(1200);
                                MrBean.mrBeanHP = MrBean.mrBeanHP - Squidward.SquidAP;
                                if (MrBean.mrBeanHP <= 0)
                                {
                                    Console.WriteLine("Mr Bean died!");
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                        string answeer = Console.ReadLine();
                                        if (answeer == "1")
                                        {
                                            squiddd.Squidd();
                                        }
                                        if (answeer == "2")
                                        {
                                            Environment.Exit(0);
                                        }
                                        else
                                        {
                                        }
                                    }
                                }
                                else
                                {

                                }
                            }
                            else if (choice2 == "4")
                            {
                                MrBean.AttackShield();
                                System.Threading.Thread.Sleep(1200);
                                Squidward.TakeShieldDamage();
                                System.Threading.Thread.Sleep(1200);
                                Squidward.SquidHP = Squidward.SquidHP - MrBean.mrBeanShieldAttackAP;
                                if (Squidward.SquidHP <= 0)
                                {
                                    Console.WriteLine("The Squid died!");//battle end
                                    break;
                                }
                                else
                                {
                                    Squidward.SqAttack();
                                    System.Threading.Thread.Sleep(1200);
                                    int RedDMG = Squidward.SquidAP;
                                    MrBean.mrBeanHP = MrBean.mrBeanHP - RedDMG;
                                    Console.WriteLine("Mr Bean takes " + RedDMG + " damage!");
                                    System.Threading.Thread.Sleep(1200);
                                    if (MrBean.mrBeanHP <= 0)
                                    {
                                        Console.WriteLine("Mr Bean died!");
                                        while (true)
                                        {
                                            Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                            string answeer = Console.ReadLine();
                                            if (answeer == "1")
                                            {
                                                squiddd.Squidd();
                                            }
                                            if (answeer == "2")
                                            {
                                                Environment.Exit(0);
                                            }
                                            else
                                            {
                                            }
                                        }
                                    }
                                    else
                                    {

                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Mr Bean can't do that!(Type 1 to Attack & 2 to Dodge)");
                                System.Threading.Thread.Sleep(1250);
                                squiddd.Squidd();
                            }
                        }

                        else if (choice1 == "2")
                        {
                            Squidward.SqAttack();
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("Mr Bean dodges!");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("The Squid's attack misses!\n");
                            squiddd.Squidd();
                        }
                        else
                        {
                            Console.WriteLine("Mr Bean can't do that!(Type 1 to Attack & 2 to Dodge)");
                            System.Threading.Thread.Sleep(2000);
                            squiddd.Squidd();
                        }
                    }
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Mr Bean wins!");
                Console.ReadLine();
                Ending.End();
            }
        }
    }
}
