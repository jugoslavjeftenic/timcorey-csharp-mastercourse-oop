namespace T16_02_01_InstantiatedClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<PersonModel> people = new();

            //PersonModel person = new();
            //person.firstName = "Tim";
            //people.Add(person);

            //person = new();
            //person.firstName = "Sue";
            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.firstName); 
            //}

            List<PersonModel> people = new();
            string? firstName;
            string? lastName;

            do
            {
                Console.Write("What is your first name (or type \"exit\" to exit): ");
                if (string.IsNullOrWhiteSpace(firstName = Console.ReadLine()))
                {
                    Console.WriteLine("Incorret input.");
                    continue;
                }

                if (firstName?.ToLower() == "exit")
                {
                    break;
                }

                Console.Write("What is your last name: ");
                if (string.IsNullOrWhiteSpace(lastName = Console.ReadLine()))
                {
                    Console.WriteLine("Incorret input.");
                    continue;
                }

                PersonModel person = new()
                {
                    FirstName = firstName,
                    LastName = lastName,
                };
                people.Add(person);
            } while (true);

            Console.WriteLine("-------------------------------------");
            foreach (PersonModel p in people)
            {
                ProcessPerson.GreetPerson(p);
            }
        }
    }
}