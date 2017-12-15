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
    class DoChNo
    {
        public static void DchN()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            Console.WriteLine("You decide to go and search for another way");
            Console.ReadKey();
            Console.WriteLine("You walk around the house");
            Console.ReadKey();
            Console.WriteLine("Suddenly you hear footsteps behind you");
            Console.ReadKey();
            Console.WriteLine("Next you're knocked out");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You wake up in a cage");
            Console.ReadKey();
            Console.WriteLine("You start looking for a way out");
            Console.ReadKey();
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*Nearby you see\n1.saw\n2.nailfile\n3.shovel\n4.???\n5.handgun");
                string CaCh = Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                if (CaCh == "1")
                {
                    Console.WriteLine("**You pick up the saw");
                    Console.ReadKey();
                    Console.WriteLine("*You realise it's not a metal saw");
                    Console.ReadKey();
                    Console.WriteLine("*You put it back down");
                }
                if (CaCh == "2")
                {
                    Console.WriteLine("**You pick up the nailfile");
                    Console.ReadKey();
                    Console.WriteLine("*You start using the file on the bars of the cage");
                    Console.ReadKey();
                    Console.WriteLine("*After a long time the bar breaks and you get out of the cage");
                    break;
                }
                if (CaCh == "3")
                {
                    Console.WriteLine("**You pick up the shovel");
                    Console.ReadKey();
                    Console.WriteLine("*You look below and you see that there is no bottom part on this cage");
                    Console.ReadKey();
                    Console.WriteLine("*You just lift the cage and walk out");
                    break;
                }
                if (CaCh == "4")
                {
                    Console.WriteLine("???");
                    Console.ReadKey();
                    Console.WriteLine("You stand there in confusion");
                    Console.ReadKey();
                    Console.WriteLine("You decide to reconsider you choice");
                }
                if (CaCh == "5")
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*Well that's another way you can undestand the words 'a way out of the cage'");
                    Console.ReadKey();
                    Console.WriteLine("**You pick up the gun");
                    Console.ReadKey();
                    Console.WriteLine("...");
                    Console.ReadKey();
                    using (StreamReader End = new StreamReader(path + @"\The_End.txt"))
                    {
                        string Tend = End.ReadToEnd();
                        Console.WriteLine(Tend);
                        Console.ReadKey();
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        Environment.Exit(0);
                    }
                }
                else
                {

                }
            }
            Console.WriteLine("*You explore around");
            Console.ReadKey();
            Console.WriteLine("Suddenly you see a person appear, dabbing");
            Console.ReadKey();
            Console.WriteLine("???: Welcome, We've been excpeting you");
            Console.ReadKey();
            Console.WriteLine("*You realise this might be the chosen one");
            Console.ReadKey();
            Console.WriteLine("Mr.B: You must be Jake Paul");
            Console.ReadKey();
            Console.WriteLine("Jake.P: You guessed it");
            Console.ReadKey();
            Console.WriteLine("Jake.P: But now i must stop you, i know why you're here, you're here to stop dabbing, you're here to kill me!");
            Console.ReadKey();
            Console.WriteLine("*You stay silent");
            Console.ReadKey();
            Console.WriteLine("Jake.P: Well come and fight me you coward");
            JakeBoss.gaydar();
            Console.WriteLine("*Jake paul falls down in defeat");
            Console.ReadKey();
            Console.WriteLine("*You realise that you can finaly go home");
            Console.ReadKey();
            Console.WriteLine("*You've finally defeated dabbing");
            Console.ReadKey();
            Console.WriteLine("*You walk outside in victory");
            Console.ReadKey();
            Console.WriteLine(".....\n........\n........");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Oh no, how, how are they still effected by dabbing");
            Console.ReadKey();
            Console.WriteLine("*I thought i killed the chosen one");
            Console.ReadKey();
            Console.WriteLine("*Why is dabbing still here");
            Console.ReadKey();
            Console.WriteLine("Ol Johnny: You fool, you can't defeat dabbing so easily");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Johnny?");
            Console.ReadKey();
            Console.WriteLine("Ol Johnny: The prophecy was a lie, They thought we was the best, the strongest and, the wisest. They were wrong");
            Console.ReadKey();
            Console.WriteLine("Ol Johnny: They say there is something much worse out there.... \nThey described him as a blue big monster, who is the best at dabbing");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Where could i find him");
            Console.ReadKey();
            Console.WriteLine("Ol Johnny: .\n.\n.\n.\n.");
            Console.ReadKey();
            Console.WriteLine("Ol Johnny: No one knows");
            Console.ReadKey();
            Console.WriteLine("Ol Johnny: i would say you should start by 'Dom kal'marov' house");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Thank you Johnny");
            Console.ReadKey();
            Console.WriteLine("*You walk out the house and go search for the 'Dom kal'marov' building");
            Console.ReadKey();
        }
    }
}
