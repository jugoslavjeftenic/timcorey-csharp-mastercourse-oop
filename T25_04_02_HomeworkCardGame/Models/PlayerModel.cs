
namespace T25_04_02_HomeworkCardGame.Models
{
    internal class PlayerModel
    {
        public string? PlayerName { get; set; }
        public List<PlayingCardModel> Hand { get; set; }

        public PlayerModel()
        {
            Hand = new List<PlayingCardModel>();
        }
    }
}
