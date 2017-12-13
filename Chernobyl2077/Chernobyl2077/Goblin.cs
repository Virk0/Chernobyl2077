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

        Random randomValues = new Random();
        int xd = (randomValues.Next(5, 20));
        public int GoblinHP = ;
        public int GoblinAP = 10;
        MrBean mr = new MrBean();
        //string[] lines = File.ReadAllLines(path + "\\" + konto.Name + ".txt");
                    //if (konto.Pin == lines[0])
        public void GoblinAttack()
        {
            Console.WriteLine("The goblin"+Attack());
        }
        public void TakeDamageGoblin()
        {
            Console.WriteLine("Goblin "+TakeDamage1()+mr.mrBeanAP+TakeDamage2());
        }
    }
}
