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
        public int GoblinHP, GoblinAP;
        MrBean mr = new MrBean();
        public int SuperGoblinHP = 40;

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
    }
}
