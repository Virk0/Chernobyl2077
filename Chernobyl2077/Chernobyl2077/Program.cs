﻿using System;
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
                Entity aaa = new Entity();
                Squid Squidward = new Squid();
                MrBean MrBean = new MrBean();
                int i = 0;
                Start_Combat:
                i = i + 1;
                if (i % 2 == 0)
                {
                    Console.WriteLine("The Squid is gonna dab!");
                    Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                    string choice3 = (Console.ReadLine());
                    if (choice3 == "1")
                    {
                        Console.WriteLine("\n1.Attack\n2.Dab");
                        string choice4 = (Console.ReadLine());
                        if (choice4 == "1")
                        {
                            Console.WriteLine("The Squid dabs!");
                            System.Threading.Thread.Sleep(500);
                            Console.WriteLine("Mr Bean tried to attack, but he was too slow!");
                            Console.WriteLine("Mr Bean died!");
                        }
                        else if (choice4 == "2")
                        {
                            Console.WriteLine("Mr Bean and The Squid dabbed at the same time!");
                            Console.WriteLine("They canceled eachother's dabs out, making them both ineffective!");
                            goto Start_Combat;
                        }
                        else
                        {
                            Console.WriteLine("Mr Bean stood still, confused.");
                            Console.WriteLine("The Squid dabs, doing "+Squidward.SquidDabAP+" damage!");
                            Console.WriteLine("Mr Bean dies!");
                            //
                            //Reset situation
                            //
                        }
                    }
                    else if (choice3 == "2")
                    {
                        Console.WriteLine("The Squid dabs!");
                        Console.WriteLine("Mr Bean dodges!");
                        Console.WriteLine("The Squids dab was ineffective!");
                    }
                }
                Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                string choice1 = (Console.ReadLine());
                if (choice1 == "1")
                {
                    Console.WriteLine("\n1.Attack\n2.Dab");
                    string choice2 = (Console.ReadLine());
                    if (choice2 == "1")
                    {
                        MrBean.Attackk();
                        Squidward.TakeDamage();
                        Squidward.SquidHP = Squidward.SquidHP - 10;
                        if (Squidward.SquidHP == 0)
                        {
                            Console.WriteLine("The Squid died!");
                        }
                        else
                        {
                            Squidward.SqAttack();
                            Console.WriteLine("Mr Bean takes 10 damage!");
                            MrBean.mrBeanHP = MrBean.mrBeanHP - 20;
                            goto Start_Combat;
                        }
                        Console.ReadKey();
                    }
                    else if (choice2 == "2")
                    {
                        MrBean.Dabberino();
                        goto End_Combat;
                    }
                    else
                    {
                        Console.WriteLine("Mr Bean can't do that!(Type 1 to Attack & 2 to Dodge)");
                        System.Threading.Thread.Sleep(1250);
                        goto Start_Combat;
                    }
                }
                else if (choice1 == "2")
                {
                    Squidward.SqAttack();
                    Console.WriteLine("Mr Bean dodges!");
                    Console.WriteLine("The Squid's attack misses!");
                    goto Start_Combat;
                }
                else
                {
                    Console.WriteLine("Mr Bean can't do that!(Type 1 to Attack & 2 to Dodge)");
                    System.Threading.Thread.Sleep(2000);
                    goto Start_Combat;
                }
                End_Combat:
                Console.WriteLine("you win");
                Console.ReadLine();
                Console.ReadLine();
            }
        }
    }
}
