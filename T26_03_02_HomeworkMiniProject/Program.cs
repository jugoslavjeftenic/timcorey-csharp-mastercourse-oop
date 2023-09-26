namespace T26_03_02_HomeworkMiniProject
{
    // Recreate the project we did for this lesson but without looking back over what I did.
    // Tweak it slightly as well

    internal class Program
    {
        static void Main()
        {
            var employee = new EmployeeModel
            {
                FirstName = "Enter your first name: ".GetString(),
                LastName = "Enter your last name: ".GetString(),
                WeeklyWorkHours = "Enter your weekly work hours: ".GetInt(1, 60),
                HourlyWage = "Enter your hourly wage: ".GetDecimal()
            };

            employee.PrintEmployeeData();
        }
    }
}