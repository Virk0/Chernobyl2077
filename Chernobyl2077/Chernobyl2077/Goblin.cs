using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chernobyl2077
{
    public class Goblin : Entity
    {
        //string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName,"");
        //if (rand.Next(0, 100) <= 50)
        //        Console.WriteLine("You died");
        //    else
        //        Console.WriteLine("You live");

        Random randomValues = new Random();
        public int GoblinHP, GoblinAP;
        MrBean mr = new MrBean();
        //string[] lines = File.ReadAllLines(path + "\\" + konto.Name + ".txt");
        //if (konto.Pin == lines[0])
        public void GoblinAttack()
        {
            Console.WriteLine("The goblin" + Attack());
            System.Threading.Thread.Sleep(1000);
        }
        public void GoblinHPP()
        {
            GoblinHP = randomValues.Next(5, 20);
        }
        public void TakeDamageGoblin()
        {
            Console.WriteLine("Goblin " + TakeDamage1() + mr.mrBeanAP + TakeDamage2());
            System.Threading.Thread.Sleep(1000);
        }

    }
}
