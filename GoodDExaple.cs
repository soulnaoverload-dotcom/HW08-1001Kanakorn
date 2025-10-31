using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.D
{
    internal class GoodDExample
    {
        private Enemy _enemy;

        public GoodDExample(Enemy enemy)
        {
            // GameManager สร้างและพึ่งพา GoblinEnemy โดยตรง (Tight Coupling)
            _enemy = enemy;
        }

        public void StartWave()
        {
            Console.WriteLine("--- Game Manager Starts Wave ---");
            _enemy.Spawn();
            _enemy.PerformAction();
        }
    }
}
