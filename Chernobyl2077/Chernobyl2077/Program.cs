using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    class Program
    {
        static void Main(string[] args)
        {
            Combat_start:
            Entity Goblin = new Entity();
            MrBean MrBean = new MrBean();
            Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
            string choice1 = (Console.ReadLine());
            if (choice1 == "1")
            {
                Console.WriteLine("\n1.Attack\n2.Dab");
                string choice2= (Console.ReadLine());
                if (choice2=="1")
                {
                    MrBean.Attackk();
                    Console.WriteLine("Goblin "+Goblin.TakeDamage());
                    Console.ReadKey();
                }
                else if (choice2=="2")
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
            else if(choice1=="2")
            {
                Console.WriteLine("Mr Bean dodges!");
            }
            else
            {
                Console.WriteLine("Mr Bean cant do that!");
                System.Threading.Thread.Sleep(1250);
                goto Combat_start;
            }

        }
    }
}
