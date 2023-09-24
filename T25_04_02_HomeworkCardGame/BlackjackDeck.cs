using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame
{
    internal class BlackjackDeck : Deck
    {
        internal BlackjackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        internal override List<PlayingCardModel> DealCards()
        {
            List<PlayingCardModel> output = new();

            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }

            return output;
        }

        internal PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }

        internal static void CheckForWin(List<PlayingCardModel> hand)
        {
            int totalCount = TotalCount(hand).totalCount;
            int aceCount = TotalCount(hand).aceCount;

            if (totalCount == 21 && aceCount == 1)
            {
                BlackJackUI.WonGame();
            }

            if (totalCount > 21 && aceCount == 0)
            {
                BlackJackUI.LostGame();
            }

            if (totalCount > 21 && aceCount > 0)
            {
                totalCount -= aceCount * 10;

                if (totalCount > 21)
                {
                    BlackJackUI.LostGame();
                }
            }

            if (totalCount >= 17 && totalCount <= 21)
            {
                BlackJackUI.WonGame();
            }
        }

        private static (int totalCount, int aceCount) TotalCount(List<PlayingCardModel> hand)
        {
            int totalCount = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                switch (card.Value)
                {
                    case Enums.CardValue.Ace:
                        totalCount += 11;
                        aceCount++;
                        break;
                    case Enums.CardValue.Two:
                        totalCount += 2;
                        break;
                    case Enums.CardValue.Three:
                        totalCount += 3;
                        break;
                    case Enums.CardValue.Four:
                        totalCount += 4;
                        break;
                    case Enums.CardValue.Five:
                        totalCount += 5;
                        break;
                    case Enums.CardValue.Six:
                        totalCount += 6;
                        break;
                    case Enums.CardValue.Seven:
                        totalCount += 7;
                        break;
                    case Enums.CardValue.Eight:
                        totalCount += 8;
                        break;
                    case Enums.CardValue.Nine:
                        totalCount += 9;
                        break;
                    default:
                        totalCount += 10;
                        break;
                }
            }

            return (totalCount, aceCount);
        }
    }
}
