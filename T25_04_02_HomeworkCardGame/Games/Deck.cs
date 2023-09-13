﻿using T25_04_02_HomeworkCardGame.Enums;
using T25_04_02_HomeworkCardGame.Models;

namespace T25_04_02_HomeworkCardGame.Games
{
    internal abstract class Deck
    {
        protected List<PlayingCardModel> fullDeck = new();
        public List<PlayingCardModel> drawPile = new();
        // protected List<PlayingCardModel> discardPile = new();

        protected void CreateDeck()
        {
            fullDeck.Clear();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suit, Value = (CardValue)val });
                }
            }
        }

        public virtual void ShuffleDeck()
        {
            var rnd = new Random();
            drawPile = fullDeck.OrderBy(x => rnd.Next()).ToList();
        }

        public abstract void DealCards(PlayerModel player);

        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }

        public virtual PlayingCardModel DrawOneCard()
        {
            PlayingCardModel output = drawPile.Take(1).First();
            drawPile.Remove(output);
            return output;
        }
    }
}
