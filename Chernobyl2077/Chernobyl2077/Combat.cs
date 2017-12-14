using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    class Combat
    {
        public static void gayd()
        {
            Entity aaa = new Entity();
            Goblin Goblin = new Goblin();
            MrBean MrBean = new MrBean();
            Goblin.GoblinHPP();
            Start_Combat:

            Console.WriteLine("\nGoblin: " + Goblin.GoblinHP);
            Console.WriteLine("\nMrBean: " + MrBean.mrBeanHP);
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
                    Goblin.TakeDamageGoblin();
                    System.Threading.Thread.Sleep(1200);
                    Goblin.GoblinHP = Goblin.GoblinHP - MrBean.mrBeanAP;
                    if (Goblin.GoblinHP <= 0)
                    {
                        Console.WriteLine("Jake died!");//battle end
                    }
                    else
                    {
                        Goblin.GoblinAttack();
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean takes 15 damage!");
                        System.Threading.Thread.Sleep(1200);
                        MrBean.mrBeanHP = MrBean.mrBeanHP - Goblin.GoblinAP;
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

                        Goblin.TakeHeavyDamageGoblin();
                        System.Threading.Thread.Sleep(1200);
                        Goblin.GoblinHP = Goblin.GoblinHP - MrBean.mrBeanHeavyAP;
                        if (Goblin.GoblinHP <= 0)
                        {
                            Console.WriteLine("Jake died!");//battle end
                        }
                        else
                        {
                            Goblin.GoblinAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 15 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - Goblin.GoblinHP;
                            goto Start_Combat;
                        }
                    }
                    else
                    {
                        Console.WriteLine("But it missed!");
                        Goblin.GoblinAttack();
                        System.Threading.Thread.Sleep(1200);
                        Console.WriteLine("Mr Bean takes 15 damage!");
                        System.Threading.Thread.Sleep(1200);
                        MrBean.mrBeanHP = MrBean.mrBeanHP - Goblin.GoblinHP;
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
                    Goblin.TakeShieldDamageGoblin();
                    System.Threading.Thread.Sleep(1200);
                    Goblin.GoblinHP = Goblin.GoblinHP - MrBean.mrBeanShieldAttackAP;
                    if (Goblin.GoblinHP == 0)
                    {
                        Console.WriteLine("Jake died!");//battle end
                    }
                    else
                    {
                        Goblin.GoblinAttack();
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
                Goblin.GoblinAttack();
                Console.WriteLine("Mr Bean dodges!");
                Console.WriteLine("Goblins attack misses!");
                goto Start_Combat;
            }
            else
            {
                Console.WriteLine("Mr Bean cant do that!(Type 1 to Attack & 2 to Dodge)");
                System.Threading.Thread.Sleep(2000);
                goto Start_Combat;
            }
            Console.WriteLine("you win");
            Console.ReadLine();

            Console.WriteLine("\nMrBean: " + MrBean.mrBeanHP);
            Console.ReadLine();
        }
        public static void SuperGoblin()
        {
            Entity aaa = new Entity();
            Goblin Goblin = new Goblin();
            MrBean MrBean = new MrBean();
            Goblin.GoblinHPP();
            Combat_start:

            Console.WriteLine("\nGoblin: " + Goblin.GoblinHP);
            Console.WriteLine("\nMrBean: " + MrBean.mrBeanHP);
            Console.WriteLine("\nWhat will Mr Bean do?\n1.Fight\n2.Dodge");
            string choice1 = (Console.ReadLine());
            if (choice1 == "1")
            {
                Console.WriteLine("\n1.Attac\n2.\n2.Dab");
                string choice2 = (Console.ReadLine());
                if (choice2 == "1")
                {
                    MrBean.Attackk();
                    Goblin.TakeDamageGoblin();
                    Goblin.GoblinHP = Goblin.GoblinHP - MrBean.mrBeanAP;
                    if (Goblin.GoblinHP <= 0)
                    {
                        Console.WriteLine("The goblin died!");
                    }
                    else
                    {
                        Goblin.GoblinAttack();
                        Console.WriteLine("Mr Bean takes 10 damage!");
                        MrBean.mrBeanHP = MrBean.mrBeanHP - 10;
                        if (MrBean.mrBeanHP <= 0)
                        {
                            Console.WriteLine("MrBean died!");
                        }
                        else
                        {
                            goto Combat_start;
                        }
                    }
                }
                else if (choice2 == "2")
                {
                    MrBean.Dabberino();
                }
                else
                {
                    Console.WriteLine("Mr Bean cant do that!");
                    System.Threading.Thread.Sleep(1250);
                    goto Combat_start;
                }
            }
            else if (choice1 == "2")
            {
                Goblin.GoblinAttack();
                Console.WriteLine("Mr Bean dodges!");
                Console.WriteLine("Goblins attack misses!");
                goto Combat_start;
            }
            else
            {
                Console.WriteLine("Mr Bean cant do that!(Type 1 to Attack & 2 to Dodge)");
                System.Threading.Thread.Sleep(2000);
                goto Combat_start;
            }
            Console.WriteLine("you win");
            Console.ReadLine();

            Console.WriteLine("\nMrBean: " + MrBean.mrBeanHP);
            Console.ReadLine();
        }
    }
}
