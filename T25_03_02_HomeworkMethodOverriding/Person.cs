namespace T25_03_02_HomeworkMethodOverriding
{
    public class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}