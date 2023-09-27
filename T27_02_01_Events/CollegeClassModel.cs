namespace T27_02_01_Events
{
    public class CollegeClassModel
    {
        public event EventHandler<string>? EnrollmentFull;

        private readonly List<string> enrolledStudents = new();
        private readonly List<string> waitingList = new();

        public string CourseTitle { get; private set; }
        public int MaximumStudents { get; set; }

        public CollegeClassModel(string courseTitle, int maximumStudents)
        {
            CourseTitle = courseTitle;
            MaximumStudents = maximumStudents;
        }

        public string SingUpStudent(string studentName)
        {
            string output;

            if (enrolledStudents.Count < MaximumStudents)
            {
                enrolledStudents.Add(studentName);
                output = $"{studentName} was enrolled in {CourseTitle}.";

                // Check to see if we are maxed out
                if (enrolledStudents.Count == MaximumStudents)
                {
                    EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is full.");
                }
            }
            else
            {
                waitingList.Add(studentName);
                output = $"{studentName} was added to the wait list in {CourseTitle}.";
            }

            return output;
        }
    }
}