namespace T27_02_01_Events
{
    internal class Program
    {
        static void Main()
        {
            CollegeClassModel history = new("History 101", 3);
            CollegeClassModel math = new("Calculus 201", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull!;

            history.SingUpStudent("Tim Corey").PrintToConsole();
            history.SingUpStudent("Sue Storm").PrintToConsole();
            history.SingUpStudent("Joe Smith").PrintToConsole();
            history.SingUpStudent("Mary Jones").PrintToConsole();
            history.SingUpStudent("Sandy Patty").PrintToConsole();

            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull!;

            math.SingUpStudent("Sue Storm").PrintToConsole();
            math.SingUpStudent("Joe Smith").PrintToConsole();
            math.SingUpStudent("Mary Jones").PrintToConsole();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            //Console.WriteLine($"- {e}");

            CollegeClassModel model = (CollegeClassModel)sender;
            Console.WriteLine($"- {model?.CourseTitle}: Full");
        }
    }
}