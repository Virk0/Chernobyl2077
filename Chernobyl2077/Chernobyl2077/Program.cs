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
            string Outcome = "Player won";
            if (Outcome == "Player won")
            {
                Console.WriteLine("You proceed to a temporary station located near you");
                Console.WriteLine("You see a man in the corner");
                Console.WriteLine("???: What are you doing in these radioactive swamps?");
                Console.WriteLine("Mr.B: I've come here to destroy a deadly diseas called 'DAB'");
                Console.WriteLine("???: You must be a mad lad. Many people have tried to destroy it before, but they have either failed and lived to tell the tale or die");
                Console.WriteLine("Mr.B: I had no option, i was sent by the Totally not FBI™");
                Console.WriteLine("Ol Jhonny Boy: So you are their latest agent, i was sent here aswell in 2069, but i was trapped here with no food or water");
                Console.WriteLine("I don't wanna end up like him, i have to move out and work");
                Console.WriteLine("Mr.B:I have to go on with my misson, good luck surviving in here Jhonny");
                Console.WriteLine("Ol Jhonny Boy: Y-you too!");
                Console.WriteLine("You head out of the house and back on the road");
                Console.WriteLine("You inspect the persons body, who you killed before");
                Console.WriteLine("You find out that they are radiated russian gopniks");
                Console.WriteLine("This what Chernobyl explosion did to them");
                Console.WriteLine("Poor Chernobyl Gopniks");
                Roads:
                Console.WriteLine("The road splits to three:\n1.Джефф мемы\n2.не легковые автомобили\n3.банан\n4.cмерть");
                Console.WriteLine("Which are you gonna go?");
                string choiseRoad = Console.ReadLine();
                if (choiseRoad == "1")
                {
                    Console.WriteLine("You decide do go to Джефф мемы");
                    Console.WriteLine("You arrive");
                    Console.WriteLine("You hear 'MYNAMAJEF' from far away");
                    Console.WriteLine("You see 2 Gopniks squatting nearby");
                    Console.WriteLine("Russian Gopnik:Убирайся отсюда!");
                    Console.WriteLine("You dont understand anything, as usual");
                    Console.WriteLine("Mr.B: Can't you just speak English?");
                    Console.WriteLine("Mr Bean realised that was a dumb question");
                    Console.WriteLine("2 Gopniks decide to attack");
                    Combat2:
                    Console.WriteLine("You enter combat with the 2 russian copniks");
                }
                if (choiseRoad == "2")
                {
                    Console.WriteLine("You decide do go to Джефф мемы");
                    Console.WriteLine("You arrive");
                    Console.WriteLine("You don't see any cars nearby");
                    Console.WriteLine("But what you do see is 3 Gopniks, oh great");

                }
                if (choiseRoad == "3")
                {
                    Console.WriteLine("You decide do go to банан");
                    Console.WriteLine("You arrive");
                    Console.WriteLine("You see a banana on the ground");
                    Console.WriteLine("Mr.B: Hm, should i eat it?");
                    Console.WriteLine("1.Yes\n2.No");
                    string choiseBanana = Console.ReadLine();
                    if (choiseBanana == "1")
                    {
                        Console.WriteLine("You ate a radiated banana");
                        Console.WriteLine("You smart");


                    }
                }

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
