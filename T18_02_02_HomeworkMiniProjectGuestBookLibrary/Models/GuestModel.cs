
namespace T18_02_02_HomeworkMiniProjectGuestBookLibrary.Models
{
    public class GuestModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MessageToHost { get; set; }

        public string GuestToString()
        {
            return $"{FirstName} {LastName}, message: {MessageToHost}";
        }
    }
}
