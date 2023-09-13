
using T25_04_02_HomeworkCardGame.Enums;

namespace T25_04_02_HomeworkCardGame.Models
{
    internal class PlayerModel
    {
        internal bool IsComputerPlayer { get; private set; }
        internal string PlayerName { get; private set; }
        internal List<PlayingCardModel> Hand { get; set; }

        internal PlayerModel(bool isComputerPlayer)
        {
            IsComputerPlayer = isComputerPlayer;

            if (IsComputerPlayer)
            {
                Thread.Sleep(100);
                Random random = new((int)DateTime.Now.Ticks);
                int randomIndex = random.Next(Enum.GetValues(typeof(ComputerPlayerName)).Length);
                ComputerPlayerName randomName = (ComputerPlayerName)randomIndex;
                PlayerName = randomName.ToString();
            }
            else
            {
                PlayerName = CardGameUI.AskForPlayerName();
            }

            Hand = new List<PlayingCardModel>();
        }
    }
}
