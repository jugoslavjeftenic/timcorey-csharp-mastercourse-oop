
namespace T25_01_01_AccesModifiersLibrary
{
    public class Manager : Employe
    {
        public string? GetAllNames()
        {
            return $"{FirstName}, {LastName}, {formerLastName}";
        }
    }
}
