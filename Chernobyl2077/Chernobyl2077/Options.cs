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
            using (StreamReader Main_Logo = new StreamReader(path + @"\MainLogo.txt")) 
            {
                using (StreamReader Main_Icon = new StreamReader(path + @"\Icon.txt")) 
                {
                    string Icon = Main_Icon.ReadToEnd();
                    Console.WriteLine(Icon);
                    string MLogo = Main_Logo.ReadToEnd();
                    Console.WriteLine(MLogo);
                }
            }
            Console.WriteLine("What do you wish to change\n1.???\n2.???\n3.Back to main menu\nSecret Code.Skip");
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
            if (OptionsCh == "3499")
            {
                Console.WriteLine("Which chapter?\n1.\n2.Banan\n3.DoChYes\n4.DoChNo\n4.1.House By The Road\n5.Kalmarov");
                string Ch = Console.ReadLine();
                if (Ch == "1")
                {
                    GameplayNAS.GPNAS();
                }
                if (Ch == "2")
                {
                    BananNAS.BaNAS();
                }
                if (Ch == "3")
                {
                    DoChYes.DchY();
                }
                if (Ch == "4")
                {
                    DoChNo.DchN();
                }
                if (Ch == "5")
                {
                    RoadToKlamaRov.RoToKalMa();
                }
                if (Ch == "4.1")
                {
                    HouseByTheRoad.HoByThRo();
                }
            }

        }
        
    }

}
