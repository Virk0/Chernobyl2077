﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chernobyl2077
{
    public class Goblin : Entity
    {

        Random randomValues = new Random();
        public int GoblinHP;
        public int GoblinAP=15;
        MrBean mr = new MrBean();
        public int SuperGoblinHP = 70;
        public int SuperGoblinAP = 18;

        public void GoblinAttack()
        {
            Console.WriteLine("The goblin" + Attack());
            System.Threading.Thread.Sleep(1000);
        }
        public void GoblinHPP()
        {
            GoblinHP = randomValues.Next(20, 55);
        }
        public void TakeDamageGoblin()
        {
            Console.WriteLine("Goblin " + TakeDamage1() + mr.mrBeanAP + TakeDamage2());
            System.Threading.Thread.Sleep(1000);
        }
        public void TakeHeavyDamageGoblin()
        {
            Console.WriteLine("Goblin takes " + mr.mrBeanHeavyAP + TakeDamage2());
        }
        public void TakeShieldDamageGoblin()
        {
            Console.WriteLine("Goblin takes " + mr.mrBeanShieldAttackAP + TakeDamage2());
        }
        public void DGoblinAttack()
        {
            Console.WriteLine("The dabbler goblin" + Attack());
            System.Threading.Thread.Sleep(1000);
        }
        public void TakeDamageDGoblin()
        {
            Console.WriteLine("The dabbler Goblin " + TakeDamage1() + mr.mrBeanAP + TakeDamage2());
            System.Threading.Thread.Sleep(1000);
        }
        public void TakeHeavyDamageDGoblin()
        {
            Console.WriteLine("The dabbler Goblin takes " + mr.mrBeanHeavyAP + TakeDamage2());
        }
        public void TakeShieldDamageDGoblin()
        {
            Console.WriteLine("The dabbler Goblin takes " + mr.mrBeanShieldAttackAP + TakeDamage2());
        }
    }
}
