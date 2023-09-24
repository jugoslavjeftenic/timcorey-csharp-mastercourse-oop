namespace T25_04_02_HomeworkCardGame
{
    // Build a similar project to what we did here but
    // change it just a bit so you are sure you understand it.

    internal class Program
    {
        static void Main()
        {
            BlackJackUI.Wellcome();

            BlackjackDeck game = new();
            var hand = game.DealCards();

            BlackJackUI.ShowHand(hand);
            BlackjackDeck.CheckForWin(hand);

            do
            {
                if (BlackJackUI.Hit())
                {
                    hand.Add(game.RequestCard());
                    BlackJackUI.ShowHand(hand);
                    BlackjackDeck.CheckForWin(hand);
                }
                else
                {
                    BlackjackDeck.CheckForWin(hand);
                }
            } while (true);
        }
    }
}