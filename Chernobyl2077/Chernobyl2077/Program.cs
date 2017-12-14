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
            using (StreamReader Squid_image = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Squiddab.txt"))
            {
                string fBoss = Squid_image.ReadToEnd();
                Console.WriteLine(fBoss);
                Squid Squidward = new Squid();
                MrBean MrBean = new MrBean();
                int i = 0;
                Start_Combat:
                Console.WriteLine("The Squid: "+Squidward.SquidHP);
                Console.WriteLine("Mr Bean: " + MrBean.mrBeanHP);
                i = i + 1;
                if (i % 2 == 0)//special attack
                {
                    Console.WriteLine("\nThe Squid is gonna dab!");
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine("\nWhat will Mr Bean do?\n1.Fight\n2.Dodge");
                    string choice3 = (Console.ReadLine());
                    if (choice3 == "1")
                    {
                        Console.WriteLine("\n1.Attack\n2.Dab\n3.Shield Attack");
                        string choice4 = (Console.ReadLine());
                        if (choice4 == "1")
                        {
                            Console.WriteLine("The Squid dabs!");
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean tried to attack, but he was too slow!");
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("Mr Bean died!");
                        }
                        else if (choice4 == "2")
                        {
                            Console.WriteLine("Mr Bean and The Squid dabbed at the same time!");
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("They canceled eachother's dabs out, making them both ineffective!");
                            System.Threading.Thread.Sleep(1500);
                            goto Start_Combat;
                        }
                        else if (choice4 == "3")
                        {
                            Console.WriteLine("Mr Bean tries to defend himself, but The Squid's dab goes through his defense!");
                            Console.WriteLine("Mr Bean dies!");
                            //reset situation
                        }
                        else
                        {
                            Console.WriteLine("Mr Bean stood still, confused.");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("The Squid dabs, doing " + Squidward.SquidDabAP + " damage!");
                            System.Threading.Thread.Sleep(1500);
                            Console.WriteLine("Mr Bean dies!");
                            //
                            //Reset situation
                            //
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
                        //
                        //Reset situation
                        //
                    }
                }
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
                        if (Squidward.SquidHP == 0)
                        {
                            Console.WriteLine("The Squid died!");//battle end
                        }
                        else
                        {
                            Squidward.SqAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 20 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - Squidward.SquidAP;
                            goto Start_Combat;
                        }
                    }
                    else if (choice2 == "2")
                    {
                        MrBean.HeavyAttack();
                        System.Threading.Thread.Sleep(1200);

                        Squidward.TakeHeavyDamage();
                        System.Threading.Thread.Sleep(1200);
                        Squidward.SquidHP = Squidward.SquidHP - MrBean.mrBeanHeavyAP;
                        if (Squidward.SquidHP == 0)
                        {
                            Console.WriteLine("The Squid died!");//battle end
                        }
                        else
                        {
                            Squidward.SqAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 20 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - Squidward.SquidAP;
                            goto Start_Combat;
                        }
                    }
                    else if (choice2 == "3")
                    {
                        MrBean.Dabberino();
                        goto End_Combat;
                    }
                    else if (choice2 == "4")
                    {
                        MrBean.AttackShield();
                        System.Threading.Thread.Sleep(1200);
                        Squidward.TakeShieldDamage();
                        System.Threading.Thread.Sleep(1200);
                        Squidward.SquidHP = Squidward.SquidHP - MrBean.mrBeanShieldAttackAP;
                        if (Squidward.SquidHP == 0)
                        {
                            Console.WriteLine("The Squid died!");//battle end
                        }
                        else
                        {
                            Squidward.SqAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 10 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - 10;
                            goto Start_Combat;//insert break
                        }
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
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Mr Bean dodges!");
                    System.Threading.Thread.Sleep(1000);
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
                Console.WriteLine("Mr Bean wins!");
                Console.ReadLine();
            }
        }
    }
}
