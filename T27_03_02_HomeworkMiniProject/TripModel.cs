namespace T27_03_02_HomeworkMiniProject
{
    internal class TripModel
    {
        public event EventHandler<string>? OverdueFound;

        public string StartingCity { get; set; }
        public string DestinationCity { get; set; }
        public float PlannedDistanceInKM { get; set; }
        public float DistanceInKM { get; set; }

        public TripModel(string startingCity, string destinationCity, float plannedDistanceInKM)
        {
            StartingCity = startingCity;
            DestinationCity = destinationCity;
            PlannedDistanceInKM = plannedDistanceInKM;
        }

        public void AddImplementation(float distanceInKM)
        {
            DistanceInKM = distanceInKM;

            if (DistanceInKM > PlannedDistanceInKM)
            {
                OverdueFound?.Invoke(this,
                    $"- Distance traveled from {StartingCity} to {DestinationCity} is longer then planned distance.");
            }
        }
    }
}
