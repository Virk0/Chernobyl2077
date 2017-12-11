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
                else
                {
                    Console.WriteLine("ehh");
                }
            }
            else
            {
                Console.WriteLine("esel");
            }
        }
    }
}
