using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chernobyl2077
{
    class JakeP : Entity
    {
        //insert image
        public int JakePHP = 100;
        public int JakePAP = 15;
        public int JakePDabAP = 3499;
        MrBean mr = new MrBean();

        public void JakePAttack()
        {
            Console.WriteLine("Jake attacks!");
        }
        public void TakeDamage()
        {
            Console.WriteLine("Jake takes " + mr.mrBeanAP + TakeDamage2());
        }
        public void TakeHeavyDamage()
        {
            Console.WriteLine("Jake takes " + mr.mrBeanHeavyAP + TakeDamage2());
        }
        public void TakeShieldDamage()
        {
            Console.WriteLine("Jake takes " + mr.mrBeanShieldAttackAP + TakeDamage2());
        }
        public void Dab()
        {
            Console.WriteLine("Jake dabs!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("It's super effective!");
            System.Threading.Thread.Sleep(1500);
        }
    }
}
