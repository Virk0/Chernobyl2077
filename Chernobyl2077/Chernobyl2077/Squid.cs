using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    public class Squid : Entity
    {
        public int SquidHP = 200;
        public int SquidAP = 20;
        public int SquidDabAP = 3499;
        MrBean mr = new MrBean();

        public void SqAttack()
        {
            Console.WriteLine("The Squid attacks!");
        }
        public void TakeDamage()
        {
            Console.WriteLine("The Squid takes "+mr.mrBeanAP+TakeDamage2());
        }
        public void TakeHeavyDamage()
        {
            Console.WriteLine("The Squid takes "+mr.mrBeanHeavyAP+TakeDamage2());
        }
        public void TakeShieldDamage()
        {
            Console.WriteLine("The Squid takes "+mr.mrBeanShieldAttackAP+TakeDamage2());
        }
        public void Dab()
        {
            Console.WriteLine("The Squid dabs!");
            Console.WriteLine("It's super effective!");
        }
    }
}


