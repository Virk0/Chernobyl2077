using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    public class MrBean : Entity
    {
        public int mrBeanAP = 10;
        public int MrBeanDabAP = 3499;
        public int mrBeanHP = 100;
        public void Dabberino()
        {
            Console.WriteLine("Mr Bean dabs!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("The hater dies!");
            System.Threading.Thread.Sleep(1000);
        }
        public void Attackk()
        {
            Console.WriteLine("Mr Bean" + Attack());
            System.Threading.Thread.Sleep(1000);
        }
        public void TakeDamagee()
        {
            Console.WriteLine("Mr Bean "+TakeDamage1());
            System.Threading.Thread.Sleep(1000);
        }
    }
}
