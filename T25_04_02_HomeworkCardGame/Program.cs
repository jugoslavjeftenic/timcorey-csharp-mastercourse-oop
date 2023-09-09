
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
                PlayerModel humanPlayer = CardGameLogic.CreatePlayer();
                PlayerModel computerPlayer = CardGameLogic.CreatePlayer(isComputerPlayer: true);

                Console.WriteLine(humanPlayer.PlayerName);
                Console.WriteLine(computerPlayer.PlayerName);

                //Console.ReadKey();
                CardGameUI.ExitGame();
            } while (true);
        }
    }
}