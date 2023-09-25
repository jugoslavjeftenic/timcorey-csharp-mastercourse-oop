namespace T26_01_02_HomeworkMethodOverloading
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? JobPosition { get; set; }

        public EmployeeModel()
        {
        }

        public EmployeeModel(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public EmployeeModel(string? firstName, string? lastName, string? jobPosition) : this(firstName, lastName)
        {
            JobPosition = jobPosition;
        }
    }
}