
using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame
{
    internal static class CardGameUI
    {
        public static void WellcomeToGame()
        {
            Console.Clear();
            Console.WriteLine("WELCOME to the Card Game.");
            Console.WriteLine("(type \"exit\" at any time to exit the game)");
            Console.WriteLine();
        }

        public static string AskForPlayerName()
        {
            Console.Write("Please enter your game name or \"exit\" to exit: ");

            string playerName;
            do
            {
                if (string.IsNullOrWhiteSpace(playerName = Console.ReadLine()?.Trim() ?? ""))
                {
                    Console.Write("Please enter your game name or \"exit\" to exit: ");
                }
                else if (playerName.ToLower() == "exit")
                {
                    ExitGame();
                }
                else
                {
                    return $"{playerName[..1].ToUpper()}{playerName[1..]}";
                }
            } while (true);

        }

        public static void ShowHand(PlayerModel player)
        {
            Console.WriteLine();
            Console.WriteLine($"{player.PlayerName}'s hand:");
            foreach (var card in player.Hand)
            {
                Console.WriteLine($"{card.Suit,10} - {card.Value}");
            }
        }

        public static void PlayerWon(PlayerModel player)
        {
            Console.WriteLine();
            Console.WriteLine($"Player {player.PlayerName} has won the game.");
            ExitGame();
        }

        public static void PlayerLost(PlayerModel player)
        {
            Console.WriteLine();
            Console.WriteLine($"Player {player.PlayerName} has lost the game.");
            ExitGame();
        }

        public static void ExitGame()
        {
            Console.WriteLine();
            Console.WriteLine("Thank You for playing. Goodbye.");
            Environment.Exit(0);
        }
    }
}
