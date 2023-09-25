namespace T26_02_02_HomeworkExtensionMethods
{
    public static class PersonExtensions
    {
        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 18;
            return person;
        }

        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}, age {person.Age}.");
        }
    }
}