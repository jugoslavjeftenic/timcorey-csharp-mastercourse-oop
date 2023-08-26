using T18_02_02_HomeworkMiniProjectGuestBookLibrary.Models;

namespace T18_02_02_HomeworkMiniProjectGuestBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Recreate the guest book project without looking back.
            // Just take the concept and create the application.

            List<GuestModel> guests = new();

            UIStaticMethods.GuestsInput(guests);
            UIStaticMethods.GuestsOutput(guests);
        }
    }
}