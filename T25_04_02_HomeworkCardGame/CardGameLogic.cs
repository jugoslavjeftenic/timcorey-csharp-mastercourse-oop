
using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame
{
    internal class CardGameLogic
    {
        internal static PlayerModel CreatePlayer(bool isComputerPlayer = false)
        {
            PlayerModel player = new(isComputerPlayer);
            return player;
        }
    }
}
