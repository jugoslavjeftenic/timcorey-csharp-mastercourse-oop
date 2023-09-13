
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
                List<PlayerModel> players = new()
                {
                    CardGameLogic.CreatePlayer(),
                    CardGameLogic.CreatePlayer(isComputerPlayer: true)
                };


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

                        if (BlackJackDeck.IsNatural(player))
                        {
                            CardGameUI.PlayerWon(player);
                        }

                        if (BlackJackDeck.IsBust(player))
                        {
                            CardGameUI.PlayerLost(player);
                        }

                        if (BlackJackDeck.Hit(player))
                        {
                            player.Hand.Add(blackJack.DrawOneCard());
                            CardGameUI.ShowHand(player);
                        }

                        if (BlackJackDeck.IsNatural(player))
                        {
                            CardGameUI.PlayerWon(player);
                        }

                        if (BlackJackDeck.IsBust(player))
                        {
                            CardGameUI.PlayerLost(player);
                        }
                    }

                    //Console.ReadKey();
                    //CardGameUI.ExitGame();
                } while (true);
            } while (true);
        }
    }
}