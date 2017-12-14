using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Chernobyl2077
{
    public class JakeBoss
    {
        public static void gaydar()
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
                Console.WriteLine("\nJake is gonna dab!\n");
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine("Jake: " + Jake.JakePHP);
                Console.WriteLine("Mr Bean: " + MrBean.mrBeanHP);
                Console.WriteLine("\nWhat will Mr Bean do?\n1.Fight\n2.Dodge");
                string choice3 = (Console.ReadLine());
                if (choice3 == "1")
                {
                    Console.WriteLine("\n1.Attack\n2.Heavy Attack\n3.Dab\n4.Shield Attack");
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
                        Console.WriteLine("Jake dabs!");
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean tried to attack, but he was too slow!");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("Mr Bean died!");
                    }
                    else if (choice4 == "3")
                    {
                        Console.WriteLine("Mr Bean tried to dab, but it was ineffective!");
                        System.Threading.Thread.Sleep(1500);
                        Jake.Dab();
                        Console.WriteLine("Mr Bean died!");
                        System.Threading.Thread.Sleep(1500);
                    }
                    else if(choice4=="4")
                    {
                        Console.WriteLine("Mr Bean tried to defend himself, but Jake's dab went through his defense!");
                        Console.WriteLine("Mr Bean dies!");
                        //reset situation
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
                if (choice3 == "2")
                {
                    Console.WriteLine("Jake dabs!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Mr Bean dodges!");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Jake's dab was ineffective!");
                    System.Threading.Thread.Sleep(1000);
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
            Console.WriteLine("Jake: " + Jake.JakePHP);
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
                    Jake.TakeDamage();
                    System.Threading.Thread.Sleep(1200);
                    Jake.JakePHP = Jake.JakePHP - MrBean.mrBeanAP;
                    if (Jake.JakePHP <= 0)
                    {
                        Console.WriteLine("Jake died!");//battle end
                    }
                    else
                    {
                        Jake.JakePAttack();
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean takes 15 damage!");
                        System.Threading.Thread.Sleep(1200);
                        MrBean.mrBeanHP = MrBean.mrBeanHP - Jake.JakePAP;
                        goto Start_Combat;
                    }
                }
                else if (choice2 == "2")
                {
                    Random rand = new Random();

                    MrBean.HeavyAttack();
                    if (rand.Next(0, 100) <= 70)
                    {
                        System.Threading.Thread.Sleep(1200);

                        Jake.TakeHeavyDamage();
                        System.Threading.Thread.Sleep(1200);
                        Jake.JakePHP = Jake.JakePHP - MrBean.mrBeanHeavyAP;
                        if (Jake.JakePHP <= 0)
                        {
                            Console.WriteLine("Jake died!");//battle end
                        }
                        else
                        {
                            Jake.JakePAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 15 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - Jake.JakePAP;
                            goto Start_Combat;
                        }
                    }
                    else
                    {
                        Console.WriteLine("But it missed!");
                        Jake.JakePAttack();
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean takes 15 damage!");
                        System.Threading.Thread.Sleep(1200);
                        MrBean.mrBeanHP = MrBean.mrBeanHP - Jake.JakePAP;
                        goto Start_Combat;
                    }
                }

                
                else if (choice2 == "3")
                {
                    MrBean.Dabberino();
                }
                else if (choice2 == "4")
                {
                    MrBean.AttackShield();
                    System.Threading.Thread.Sleep(1200);
                    Jake.TakeShieldDamage();
                    System.Threading.Thread.Sleep(1200);
                    Jake.JakePHP = Jake.JakePHP - MrBean.mrBeanShieldAttackAP;
                    if (Jake.JakePHP == 0)
                    {
                        Console.WriteLine("Jake died!");//battle end
                    }
                    else
                    {
                        Jake.JakePAttack();
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean takes 8 damage!");
                        System.Threading.Thread.Sleep(1200);
                        MrBean.mrBeanHP = MrBean.mrBeanHP - 8;
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
            Console.WriteLine("Mr Bean wins!");
            Console.ReadLine();
        }
    }
}
