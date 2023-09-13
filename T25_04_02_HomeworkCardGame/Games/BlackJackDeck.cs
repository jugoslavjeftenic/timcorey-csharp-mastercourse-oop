using System.Collections.Generic;
using System.Numerics;
using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame.Games
{
    internal class BlackJackDeck : Deck
    {
        internal BlackJackDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }

        internal override void DealCards(PlayerModel player)
        {
            for (int i = 0; i < 2; i++)
            {
                player.Hand.Add(DrawOneCard());
            }
        }

        internal static bool Hit(PlayerModel player)
        {
            if (player.IsComputerPlayer == false)
            {
                do
                {
                    Console.WriteLine();
                    Console.Write("Hit or Stand (hit/stand or \"exit\" to exit)? ");
                    string? answer = Console.ReadLine();

                    if (answer?.ToLower() == "h" || answer?.ToLower() == "hit")
                    {
                        return true;
                    }
                    else if (answer?.ToLower() == "s" || answer?.ToLower() == "stand")
                    {
                        return false;
                    }
                    else if (answer?.ToLower() == "exit")
                    {
                        CardGameUI.ExitGame();
                    }

                    Console.WriteLine("Please answer with \"h\"/\"s\" or \"exit\" to exit");
                } while (true);
            }
            else
            {
                return true;
            }
        }

        internal static (List<PlayerModel> winners, List<PlayerModel> loosers) CheckForWinner
            (List<PlayerModel> players)
        {
            List<PlayerModel> winners = new();
            List<PlayerModel> loosers = new();

            foreach (var player in players)
            {
                (int totalCount, int aceCount) = TotalCount(player);

                if (IsNatural(totalCount))
                {
                    winners.Add(player);
                    continue;
                }

                if (IsBust(totalCount, aceCount))
                {
                    loosers.Add(player);
                    continue;
                }
            }

            return (winners, loosers);
        }

        private static bool IsNatural(int totalCount)
        {
            if (totalCount == 21)
            {
                return true;
            }

            return false;
        }

        private static bool IsBust(int totalCount, int aceCount)
        {
            if (totalCount > 21 && aceCount == 0)
            {
                return true;
            }

            if (totalCount > 21 && aceCount > 0)
            {
                totalCount -= 10;

                if (totalCount > 21)
                {
                    return true;
                }
            }

            return false;
        }

        private static (int totalCount, int aceCount) TotalCount(PlayerModel player)
        {
            int totalCount = 0;
            int aceCount = 0;

            foreach (var card in player.Hand)
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
