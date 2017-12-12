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
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            Console.WriteLine("Press enter to proceed");
            string Secret_Code = Console.ReadLine();

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
            if (Secret_Code == "3499")
            {
                Console.WriteLine("*****************SKipping Combat*****************");
                Console.ReadKey();
            }
            if ( Secret_Code != "3499")
            {
                Entity aaa = new Entity();
                Goblin Goblin = new Goblin();
                MrBean MrBean = new MrBean();
                Combat_start:
                Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                string choice1 = (Console.ReadLine());
                if (choice1 == "1")
                {
                    Console.WriteLine("\n1.Attack\n2.Dab");
                    string choice2 = (Console.ReadLine());
                    if (choice2 == "1")
                    {
                        MrBean.Attackk();
                        Goblin.TakeDamageGoblin();
                        Goblin.GoblinHP = Goblin.GoblinHP - 10;
                        if (Goblin.GoblinHP == 0)
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
                    else if (choice2 == "2")
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
                else if (choice1 == "2")
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
            Console.ReadKey();
            string Outcome = "Player won";
                if (Outcome == "Player won")
            {
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
                            Combat2:
                            Console.WriteLine("You enter combat with the russian goblin");
                            Entity aaa = new Entity();
                            Goblin Goblin = new Goblin();
                            MrBean MrBean = new MrBean();
                            Combat_start:
                            Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                            string choice1 = (Console.ReadLine());
                            if (choice1 == "1")
                            {
                                Console.WriteLine("\n1.Attack\n2.Dab");
                                string choice2 = (Console.ReadLine());
                                if (choice2 == "1")
                                {
                                    MrBean.Attackk();
                                    Goblin.TakeDamageGoblin();
                                    Goblin.GoblinHP = Goblin.GoblinHP - 10;
                                    if (Goblin.GoblinHP == 0)
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
                                else if (choice2 == "2")
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
                            else if (choice1 == "2")
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
                        Console.WriteLine("After a long fight you beat him");
                        Console.ReadKey();
                        Console.WriteLine("You find 2 rubels on him");
                        Console.ReadKey();
                        Console.WriteLine("They aren't worth much");
                        Console.ReadKey();
                        Console.WriteLine("Mr.B: I have to keep moving, i dont want to die to radiation");
                        Console.ReadKey();
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
                                    goto Roads;
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
                                Combat3:
                                Console.WriteLine("You enter in combat with the Goblin");
                                Entity aaa = new Entity();
                                Goblin Goblin = new Goblin();
                                MrBean MrBean = new MrBean();
                                Combat_start:
                                Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                                string choice1 = (Console.ReadLine());
                                if (choice1 == "1")
                                {
                                    Console.WriteLine("\n1.Attack\n2.Dab");
                                    string choice2 = (Console.ReadLine());
                                    if (choice2 == "1")
                                    {
                                        MrBean.Attackk();
                                        Goblin.TakeDamageGoblin();
                                        Goblin.GoblinHP = Goblin.GoblinHP - 10;
                                        if (Goblin.GoblinHP == 0)
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
                                    else if (choice2 == "2")
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
                                else if (choice1 == "2")
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


                        }

                    }
                    if (choiseRoad == "2")
                    {
                        Console.WriteLine("You decide do go to net avtomobiley");
                        Console.ReadKey();
                        Console.WriteLine("You arrive");
                        Console.WriteLine("You don't see any cars nearby");
                        Console.ReadKey();
                        Console.WriteLine("But what you do see is another russian goblin, oh great");
                        if (Secret_Code == "3499")
                        {
                            Console.WriteLine("*****************Skipping Combat*****************");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("You enter in combat with the russian goblin");
                            Entity aaa = new Entity();
                            Goblin Goblin = new Goblin();
                            MrBean MrBean = new MrBean();
                            Combat_start:
                            Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                            string choice1 = (Console.ReadLine());
                            if (choice1 == "1")
                            {
                                Console.WriteLine("\n1.Attack\n2.Dab");
                                string choice2 = (Console.ReadLine());
                                if (choice2 == "1")
                                {
                                    MrBean.Attackk();
                                    Goblin.TakeDamageGoblin();
                                    Goblin.GoblinHP = Goblin.GoblinHP - 10;
                                    if (Goblin.GoblinHP == 0)
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
                                else if (choice2 == "2")
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
                            else if (choice1 == "2")
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
                        Console.WriteLine("The goblin falls down after the hard fight");
                        Console.ReadKey();
                        Console.WriteLine("You see a roadsign nearby with 'Banan' written on it");
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
                                    goto Roads;
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
                                Combat3:
                                Console.WriteLine("You enter in combat with the Russian goblin");
                                Entity aaa = new Entity();
                                Goblin Goblin = new Goblin();
                                MrBean MrBean = new MrBean();
                                Combat_start:
                                Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                                string choice1 = (Console.ReadLine());
                                if (choice1 == "1")
                                {
                                    Console.WriteLine("\n1.Attack\n2.Dab");
                                    string choice2 = (Console.ReadLine());
                                    if (choice2 == "1")
                                    {
                                        MrBean.Attackk();
                                        Goblin.TakeDamageGoblin();
                                        Goblin.GoblinHP = Goblin.GoblinHP - 10;
                                        if (Goblin.GoblinHP == 0)
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
                                    else if (choice2 == "2")
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
                                else if (choice1 == "2")
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
                            Console.WriteLine("You beat the goblin");
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
                            Console.WriteLine("You head to a bulding that has 'magazin' written on it");
                            Console.ReadKey();
                            Console.WriteLine("You head inside");
                            Console.ReadKey();
                            Disturbing:
                            Console.WriteLine("What you see in there is very disturbing");
                            Console.WriteLine("Do you wish to see what Mr.B saw?\n1.Yes\n.2No");
                            string ChMagazin = Console.ReadLine();
                            if (ChMagazin == "1")
                            {
                                using (StreamReader HangMan = new StreamReader(path + @"\HangingMan.txt"))
                                {
                                    string HangedMan = HangMan.ReadToEnd();
                                    Console.WriteLine(HangedMan);
                                    Console.ReadKey();
                                }
                            }
                            if (ChMagazin == "2")
                            {
                                Console.WriteLine("Good choice");
                                Console.ReadKey();
                            }
                            Console.WriteLine("Mr.B: This is what dabbing causes");
                            Console.ReadKey();
                            Console.WriteLine("Bean heads out of the store");
                            Console.ReadKey();
                            Console.WriteLine("He sees a waterbottle on the ground");
                            Console.ReadKey();
                            Console.WriteLine("Bean looks around himself and sees a russian goblin");
                            Console.ReadKey();
                            Console.WriteLine("Russian Goblin:Ya sobirayus' tebya ubit'");
                            Console.ReadKey();
                            Console.WriteLine("Bean preapers to fight");
                            Console.ReadKey();
                            Console.WriteLine("Goblin jumps at Bean and combat begins");
                            if (Secret_Code == "3499")
                            {
                                Console.WriteLine("*****************Skipping Combat*****************");
                                Console.ReadKey();
                            }
                            else
                            {
                                Combat3:
                                Console.WriteLine("You enter in combat with the Russian goblin");
                                Entity aaa = new Entity();
                                Goblin Goblin = new Goblin();
                                MrBean MrBean = new MrBean();
                                Combat_start:
                                Console.WriteLine("What will Mr Bean do?\n1.Fight\n2.Dodge");
                                string choice1 = (Console.ReadLine());
                                if (choice1 == "1")
                                {
                                    Console.WriteLine("\n1.Attack\n2.Dab");
                                    string choice2 = (Console.ReadLine());
                                    if (choice2 == "1")
                                    {
                                        MrBean.Attackk();
                                        Goblin.TakeDamageGoblin();
                                        Goblin.GoblinHP = Goblin.GoblinHP - 10;
                                        if (Goblin.GoblinHP == 0)
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
                                    else if (choice2 == "2")
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
                                else if (choice1 == "2")
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
                            Console.WriteLine("Bean wakes up");
                            Console.ReadKey();
                            Console.WriteLine("Mr.B: What just happened?");
                            Console.ReadKey();
                            Console.WriteLine("SILENCE!");
                            Console.ReadKey();
                            Console.WriteLine("Bean looks up and he sees a dabbing russian goblin, who can speak english");
                            Console.ReadKey();
                            Console.WriteLine("Mr.B: Where am i?!?");
                            Console.ReadKey();
                            Console.WriteLine("You're in the house of The Chosen One, The One who is best at dabbing, Jake Paul");
                            Console.ReadKey();
                            Console.WriteLine("Now we know what was that note about");
                            Console.ReadKey();

                        }

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
    }
}
