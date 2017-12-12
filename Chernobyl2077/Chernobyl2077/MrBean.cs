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
            Console.WriteLine("The hater dies!");
        }
        public void Attackk()
        {
            Console.WriteLine("Mr Bean" + Attack());
        }
        public void TakeDamagee()
        {
            Console.WriteLine("Mr Bean "+TakeDamage1());
        }
    }
}
