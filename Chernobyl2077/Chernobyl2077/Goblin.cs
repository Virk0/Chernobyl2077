﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    class Goblin : Entity
    {
        public void TakeDamageGoblin()
        {
            Console.WriteLine("Goblin "+TakeDamage());
        }
    }
}
