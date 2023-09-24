using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame
{
    internal static class BlackJackUI
    {
        internal static void Wellcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Black Jack card game.");
            Console.WriteLine("To win the game you have to score between 17 and 21.");
            Console.WriteLine();
        }

        internal static void ShowHand(List<PlayingCardModel> hand)
        {
            Console.WriteLine("Your hand:");

            foreach (var card in hand)
            {
                Console.WriteLine($"- {card.Suit,8} of {card.Value}");
            }
        }

        internal static bool Hit()
        {
            Console.WriteLine();
            Console.Write("Hit? ");
            string? answer = Console.ReadLine()?.Trim().ToLower();

            if (answer == "hit" || answer == "yes" || answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal static void WonGame()
        {
            Console.WriteLine();
            Console.WriteLine("You WON!");
            Console.WriteLine("Thank You for playing.");
            EndGame();
        }

        internal static void LostGame()
        {
            Console.WriteLine();
            Console.WriteLine("You lost. Better luck next time.");
            Console.WriteLine("Thank You for playing.");
            EndGame();
        }

        private static void EndGame()
        {
            Environment.Exit(0);
        }
    }
}
