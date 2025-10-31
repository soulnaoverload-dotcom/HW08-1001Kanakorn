using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Week09_S.O.L.I.D.S
{
    internal class Movement
    {
        public void Move(PlayerData playerData, float deltaX, float deltaY)
        {
            playerData.PositionX += deltaX;
            playerData.PositionY += deltaY;
            Console.WriteLine($"{playerData.PlayerName} " +
                $"moved to ({playerData.PositionX}," +
                $", {playerData.PositionY})");
        }
    }
}
