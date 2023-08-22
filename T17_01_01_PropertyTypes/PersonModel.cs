
namespace T17_01_01_PropertyTypes
{
    public class PersonModel
    {
        public string? FirstName { private get; set; }
        public string? LastName { get; private set; }

        private string? _password;

        public string Password
        {
            set { _password = value; }
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        //public int? Age { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age needs to be in a range 0-125.");
                }
            }
        }

        //public string SSN { get; set; } // Social Security Number 123-45-6789
        private string? _ssn;

        public string SSN
        {
            get
            {
                string output = $"***-**-{_ssn?.Substring(_ssn.Length - 4)}";
                return output;
            }
            set { _ssn = value; }
        }

        public PersonModel()
        {

        }

        public PersonModel(string lastName)
        {
            LastName = lastName;
        }
    }
}
