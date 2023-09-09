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

        public override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new();

            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }
    }
}
