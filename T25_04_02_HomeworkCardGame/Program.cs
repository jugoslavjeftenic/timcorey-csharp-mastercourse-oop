
using T25_04_02_HomeworkCardGame.Games;
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

                // Create players
                List<PlayerModel> players = new();
                players.Add(CardGameLogic.CreatePlayer());
                players.Add(CardGameLogic.CreatePlayer(isComputerPlayer: true));


                // Deal cards
                BlackJackDeck blackJack = new();
                foreach (var player in players)
                {
                    blackJack.DealCards(player);
                }

                do
                {
                    foreach (var player in players)
                    {
                        CardGameUI.ShowHand(player);
                        if (CardGameUI.DrawAnotherHand(player))
                        {
                            player.Hand.Add(blackJack.dr)
                        }
                    }

                    //Console.ReadKey();
                    CardGameUI.ExitGame();
                } while (true);
            } while (true);
        }
    }
}