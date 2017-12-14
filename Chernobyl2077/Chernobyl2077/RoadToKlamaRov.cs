using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Chernobyl2077
{
    public class RoadToKlamaRov
    {
        public static void RoToKalMa()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            Console.WriteLine("*You're on the road again");
            Console.ReadKey();
            Console.WriteLine("You're tired of Chernobyl and want to go back home");
            Console.ReadKey();
            Console.WriteLine("You miss home");
            Console.ReadKey();
            Console.WriteLine("You wish you were home");
            Console.ReadKey();
            Console.WriteLine("Sitting there, with your family, enjoying a meal");
            Console.ReadKey();
            Console.WriteLine("**Bean fades into a flashback of him getting taken by the Tottaly Not FBI@TM");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Make it stop!");
            Console.ReadKey();
            Console.WriteLine("*Bean is slowly losing his mind due to the constant radiation he is getting");
            Console.ReadKey();
            Console.WriteLine("He encounters another russian goblin");
            Console.ReadKey();
            Console.WriteLine("Goblin: Staraytes' ne poteryat' rassudok");
            Console.ReadKey();
            Console.WriteLine("You start combat with the goblin");
            Combat.gayd();
            Console.WriteLine("You beat the goblin");
            Console.ReadKey();
            Console.WriteLine("You keep walking the road");
            Console.ReadKey();
            Console.WriteLine("Mr.B: I can't anymor...");
            Console.ReadKey();
            Console.WriteLine("**Bean passes out");
            Console.WriteLine(".");
            Console.ReadKey();
            Console.WriteLine(".");
            Console.Clear();
            Console.WriteLine("**You wake up, head hurting");
            Console.ReadKey();
            Console.WriteLine("Where am i?");
            Console.ReadKey();
            Console.WriteLine("*You look around and see a roadsign that has 'ty skoro umer!' written on it");
            Console.ReadKey();
            Console.WriteLine("*You have no idea what it means, not big suprise");
            Console.ReadKey();
            Console.WriteLine("You see a house on the side of the road\nWill you enter the house\n1.Yes\n2.No");
            string HouseCh = Console.ReadLine();
            if (HouseCh == "1")
            {
                HouseByTheRoad.HoByThRo();
            }
            if (HouseCh == "2")
            {
                Console.WriteLine("Mr.B: No time to stop, have to find the True Chosen One");
            }
            Console.WriteLine("*You keep walking down the road");
            Console.ReadKey();
            Console.WriteLine("After a long walk you find a destroyed city");
            Console.ReadKey();
            Console.WriteLine("Except for one house");
            Console.ReadKey();
            Console.WriteLine("The house is in very good condition");
            Console.ReadKey();
            Console.WriteLine("And there is a dabbing goblin");
            Console.ReadKey();
            Console.WriteLine("You enter combat with him");
            // Insert Combat"
            Console.WriteLine("You kill him and walk in the house");
            Console.ReadKey();
            Console.WriteLine("The house is very big and dark");
            Console.ReadKey();
            Console.WriteLine("You find a big door that is left a little open and you hear a flute inside");
            Console.ReadKey();
            Console.WriteLine("You enter the room, the door closes behind you and the flute stops");
            Console.ReadKey();
            Console.WriteLine("You see a big squid emerging form around the corner");
            Console.ReadKey();
            Console.WriteLine("Squid: You big the wrong house fool");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Im here to stop you and stop dabbing");
            Console.ReadKey();
            Console.WriteLine("Squid: Then you will die");
            // Insert Squid fight
            Console.WriteLine("Squid: this is im-mpos-ssible, H-how?!");
            Console.WriteLine("Mr.B: You're weak and dabbing is falling out of trend");
            Console.WriteLine("Mr.B: Goodbye Squid");
            Console.WriteLine("Squid: S-see y-you in he-ell");
            Console.WriteLine("*The Squid dies");
            Console.WriteLine("You finally defeat the evil, you got rid of the dab");
            //Diffrent Endings for now just the end
            using (StreamReader End = new StreamReader(path + @"\The_End.txt"))
            {
                string Tend = End.ReadToEnd();
                Console.WriteLine(Tend);
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
