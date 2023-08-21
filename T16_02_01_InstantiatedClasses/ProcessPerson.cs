
namespace T16_02_01_InstantiatedClasses
{
    public static class ProcessPerson
    {
        public static void GreetPerson(PersonModel person)
        {
            Console.WriteLine($"Hello {person.FirstName} {person.LastName}.");
            person.HaBeenGreeted = true;
        }
    }
}
