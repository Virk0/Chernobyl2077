﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    public class MrBean : Entity
    {
        public int mrBeanAP = 30;
        public int mrBeanHeavyAP = 50;
        public int mrBeanShieldAttackAP = 15;
        public int mrBeanDabAP = 3499;
        public int mrBeanHP = 100;

        public void Dabberino()
        {
            Console.WriteLine("Mr Bean dabs!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("The hater dies!");
        }
        public void Attackk()
        {
            Console.WriteLine("Mr Bean" + Attack());
        }
        public void TakeDamagee()
        {
            Console.WriteLine("Mr Bean " + TakeDamage1());
        }
        public void HeavyAttack()
        {
            Console.WriteLine("Mr Bean" + Heavy());
        }
        public void AttackShield()
        {
            Console.WriteLine("Mr Bean" + Attack_Shield());
        }
    }
}
