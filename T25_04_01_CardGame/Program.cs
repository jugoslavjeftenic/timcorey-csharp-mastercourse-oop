namespace T25_04_01_CardGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PokerDeck deck = new PokerDeck();
            BlackjackDeck deck = new BlackjackDeck();

            var hand = deck.DealCards();
            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Value.ToString()} of {card.Suit.ToString()}");
            }
        }
    }
}