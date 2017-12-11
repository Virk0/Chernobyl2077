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
            Console.WriteLine("Mr bean has finally arrived in chernobyl");
            Console.WriteLine("Mr.B: It's even worse than i thought");
            Console.WriteLine("Mr.B: This place is in ruins and radioactive");
            Console.WriteLine("Suddenly a squatting person walks up to him and speaks gibberish to him");
            Console.WriteLine("???: Что ты здесь делаешь?");
            Console.WriteLine("Mr Bean doesn't understand a single word this guy said");
            Console.WriteLine("Mr.B: Wat?");
            Console.WriteLine("???: Ты можешь говорить по русски?");
            Console.WriteLine("Mr Bean still didn't undestand anything this being said");
            Console.WriteLine("Bean tries to move past him");
            Console.WriteLine("???:Где вы думаете, что собираетесь");
            Console.WriteLine( "You enter in combat with the squatting man, who can only speak gibberish!");
            Combat1:
            Console.WriteLine("Insert Combat system");
            if (Outcome == "Player won")
            {
                Console.WriteLine("You proceed to a temporary station located near you");

            }
            if (Outcome == "Player lost")
            {
                Console.WriteLine("Do you wish to try again?\n1.Yes\n2.No");
                string choise2 = Console.ReadLine();
                if (choise2 == "1")
                {
                    Console.WriteLine("Returning");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    goto Combat1;
                }
            }
        }
    }
}
