
namespace T25_01_02_HomeworkAccesModifiersLibrary
{
    public class Employee
    {
        public int ID { get; set; }
        internal int Age { get; private set; }

        private string? _name;

        public string? Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
