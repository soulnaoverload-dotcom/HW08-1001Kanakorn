using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.O
{
    internal class Sword : IBonusWeapon
    {
        public int BaseDamage = 8;
        public int GetDamage() 
        {
            return BaseDamage + 10;
        }
    }
}
