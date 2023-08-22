using T17_02_01_DifferentNamespece;
using T17_02_01_Namespaces.Models;

namespace T17_02_01_Namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new();

            //T17_02_01_FoundationInfo.Calculations.Add(1, 2);
            Calculations.Add(1, 2);
        }
    }
}