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
    class Options
    {
        public static void Op()
        {
            Options:
            Console.Clear();
            using (StreamReader Main_Logo = new StreamReader(@"C:\Users\User\Documents\GitHub\Chernobyl2077\Art\MainLogo.txt")) //Vaheta User opilaseks [opilane]
            {
                using (StreamReader Main_Icon = new StreamReader(@"C:\Users\User\Documents\GitHub\Chernobyl2077\Art\Icon.txt")) //Vaheta User opilaseks [opilane]
                {
                    string Icon = Main_Icon.ReadToEnd();
                    Console.WriteLine(Icon);
                    string MLogo = Main_Logo.ReadToEnd();
                    Console.WriteLine(MLogo);
                }
            }
            Console.WriteLine("What do you wish to change\n1.Auto Scroll\n2.???\n3.Back to main menu");
            Console.WriteLine("Enter you choie:");
            string OptionsCh = Console.ReadLine();
            if (OptionsCh == "1")
            {
                Console.WriteLine("Do you want autoscroll?\n1.Yes\n2.No");
                string AutoScrollCh = Console.ReadLine();
                if (AutoScrollCh == "1")
                {
                    Console.WriteLine("Turning AutoScroll on");
                    System.Threading.Thread.Sleep(2000);
                    Options.Op();
                }
                if (AutoScrollCh == "2")
                {
                    Console.WriteLine("Turning AutoScroll off");
                    System.Threading.Thread.Sleep(2000);
                    Options.Op();

                }

            }
            if (OptionsCh == "3")
            {
                MainMenu.MaMeLoaded();
            }

        }
        
    }

}
