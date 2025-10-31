using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.I
{
    internal class GoodIExample
    {
        public interface IPhysicalSkill {
            void PhysicalAttack();
            void UseShield();
        }
        public interface IMagicalSkillP {
            void CastSpell(string spellName);
            void CheckMana();
        }
        public interface ISupportSkill {
            void Heal(int amount);
            void ApplyBuff();
        }
        public class Warrior : IPhysicalSkill 
        {
            public void PhysicalAttack()
            {
                Console.WriteLine("Warrior swings sword for physical damage.");
            }

            public void UseShield()
            {
                Console.WriteLine("Warrior raises shield to block.");
            }
        }
        public class Priest : ISupportSkill 
        {
            public void ApplyBuff()
            {
                Console.WriteLine("Apply Buff");
            }
            public void Heal(int amount)
            {
                Console.WriteLine("Heal " + amount);
            }
        }
        public class Monk : ISupportSkill, IPhysicalSkill
        {
            public void ApplyBuff()
            {
                Console.WriteLine("Apply Buff self");
            }
            public void Heal(int amount)
            {
                Console.WriteLine("Heal self");
            }
            public void PhysicalAttack()
            {
                Console.WriteLine("Combo attack");
            }
            public void UseShield()
            {
                Console.WriteLine("Block some damage");
            }
        }
    }
}
