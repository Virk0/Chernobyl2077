using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chernobyl2077
{
    public class Entity : Random
    {
        public int HP, MP, AP;

        public string Attack()
        {
            string xd = " attacks!";
            return xd;
        }

        public string TakeDamage1()
        {
            string bxd = "takes ";
            return bxd;
        }
        public string TakeDamage2()
        {
            string cxd = " damage!";
            return cxd;
        }
    }
}
