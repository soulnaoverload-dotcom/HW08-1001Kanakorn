using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.S
{
    internal class SaveSystem
    {
        public void SaveProgress(PlayerData playerData)
        {
            Console.WriteLine($"Saving game for" +
                $" {playerData.PlayerName}" +
                $" to local file...");
            // Logic for saving player data to a file
        }
    }
}
