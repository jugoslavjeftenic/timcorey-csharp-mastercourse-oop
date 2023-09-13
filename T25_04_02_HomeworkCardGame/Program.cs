
using System.Numerics;
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
            CardGameUI.WellcomeToGame();

            // Create players
            List<PlayerModel> players = new()
                {
                    CardGameLogic.CreatePlayer(),
                    CardGameLogic.CreatePlayer(isComputerPlayer: true)
                };

            // Create game
            BlackJackDeck blackJack = new();

            // Deal cards
            foreach (var player in players)
            {
                blackJack.DealCards(player);
            }

            // Show the dealt hands
            Console.WriteLine("Dealt hands:");
            foreach (var player in players)
            {
                CardGameUI.ShowHand(player);
            }

            // Play game
            int turn = 0;

            do
            {
                Console.WriteLine($"Turn {++turn}:");

                if (BlackJackDeck.CheckForWinner(players).winners.Count > 0)
                {

                }

                foreach (var activePlayer in players)
                {

                    if (BlackJackDeck.Hit(activePlayer))
                    {
                        activePlayer.Hand.Add(blackJack.DrawOneCard());
                        CardGameUI.ShowHand(activePlayer);
                    }
                }
            } while (true);
        }
    }
}