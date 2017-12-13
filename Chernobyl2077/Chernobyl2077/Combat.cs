using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    class Combat
    {
        static void Main(string[] args)
        {
            
            Entity aaa = new Entity();
            Goblin Goblin = new Goblin();
            MrBean MrBean = new MrBean();
            Goblin.GoblinHPP();
            Combat_start:

            Console.WriteLine("\nGoblin: "+Goblin.GoblinHP);
            Console.WriteLine("\nMrBean: "+MrBean.mrBeanHP);
            Console.WriteLine("\nWhat will Mr Bean do?\n1.Fight\n2.Dodge");
            string choice1 = (Console.ReadLine());
            if (choice1 == "1")
            {
                Console.WriteLine("\n1.Attack\n2.Dab");
                string choice2= (Console.ReadLine());
                if (choice2=="1")
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
                        goto Combat_start;
                    }
                    Console.ReadKey();
                }
                else if (choice2=="2")
                {
                   MrBean.Dabberino();
                    goto End_Combat;
                }
                else
                {
                    Console.WriteLine("Mr Bean cant do that!");
                    System.Threading.Thread.Sleep(1250);
                    goto Combat_start;
                }
            }
            else if(choice1=="2")
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
            End_Combat:
            Console.WriteLine("you win");
            Console.ReadLine();
        }
    }
}
