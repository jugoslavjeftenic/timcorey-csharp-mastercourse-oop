
namespace T21_02_BattleshipLightLibrary.Models
{
    public class PlayerInfoModel
    {
        public string? UserName { get; set; }
        public List<GridSpotModel>? ShipLocations { get; set; }
        public List<GridSpotModel>? ShotGrid { get; set; }
    }
}
