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
        public static void GPNAS()
        {
                Console.WriteLine("Press enter to proceed");
                Console.ReadKey();
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
                Console.WriteLine("Insert Combat system[NO COMBAT YET IN GAME]");
                System.Threading.Thread.Sleep(3000);
                string Outcome = "Player won";
                if (Outcome == "Player won")
                {
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
                    Console.WriteLine("You inspect the persons body, who you killed before");
                    Console.ReadKey();
                    Console.WriteLine("You find out that they are radiated russian gopniks");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("This what Chernobyl explosion did to them");
                    System.Threading.Thread.Sleep(500);
                    Console.WriteLine("Poor Chernobyl Gopniks");
                    Console.ReadKey();
                    Console.WriteLine("You start walking down the road[4 sec]");
                    System.Threading.Thread.Sleep(4000);
                Roads:
                    Console.WriteLine("The road splits to three:\n1.Dzheff memy\n2.net avtomobiley\n3.banan\n4.smert'");
                    Console.WriteLine("Which are you gonna go?");
                    string choiseRoad = Console.ReadLine();
                    if (choiseRoad == "1")
                    {
                        Console.WriteLine("You decide do go to Dzheff memy");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("You arrive");
                        Console.WriteLine("You hear 'MYNAMAJEF' from far away");
                        Console.WriteLine("You see 2 Gopniks squatting nearby");
                        Console.ReadKey();
                        Console.WriteLine("Russian Gopnik: Ubiraysya otsyuda!");
                        Console.WriteLine("You dont understand anything, as usual");
                        Console.ReadKey();
                        Console.WriteLine("Mr.B: Can't you just speak English?");
                        Console.WriteLine("Mr Bean realised that was a dumb question");
                        Console.ReadKey();
                        Console.WriteLine("2 Gopniks decide to attack");
                    Combat2:
                        Console.WriteLine("You enter combat with the 2 russian copniks");
                    }
                    if (choiseRoad == "2")
                    {
                        Console.WriteLine("You decide do go to net avtomobiley");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("You arrive");
                        Console.WriteLine("You don't see any cars nearby");
                        Console.ReadKey();
                        Console.WriteLine("But what you do see is 3 Gopniks, oh great");

                    }
                    if (choiseRoad == "3")
                    {
                        Console.WriteLine("You decide do go to banan");
                        System.Threading.Thread.Sleep(3000);
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
                            System.Threading.Thread.Sleep(2000);
                            using (StreamReader DS = new StreamReader(@"C:\Users\User\Documents\GitHub\Chernobyl2077\Art\DeathScreen.txt")) //Vaheta User opilaseks [opilane]
                        {
                                String DS_ = DS.ReadToEnd();
                                Console.WriteLine(DS_);
                                Console.WriteLine("Do you wish to try again?\n1.Yes\n2.No");
                                string choiseBaDead = Console.ReadLine();
                                if (choiseBaDead == "1")
                                {
                                    Console.WriteLine("Returning to your choise");
                                    System.Threading.Thread.Sleep(1000);
                                    goto Banana;
                                }
                                if (choiseBaDead == "2")
                                {
                                    Console.WriteLine("Okay");
                                    System.Threading.Thread.Sleep(1000);
                                    goto Roads;
                                }
                            }
                        }
                        if (choiseBanana == "2")
                        {
                            Console.WriteLine("Good job, you didn't eat a radiated banana");
                            Console.WriteLine("But you still see those russians");
                            Console.WriteLine("Actually 3 of them");
                        }

                    }
                    if (choiseRoad == "4")
                    {
                        Console.WriteLine("You decided do go to smert'");
                        Console.WriteLine("smert' could mean death in russian");
                        System.Threading.Thread.Sleep(3000);
                        Console.WriteLine("you arrive");
                        Console.WriteLine("you are dying from radiation poisoning");
                        using (StreamReader DeathScreen2 = new StreamReader(@"C:\Users\User\Documents\GitHub\Chernobyl2077\Art\DeathScreen.txt")) //Vaheta User opilaseks [opilane]
                    {
                            string DS2 = DeathScreen2.ReadToEnd();
                            Console.WriteLine(DS2);
                            Console.WriteLine("Do you wish to try again?\n1.Yes\n2.No");
                            string choiseBaDead = Console.ReadLine();
                            if (choiseBaDead == "1")
                            {
                                Console.WriteLine("Returning to roads");
                                System.Threading.Thread.Sleep(1000);
                                goto Roads;
                            }
                            if (choiseBaDead == "2")
                            {
                                Console.WriteLine("Okay");
                                System.Threading.Thread.Sleep(1000);
                                Environment.Exit(0);
                            }
                        }
                    }
                    else
                    {
                        goto Roads;
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
