using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chernobyl2077
{
    public class JakeBoss
    {
        static void Main(string[] args)
        {
            //insert into boss battle location
            //insert image from JakeP class
            JakeP Jake = new JakeP();
            MrBean MrBean = new MrBean();
            int counter = 0;
            Start_Combat:
            counter = counter + 1;
            if (counter % 3 == 0)
            {
                Console.WriteLine("\nJake is gonna dab!");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("\nWhat will Mr Bean do?\n1.Fight\n2.Dodge");
                string choice3 = (Console.ReadLine());
                if (choice3 == "1")
                {
                    Console.WriteLine("\n1.Attack\n2.Dab");
                    string choice4 = (Console.ReadLine());
                    if (choice4 == "1")
                    {
                        Console.WriteLine("Jake dabs!");
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean tried to attack, but he was too slow!");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Mr Bean died!");
                    }
                    else if (choice4 == "2")
                    {
                        Console.WriteLine("Mr Bean and Jake dabbed at the same time!");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("They canceled eachother's dabs out, making them both ineffective!");
                        System.Threading.Thread.Sleep(1500);
                        goto Start_Combat;
                    }
                    else
                    {
                        Console.WriteLine("Mr Bean stood still, confused.");
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine("Jake dabs, doing " + Jake.JakePDabAP + " damage!");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Mr Bean dies!");
                        //
                        //Reset situation
                        //
                    }

                }
            }
            Console.WriteLine("\nWhat will Mr Bean do?\n1.Fight\n2.Dodge");
            string choice1 = (Console.ReadLine());
            if (choice1 == "1")
            {
                Console.WriteLine("\n1.Attack\n2.Dab");
                string choice2 = (Console.ReadLine());
                if (choice2 == "1")
                {
                    MrBean.Attackk();
                    System.Threading.Thread.Sleep(1200);
                    Jake.TakeDamage();
                    System.Threading.Thread.Sleep(1200);
                    Jake.JakePHP = Jake.JakePHP - MrBean.mrBeanAP;
                    if (Jake.JakePHP == 0)
                    {
                        Console.WriteLine("Jake died!");//battle end
                    }
                    else
                    {
                        Jake.JakePAttack();
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean takes 20 damage!");
                        System.Threading.Thread.Sleep(1200);
                        MrBean.mrBeanHP = MrBean.mrBeanHP - Jake.JakePAP;
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
                Jake.JakePAttack();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Mr Bean dodges!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Jake's attack misses!");
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
