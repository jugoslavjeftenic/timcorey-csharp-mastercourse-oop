namespace T26_01_01_MethodOverloading
{
    public class PersonModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }

        public PersonModel() { }

        public PersonModel(string? firstName, string? lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public PersonModel(string? firstName, string? lastName, string? email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public void GenerateEmail()
        {
            GenerateEmail(false);
        }

        public void GenerateEmail(string domain)
        {
            GenerateEmail(false, domain);
        }

        public void GenerateEmail(bool firstInitialMethod, string domain = "aol.com")
        {
            if (firstInitialMethod)
            {
                Email = $"{FirstName?[..1]}.{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}.{LastName}@{domain}";
            }
        }
    }
}