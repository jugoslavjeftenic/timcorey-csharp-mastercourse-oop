
using T21_02_BattleshipLightLibrary.Models;

namespace T21_02_BattleshipLightLibrary
{
    public class GameLogic
    {
        public static void InitilizeGrid(PlayerInfoModel model)
        {
            List<string> letters = new() { "A", "B", "C", "D", "E" };
            List<int> numbers = new() { 1, 2, 3, 4, 5 };

            foreach (string letter in letters)
            {
                foreach (int number in numbers)
                {
                    AddGridSpot(model, letter, number);
                }
            }
        }

        private static void AddGridSpot(PlayerInfoModel model, string letter, int number)
        {
            GridSpotModel spot = new()
            {
                SpotLetter = letter,
                SpotNumber = number,
                Status = GridSpotStatus.Empty
            };

            model.ShotGrid.Add(spot);
        }

        public static bool PlaceShip(PlayerInfoModel model, string? location)
        {
            throw new NotImplementedException();
        }
    }
}
