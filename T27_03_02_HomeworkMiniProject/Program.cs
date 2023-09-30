namespace T27_03_02_HomeworkMiniProject
{
    // Recreate the project we just did without looking back at the video.
    // Make sure to make small tweaks.

    internal class Program
    {
        static void Main()
        {
            // Instantiate TaskModel
            List<TaskModel> tasks = new()
            {
                new TaskModel(
                    "Printer delivery",
                    "Deliver and install network printer.",
                    new TimeSpan(1, 0, 0)),
                new TaskModel(
                    "MS Office 365 instalation",
                    "Install O365 and connect with user account.",
                    new TimeSpan(1, 40, 0)),
                new TaskModel(
                    "Laptop upgrade",
                    "Replace HDD with SSD in user laptop.",
                    new TimeSpan(1, 0, 0)),
            };

            // Monitor task events
            foreach (var task in tasks)
            {
                task.OverdueFound += Program_OverdueFound;
            }

            // Update task values
            tasks[0].AddImplementation(new TimeSpan(0, 40, 0));
            tasks[1].AddImplementation(new TimeSpan(1, 20, 0));
            tasks[2].AddImplementation(new TimeSpan(2, 10, 0));

            // Instantiate TripModel
            List<TripModel> trips = new()
            {
                new TripModel("Subotica","Sombor",60.0f),
                new TripModel("Sombor","Odzaci",35.9f),
                new TripModel("Odzaci","Subotica",84.4f),
            };

            // Monitor trip events
            foreach (var trip in trips)
            {
                trip.OverdueFound += Program_OverdueFound;
            }

            // Update trip values
            trips[0].AddImplementation(61.2f);
            trips[1].AddImplementation(32.7f);
            trips[2].AddImplementation(93.4f);

            // Export to csv
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), $@"..\..\..\");

            tasks.SaveToCSV($"{filePath}tasks.csv");
            trips.SaveToCSV($"{filePath}trips.csv");
        }

        private static void Program_OverdueFound(object? sender, string e)
        {
            // Handle events
            Console.WriteLine(e);
        }
    }
}