using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    public class Entity
    {
        public int HP,MP,AP;
        public int mrBeanAP = 10;

        public string Attack()
        {
            string xd = " attacks!";
            return xd;
        }

        public string TakeDamage()
        {
            string bxd = "takes " +mrBeanAP+" damage!";
            return bxd;
        }
    }
}
