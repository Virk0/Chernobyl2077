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
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Art");
            Options:
            Console.Clear();
            using (StreamReader Main_Logo = new StreamReader(path + @"\MainLogo.txt")) //Vaheta User opilaseks [opilane]
            {
                using (StreamReader Main_Icon = new StreamReader(path + @"\Icon.txt")) //Vaheta User opilaseks [opilane]
                {
                    string Icon = Main_Icon.ReadToEnd();
                    Console.WriteLine(Icon);
                    string MLogo = Main_Logo.ReadToEnd();
                    Console.WriteLine(MLogo);
                }
            }
            Console.WriteLine("What do you wish to change\n1.???\n2.???\n3.Back to main menu");
            Console.WriteLine("Enter you choie:");
            string OptionsCh = Console.ReadLine();
            if (OptionsCh == "1")
            {
                Console.WriteLine("Ya Yiit"); //Ei asu enam siin
            }
            if (OptionsCh == "2")
            {
                Console.WriteLine("There is nothing here");
            }
            if (OptionsCh == "3")
            {
                MainMenu.MaMeLoaded();
            }

        }
        
    }

}
