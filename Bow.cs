using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.O
{
    internal class Bow : IBonusWeapon
    {
        public int BaseDamage = 5;
        public int GetDamage() 
        {
            return BaseDamage + 5;
        }
    }
}
