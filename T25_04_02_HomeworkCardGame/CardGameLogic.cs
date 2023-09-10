
using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame
{
    internal class CardGameLogic
    {
        public static PlayerModel CreatePlayer(bool isComputerPlayer = false)
        {
            PlayerModel player = new(isComputerPlayer);
            return player;
        }

        protected virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    }
}
