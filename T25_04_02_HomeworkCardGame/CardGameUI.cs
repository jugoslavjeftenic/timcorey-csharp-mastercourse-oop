
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

        public static void ExitGame()
        {
            Console.WriteLine();
            Console.WriteLine("Thank You for playing. Goodbye.");
            Environment.Exit(0);
        }
    }
}
