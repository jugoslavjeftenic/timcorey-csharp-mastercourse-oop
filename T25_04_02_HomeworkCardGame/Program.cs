
using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame
{
    // Build a similar project to what we did here but change it
    // just a bit so you are sure understand it.

    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                CardGameUI.WellcomeToGame();
                PlayerModel player = CardGameUI.CreatePlayer();


            } while (true);
        }
    }
}