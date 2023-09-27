namespace T27_01_01_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new();
            stringList.Add("1");

            List<int> intList = new();
            intList.Add(1);


            string result = FizzBuzz("tests");
            Console.WriteLine($"Tests: {result}");

            result = FizzBuzz(123);
            Console.WriteLine($"123: {result}");

            result = FizzBuzz(true);
            Console.WriteLine($"true: {result}");

            result = FizzBuzz(new PersonModel { FirstName = "Tim", LastName = "Corey" });
            Console.WriteLine($"PersonModel: {result}");


            GenericHelper<PersonModel> peopleHelper = new();
            peopleHelper.CheckItemAndAdd(new PersonModel { FirstName = "Tim", HasError = true });

            foreach (var item in peopleHelper.RejectedItems)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} was rejected.");
            }
        }

        private static string FizzBuzz<T>(T t)
        {
            int? tLength = t?.ToString()?.Length;
            string output = "";

            if (tLength % 3 == 0)
            {
                output += "Fizz";
            }

            if (tLength % 5 == 0)
            {
                output += "Buzz";
            }

            return output;
        }
    }

    public class GenericHelper<T> where T : class, IErrorCheck, new()
    {
        public List<T> Items { get; set; } = new List<T>();
        public List<T> RejectedItems { get; set; } = new List<T>();

        public void CheckItemAndAdd(T item)
        {
            //T test = new T();

            if (item.HasError)
            {
                Items?.Add(item);
            }
            else
            {
                RejectedItems.Add(item);
            }
        }
    }

    public interface IErrorCheck
    {
        bool HasError { get; set; }
    }

    public class CarModel : IErrorCheck
    {
        public string? Manufacturer { get; set; }
        public int YearManufactured { get; set; }
        public bool HasError { get; set; }
    }

    public class PersonModel : IErrorCheck
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public bool HasError { get; set; }

        public PersonModel()
        {

        }

        public PersonModel(string lastName)
        {

        }
    }
}