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
    class GameplayNAS
    {
        public readonly string Secret_Code2 ="meme";
        public static void GPNAS()
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            Console.WriteLine("Press enter to proceed");
            string Secret_Code = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Mr beany has finally arrived in chernobyl");
                Console.ReadKey();
                Console.WriteLine("Mr.B: It's even worse than i thought");
                Console.ReadKey();
                Console.WriteLine("Mr.B: This place is in ruins and radioactive");
                Console.ReadKey();
                Console.WriteLine("Suddenly a squatting person walks up to him and speaks gibberish to him");
                Console.ReadKey();
                Console.WriteLine("???: Chto ty zdes' delayesh'?");
                Console.ReadKey();
                Console.WriteLine("Mr Beany doesn't understand a single word this guy said");
                Console.ReadKey();
                Console.WriteLine("Mr.B: Wat?");
                Console.ReadKey();
                Console.WriteLine("???: Ty mozhesh' govorit' po russki?");
                Console.ReadKey();
                Console.WriteLine("Mr Bean still didn't undestand anything this being said");
                Console.ReadKey();
                Console.WriteLine("Beany tries to move past him");
                Console.ReadKey();
                Console.WriteLine("???: Gde vy dumayete, chto sobirayetes'");
                Console.ReadKey();
                Console.WriteLine("You enter in combat with the squatting man, who can only speak gibberish!");
            Combat1:
            if (Secret_Code == "3499")
            {
                Console.WriteLine("*****************SKipping Combat*****************");
                Console.ReadKey();
            }
            if ( Secret_Code != "3499")
            {
                Combat.gayd();
            }
                    Console.WriteLine("You proceed to a temporary station located near you");
                    Console.ReadKey();
                    Console.WriteLine("You see a man in the corner");
                    Console.WriteLine("???: What are you doing in these radioactive swamps?");
                    Console.ReadKey();
                    Console.WriteLine("Mr.B: I've come here to destroy a deadly diseas called 'DAB'");
                    Console.ReadKey();
                    Console.WriteLine("???: You must be a mad lad. Many people have tried to destroy it before, but they have either failed and lived to tell the tale or die");
                    Console.ReadKey();
                    Console.WriteLine("Mr.B: I had no option, i was sent by the Totally not FBI@TM");
                    Console.ReadKey();
                    Console.WriteLine("Ol Jhonny Boy: So you are their latest agent, i was sent here aswell in 2069, but i was trapped here with no food or water");
                    Console.ReadKey();
                    Console.WriteLine("I don't wanna end up like him, i have to move out and work");
                    Console.ReadKey();
                    Console.WriteLine("Mr.B:I have to go on with my misson, good luck surviving in here Jhonny");
                    Console.ReadKey();
                    Console.WriteLine("Ol Jhonny Boy: Y-you too!");
                    Console.ReadKey();
                    Console.WriteLine("You head out of the house and back on the road");
                    Console.ReadKey();
                    Console.WriteLine("You inspect the persons body, who you knocked out before");
                    Console.ReadKey();
                    Console.WriteLine("You find out that they are radiated russian gopniks");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("This what Chernobyl explosion did to them");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Poor Chernobyl Gopniks");
                    Console.ReadKey();
                    Console.WriteLine("You keep inspecting his body and you find a note");
                    Console.ReadKey();
                    using (StreamReader Note_1 = new StreamReader(path + @"\Note_1.txt"))
                    {
                        string Note1 = Note_1.ReadToEnd();
                        Console.WriteLine(Note1);
                    }
                    Console.ReadKey();
                    Console.WriteLine("You dont understand the letter");
                    Console.ReadKey();
                    Console.WriteLine("You start walking down the road");
                    Console.ReadKey();
                    Roads:
                    Console.WriteLine("The road splits to three:\n1.Dzheff memy\n2.net avtomobiley\n3.smert'");//\n3.banan\n4.smert'");
                    Console.WriteLine("Which are you gonna go?");
                    string choiseRoad = Console.ReadLine();
                    if (choiseRoad == "1")
                    {
                        Console.WriteLine("You decide do go to Dzheff memy");
                        Console.ReadKey();
                        Console.WriteLine("You arrive");
                        Console.WriteLine("You hear 'MYNAMAJEF' from far away");
                        Console.WriteLine("You see a Russian goblin squatting nearby");
                        Console.ReadKey();
                        Console.WriteLine("Russian Goblin: Ubiraysya otsyuda!");
                        Console.WriteLine("You dont understand anything, as usual");
                        Console.ReadKey();
                        Console.WriteLine("Mr.B: Can't you just speak English?");
                        Console.WriteLine("Mr Bean realised that was a dumb question");
                        Console.ReadKey();
                        Console.WriteLine("The Goblin decides to attack");
                        if (Secret_Code == "3499")
                        {
                            Console.WriteLine("*****************Skipping combat*****************");
                            Console.ReadKey();
                        }
                if (Secret_Code != "3499")
                {
                    Combat.gayd();
                }
                             Console.WriteLine("After a long fight you beat him");
                             Console.ReadKey();
                             Console.WriteLine("You find 2 rubels on him");
                             Console.ReadKey();
                             Console.WriteLine("They aren't worth much");
                             Console.ReadKey();
                             Console.WriteLine("Mr.B: I have to keep moving, i dont want to die to radiation");
                             Console.ReadKey();
                             BananNAS.BaNAS();

                        


                    }
                    if (choiseRoad == "2")
                    {
                        Console.WriteLine("*You decide do go to net avtomobiley");
                        Console.ReadKey();
                        Console.WriteLine("*You arrive");
                        Console.WriteLine("*You don't see any cars nearby");
                        Console.ReadKey();
                        Console.WriteLine("*But what you do see is another russian goblin, oh great");
                        if (Secret_Code == "3499")
                        {
                            Console.WriteLine("*****************Skipping Combat*****************");
                            Console.ReadKey();
                        }
                        else
                        {
                        Combat.gayd();
                        }
                        Console.WriteLine("*The goblin falls down after the hard fight");
                        Console.ReadKey();
                        BananNAS.BaNAS();
                    }
                    if (choiseRoad == "3")
                    {
                        Console.WriteLine("You decided do go to smert'");
                        Console.WriteLine("smert' could mean death in russian");
                        Console.ReadKey();
                        Console.WriteLine("you arrive");
                        Console.ReadKey();
                        Console.WriteLine("you are dying from radiation poisoning");
                        using (StreamReader DeathScreen2 = new StreamReader(path + @"\DeathScreen.txt"))
                        {
                            string DS2 = DeathScreen2.ReadToEnd();
                            Console.WriteLine(DS2);
                            Console.WriteLine("Do you wish to try again?\n1.Yes\n2.No");
                            string choiseBaDead = Console.ReadLine();
                            if (choiseBaDead == "1")
                            {
                                Console.WriteLine("Returning to roads");
                                Console.ReadKey();
                                goto Roads;
                            }
                            if (choiseBaDead == "2")
                            {
                                Console.WriteLine("Okay");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                        }
                    }
                    else
                    {
                        goto Roads;
                    }


                }

            }
            
        }
