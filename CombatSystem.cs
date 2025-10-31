using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.S
{
    internal class CombatSystem
    {
        public void TakeDamage(PlayerData playerData, int amount)
        {
            playerData.Health -= amount;
            Console.WriteLine($"{playerData.PlayerName}" +
                $" took {amount} " +
                $"damage. Health: {playerData.Health}");
            if (playerData.Health <= 0)
            {
                Console.WriteLine($"{playerData.PlayerName}" +
                    $" has been defeated!");
            }
        }
    }
}
