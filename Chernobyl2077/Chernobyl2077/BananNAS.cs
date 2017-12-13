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
    class BananNAS
    {
        public static void BaNAS()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            string Secret_Code = Console.ReadLine();
            Console.WriteLine("You see a roadsign ahead, it  says 'Banan' on it");
            Console.ReadKey();
            Console.WriteLine("You decide do go to banan");
            Console.ReadKey();
            Console.WriteLine("You arrive");
            Banana:
            Console.WriteLine("You see a banana on the ground");
            Console.ReadKey();
            Console.WriteLine("Mr.B: Hm, should i eat it?");
            Console.WriteLine("1.Yes\n2.No");
            string choiseBanana = Console.ReadLine();
            if (choiseBanana == "1")
            {
                Console.WriteLine("You ate a radiated banana");
                Console.WriteLine("You smart");
                Console.ReadKey();
                using (StreamReader DS = new StreamReader(path + @"\DeathScreen.txt"))
                {
                    String DS_ = DS.ReadToEnd();
                    Console.WriteLine(DS_);
                    Console.WriteLine("Do you wish to try again?\n1.Yes\n2.No");
                    string choiseBaDead = Console.ReadLine();
                    if (choiseBaDead == "1")
                    {
                        Console.WriteLine("Returning to your choise");
                        Console.ReadKey();
                        goto Banana;
                    }
                    if (choiseBaDead == "2")
                    {
                        Console.WriteLine("Okay");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }
            if (choiseBanana == "2")
            {

                Console.WriteLine("Good job, you didn't eat a radiated banana");
                Console.ReadKey();
                Console.WriteLine("But you still find a russian");
                Console.ReadKey();
                Console.WriteLine("And he start running towards you");
                Console.ReadKey();
                if (Secret_Code == "3499")
                {
                    Console.WriteLine("*****************Skipping Combat*****************");
                    Console.ReadKey();
                }
                else
                {
                    Combat.gayd();
                }
                Console.WriteLine("You beat the russian goblin");
                Console.ReadKey();
                Console.WriteLine("He managed to say something before passing out");
                Console.ReadKey();
                Console.WriteLine("Russian Goblin:'H-he is too stro-ong for y-you'");
                Console.ReadKey();
                Console.WriteLine("He passed out");
                Console.ReadKey();
                Console.WriteLine("Who was he talking about");
                Console.ReadKey();
                Console.WriteLine("I dont have time for figuring this out, i have to keep moving");
                Console.ReadKey();
                Magazin:
                Console.WriteLine("*You head to a bulding that has 'magazin' written on it");
                Console.ReadKey();
                Console.WriteLine("*You head inside");
                Console.ReadKey();
                Disturbing:
                Console.WriteLine("****What you see in there is very disturbing****");
                DisturbingCH:
                Console.WriteLine("Do you wish to see what Mr.B saw?\n1.Yes\n2.No");
                string ChMagazin = Console.ReadLine();
                if (ChMagazin == "1")
                {
                    using (StreamReader HangMan = new StreamReader(path + @"\HangingMan.txt"))
                    {
                        string HangedMan = HangMan.ReadToEnd();
                        Console.WriteLine(HangedMan);
                        Console.ReadKey();
                        goto DabbingCauses;
                    }
                }
                if (ChMagazin == "2")
                {
                    Console.WriteLine("Good choice");
                    Console.ReadKey();
                }
                else
                {
                    goto DisturbingCH;
                }
                DabbingCauses:
                Console.WriteLine("Mr.B: This is horrific");
                Console.ReadKey();
                Console.Clear();
                WaterBottleCh:
                Console.WriteLine("*Bean heads out of the store");
                Console.ReadKey();
                using (StreamReader WaterBottle = new StreamReader(path + @"\WaterBottle.txt"))
                {
                    string WB = WaterBottle.ReadToEnd();
                    Console.WriteLine(WB);
                }
                Console.WriteLine("*He sees a waterbottle on the ground");
                Console.ReadKey();
                Console.WriteLine("Mr.B: Should i drink it?\n1.Yes\n2.No");
                string BottleCh = Console.ReadLine();
                if (BottleCh == "Yes")
                {
                    Random rand = new Random();

                    if (rand.Next(0, 2) == 0)
                    {
                        using (StreamReader DeathScreenWB = new StreamReader(path + @"\DeathScreen.txt"))
                        {
                            string DSWB = DeathScreenWB.ReadToEnd();
                            Console.WriteLine(DSWB);
                        }
                        Console.WriteLine("* You died to radiation poisoning");
                        Console.ReadKey();
                        WBRetry:
                        Console.WriteLine("Retry?\n1.Yes\n2.No");
                        string RetryBottle = Console.ReadLine();
                        if (RetryBottle == "Yes")
                        {
                            Console.Clear();
                            goto WaterBottleCh;
                        }
                        if (RetryBottle == "No")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            goto WaterBottleCh;
                        }
                    }
                    else
                    {
                        Console.WriteLine("* The water was luckly radiation free");

                        Console.ReadKey();
                    }
                }
                if (BottleCh == "No")
                {
                    Console.WriteLine("Your choice");
                    Console.ReadKey();
                }

                Console.WriteLine("* Bean looks around himself and sees a russian goblin");
                Console.ReadKey();
                Console.WriteLine("Russian Goblin:Ya sobirayus' tebya ubit'");
                Console.ReadKey();
                Console.WriteLine("* Bean preapers to fight");
                Console.ReadKey();
                Console.WriteLine("Mr.B:Dont try it Goblin!");
                Console.ReadKey();
                Console.WriteLine("Russian Goblin:Ty nedootsenivayesh' moyu moshch'");
                Console.ReadKey();
                Console.WriteLine("* Goblin jumps at Bean and combat begins");
                if (Secret_Code == "3499")
                {
                    Console.WriteLine("*****************Skipping Combat*****************");
                    Console.ReadKey();
                }
                else
                {
                    Combat.gayd();
                }
                Console.WriteLine("You knock the Goblin out. What he didn't realise is, that you had the high ground");
                Console.ReadKey();
                Console.WriteLine("Bean is getting tired, but he can't fall asleep");
                Console.ReadKey();
                Console.WriteLine("Suddenly bean hears multiple goblins behind him");
                Console.WriteLine("Bean gets knocked out");
                Console.ReadKey();
                Console.WriteLine("");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("*Bean wakes up");
                Console.ReadKey();
                Console.WriteLine("*Mr.B: What just happened?");
                Console.ReadKey();
                Console.WriteLine("???: SILENCE!");
                Console.ReadKey();
                Console.WriteLine("*Bean looks up and he sees a dabbing russian goblin, who can speak english");
                Console.ReadKey();
                Console.WriteLine("*Mr.B: Where am i?!?");
                Console.ReadKey();
                Console.WriteLine("???: You're in the house of The Chosen One, The One who is best at dabbing, Jake Paul");
                Console.ReadKey();
                Console.WriteLine("*Now we know what was that note about");
                Console.ReadKey();
                Console.WriteLine("???: Why are you here?");
                Console.ReadKey();
                Console.WriteLine("Mr.B: Who are you?");
                Console.ReadKey();
                Console.WriteLine("???: I ASKED WHY ARE YOU HERE");



            }
            else
            {
                goto Banana;
            }
        }
    }
}
