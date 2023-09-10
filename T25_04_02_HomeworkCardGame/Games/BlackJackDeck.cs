using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame.Games
{
    internal class BlackJackDeck : Deck
    {
        public BlackJackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        public override void DealCards(PlayerModel player)
        {
            for (int i = 0; i < 2; i++)
            {
                player.Hand.Add(DrawOneCard());
            }
        }
    }
}
