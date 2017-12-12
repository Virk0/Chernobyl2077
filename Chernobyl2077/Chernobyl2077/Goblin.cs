using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    class Goblin : Entity
    {
        int GoblinHP = 1;
        public void GoblinAttack()
        {
            Console.WriteLine("The goblin "+Attack());
        }
        public void TakeDamageGoblin()
        {
            Console.WriteLine("Goblin "+TakeDamage());
        }
    }
}
