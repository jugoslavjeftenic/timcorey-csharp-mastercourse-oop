namespace T27_03_02_HomeworkMiniProject
{
    internal class TaskModel
    {
        public event EventHandler<string>? OverdueFound;

        public string Name { get; set; }
        public string Description { get; set; }
        public TimeSpan PlannedDuration { get; set; }
        public TimeSpan Duration { get; set; }

        public TaskModel(string name, string description, TimeSpan plannedDuration)
        {
            Name = name;
            Description = description;
            PlannedDuration = plannedDuration;
        }

        public void AddImplementation(TimeSpan duration)
        {
            Duration = duration;

            if (Duration > PlannedDuration)
            {
                OverdueFound?.Invoke(this, $"- Task \"{Name}\" implementation is longer then planned implementation!");
            }
        }
    }
}
