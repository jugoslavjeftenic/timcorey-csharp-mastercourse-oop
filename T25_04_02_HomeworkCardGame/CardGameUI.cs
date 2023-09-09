
using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame
{
    internal static class CardGameUI
    {
        public static void WellcomeToGame()
        {
            //Console.Clear();
            Console.WriteLine("Welcome to the Card Game.");
            Console.WriteLine("Type \"exit\" at any time to exit the game.");
            Console.WriteLine();
        }

        public static PlayerModel CreatePlayer()
        {
            Console.Write("What will be your game name? ");

            string? playerName;
            do
            {
                if (string.IsNullOrWhiteSpace(playerName = Console.ReadLine()))
                {
                    Console.Write("Please enter your game name or \"exit\" to exit: ");
                }
                else if (playerName.ToLower() == "exit")
                {
                    ExitGame();
                }
                else
                {
                    PlayerModel player = new()
                    {
                        PlayerName = $"{playerName[..1].ToUpper()}{playerName[1..]}"
                    };
                    return player;
                }
            } while (true);
        }

        public static void ExitGame()
        {
            Console.WriteLine("Thank You for playing. Goodbye.");
            Environment.Exit(0);
        }
    }
}
