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
        public string AutoScroll()
        {
            string AutoScroll = Console.ReadLine(); ;
            return AutoScroll;
        }
        public static void Op()
        {
            Options:
            Console.Clear();
            using (StreamReader Main_Logo = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\MainLogo.txt")) //Vaheta User opilaseks [opilane]
            {
                using (StreamReader Main_Icon = new StreamReader(@"C:\Users\opilane\Documents\GitHub\Chernobyl2077\Art\Icon.txt")) //Vaheta User opilaseks [opilane]
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
                Console.WriteLine("Ya Yiit");
            }
            if (OptionsCh == "3")
            {
                MainMenu.MaMeLoaded();
            }

        }
        
    }

}
