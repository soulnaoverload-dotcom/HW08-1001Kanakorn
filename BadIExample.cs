﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.I
{
    internal class BadIExample
    {
        public interface ICharacterSkills // Interface รวมใหญ่
        {
            // สกิลทางกายภาพ
            void PhysicalAttack();
            void UseShield();

            // สกิลเวทมนตร์
            void CastSpell(string spellName);
            void CheckMana();

            // สกิลสนับสนุน
            void Heal(int amount);
            void ApplyBuff();
        }

        // คลาส นักรบ (Warrior) - เน้นการต่อสู้ทางกายภาพ
        public class MeleeFighter : ICharacterSkills
        {
            // ใช้งานจริง: สกิลทางกายภาพ
            public void PhysicalAttack()
            {
                Console.WriteLine("Warrior swings sword for physical damage.");
            }

            public void UseShield()
            {
                Console.WriteLine("Warrior raises shield to block.");
            }

            // โค้ดที่ถูกบังคับให้มี: สกิลเวทมนตร์และสนับสนุน
            public void CastSpell(string spellName)
            {
                // นักรบไม่มีเวทมนตร์ จึงถูกบังคับให้มีเมธอดที่ว่างเปล่าหรือโยน Exception
                throw new System.Exception("A Melee Fighter cannot cast spells!");
            }

            public void CheckMana()
            {
                // นักรบไม่มีมานา จึงถูกบังคับให้มีเมธอดที่ไม่มีความหมาย
            }

            public void Heal(int amount)
            {
                // นักรบไม่สามารถรักษาตัวเองได้
                Console.WriteLine("Melee Fighter tries to heal... but fails.");
            }

            public void ApplyBuff()
            {
                // บังคับให้ต้องมีเมธอดนี้
            }
        }
    }
}
