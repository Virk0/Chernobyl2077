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
            while (true)
            {
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
                            Console.WriteLine("Goblin died!");//battle end
                        }
                        else
                        {
                            Goblin.GoblinAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 15 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - Goblin.GoblinAP;
                            if (MrBean.mrBeanHP <= 0)
                            {
                                Console.WriteLine("Mr Bean died!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    int answeer = int.Parse(Console.ReadLine());
                                    if (answeer == 1)
                                    {
                                        Combat.gayd();
                                    }
                                    if (answeer == 2)
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
                        if (rand.Next(0, 100) <= 70)
                        {
                            System.Threading.Thread.Sleep(1200);

                            Goblin.TakeHeavyDamageGoblin();
                            System.Threading.Thread.Sleep(1200);
                            Goblin.GoblinHP = Goblin.GoblinHP - MrBean.mrBeanHeavyAP;
                            if (Goblin.GoblinHP <= 0)
                            {
                                Console.WriteLine("Goblin died!");//battle end
                            }
                            else
                            {
                                Goblin.GoblinAttack();
                                System.Threading.Thread.Sleep(1200);
                                Console.WriteLine("Mr Bean takes 15 damage!");
                                System.Threading.Thread.Sleep(1200);
                                MrBean.mrBeanHP = MrBean.mrBeanHP - Goblin.GoblinHP;
                                if (MrBean.mrBeanHP <= 0)
                                {
                                    Console.WriteLine("Mr Bean died!");
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                        int answeer = int.Parse(Console.ReadLine());
                                        if (answeer == 1)
                                        {
                                            Combat.gayd();
                                        }
                                        if (answeer == 2)
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
                            Goblin.GoblinAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 15 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - Goblin.GoblinAP;
                            if (MrBean.mrBeanHP <= 0)
                            {
                                Console.WriteLine("Mr Bean died!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    int answeer = int.Parse(Console.ReadLine());
                                    if (answeer == 1)
                                    {
                                        Combat.gayd();
                                    }
                                    if (answeer == 2)
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
                        if (Goblin.GoblinHP <= 0)
                        {
                            Console.WriteLine("Goblin died!");//battle end
                        }
                        else
                        {
                            Goblin.GoblinAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 8 damage!");
                            System.Threading.Thread.Sleep(1200);
                            int RedDMG = Goblin.GoblinAP / 2;
                            MrBean.mrBeanHP = MrBean.mrBeanHP - RedDMG;
                            if (MrBean.mrBeanHP <= 0)
                            {
                                Console.WriteLine("Mr Bean died!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    int answeer = int.Parse(Console.ReadLine());
                                    if (answeer == 1)
                                    {
                                        Combat.gayd();
                                    }
                                    if (answeer == 2)
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
                        
                    }
                }
                else if (choice1 == "2")
                {
                    Goblin.GoblinAttack();
                    Console.WriteLine("Mr Bean dodges!");
                    Console.WriteLine("Goblins attack misses!");
                }
                else
                {
                    Console.WriteLine("Mr Bean cant do that!(Type 1 to Attack & 2 to Dodge)");
                    System.Threading.Thread.Sleep(2000);
                }
                
            }
            Console.WriteLine("you win");
            Console.WriteLine("\nMrBean: " + MrBean.mrBeanHP);
            Console.ReadLine();

        }

            
        public static void SuperGoblin()
        {
            Entity aaa = new Entity();
            Goblin DGoblin = new Goblin();
            MrBean MrBean = new MrBean();

            while (true)
            {
                Console.WriteLine("\nDabbler Goblin: " + DGoblin.SuperGoblinHP);
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
                        DGoblin.TakeDamageDGoblin();
                        DGoblin.SuperGoblinHP = DGoblin.SuperGoblinHP - MrBean.mrBeanAP;
                        if (DGoblin.SuperGoblinHP <= 0)
                        {
                            Console.WriteLine("The Dabbler goblin died!");
                        }
                        else
                        {
                            DGoblin.DGoblinAttack();
                            Console.WriteLine("Mr Bean takes 12 damage!");
                            MrBean.mrBeanHP = MrBean.mrBeanHP - DGoblin.SuperGoblinAP;
                            if (MrBean.mrBeanHP <= 0)
                            {
                                Console.WriteLine("Mr Bean died!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    int answeer = int.Parse(Console.ReadLine());
                                    if (answeer == 1)
                                    {
                                        Combat.SuperGoblin();
                                    }
                                    if (answeer == 2)
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
                        if (rand.Next(0, 100) <= 70)
                        {
                            System.Threading.Thread.Sleep(1200);

                            DGoblin.TakeHeavyDamageDGoblin();
                            System.Threading.Thread.Sleep(1200);
                            DGoblin.SuperGoblinHP = DGoblin.SuperGoblinHP - MrBean.mrBeanHeavyAP;
                            if (DGoblin.SuperGoblinHP <= 0)
                            {
                                Console.WriteLine("Goblin died!");//battle end
                            }
                            else
                            {
                                DGoblin.DGoblinAttack();
                                System.Threading.Thread.Sleep(1200);
                                Console.WriteLine("Mr Bean takes 12 damage!");
                                System.Threading.Thread.Sleep(1200);
                                MrBean.mrBeanHP = MrBean.mrBeanHP - DGoblin.SuperGoblinAP;
                                if (MrBean.mrBeanHP <= 0)
                                {
                                    Console.WriteLine("Mr Bean died!");
                                    while (true)
                                    {
                                        Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                        int answeer = int.Parse(Console.ReadLine());
                                        if (answeer == 1)
                                        {
                                            Combat.SuperGoblin();
                                        }
                                        if (answeer == 2)
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
                            DGoblin.DGoblinAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 12 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - DGoblin.SuperGoblinAP;
                            if (MrBean.mrBeanHP <= 0)
                            {
                                Console.WriteLine("Mr Bean died!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    int answeer = int.Parse(Console.ReadLine());
                                    if (answeer == 1)
                                    {
                                        Combat.SuperGoblin();
                                    }
                                    if (answeer == 2)
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
                    else if (choice2 == "3")
                    {
                        MrBean.Dabberino();
                    }
                    else if (choice2 == "4")
                    {
                        MrBean.AttackShield();
                        System.Threading.Thread.Sleep(1200);
                        DGoblin.TakeShieldDamageDGoblin();
                        System.Threading.Thread.Sleep(1200);
                        DGoblin.SuperGoblinHP = DGoblin.SuperGoblinHP - MrBean.mrBeanShieldAttackAP;
                        if (DGoblin.SuperGoblinHP <= 0)
                        {
                            Console.WriteLine("Goblin died!");//battle end
                        }
                        else
                        {
                            DGoblin.DGoblinAttack();
                            System.Threading.Thread.Sleep(1200);
                            Console.WriteLine("Mr Bean takes 8 damage!");
                            System.Threading.Thread.Sleep(1200);
                            MrBean.mrBeanHP = MrBean.mrBeanHP - 8;
                            if (MrBean.mrBeanHP <= 0)
                            {
                                Console.WriteLine("Mr Bean died!");
                                while (true)
                                {
                                    Console.WriteLine("Do you want to retry?\n1.Yes\n2.No");
                                    int answeer = int.Parse(Console.ReadLine());
                                    if (answeer == 1)
                                    {
                                        Combat.SuperGoblin();
                                    }
                                    if (answeer == 2)
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
                        Console.WriteLine("Mr Bean cant do that!(Type 1 to Attack & 2 to Dodge)");
                        System.Threading.Thread.Sleep(1250);
                        
                    }
                }
                else if (choice1 == "2")
                {
                    DGoblin.DGoblinAttack();
                    Console.WriteLine("Mr Bean dodges!");
                    Console.WriteLine("Dabbler Goblin's attack misses!");
                    
                }
                else
                {
                    Console.WriteLine("Mr Bean cant do that!(Type 1 to Attack & 2 to Dodge)");
                    System.Threading.Thread.Sleep(2000);
                    
                }
                
            }
            Console.WriteLine("you win");
            Console.ReadLine();

            Console.WriteLine("\nMrBean: " + MrBean.mrBeanHP);
            Console.ReadLine();

        }
    }
}
