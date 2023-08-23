// Capture the information about each guest
// (assumption is at least one guest and unknown maximum)
// Info to capture: First name, last name, message to the host
// Once done, loop through each guest and print their info

using T18_02_01_MiniProjectGuestBookLibrary.Models;

namespace T18_02_01_MiniProjectGuestBook
{
    public class Program
    {
        private static List<GuestModel> guests = new();

        static void Main(string[] args)
        {
            GetGuestInformation();
            PrintGuestInformation();
        }

        private static void GetGuestInformation()
        {
            string? moreGuestsComing;

            do
            {
                GuestModel guest = new();

                guest.FirstName = GetInfoFromConsole("What is your first name: ");
                guest.LastName = GetInfoFromConsole("What is your last name: ");
                guest.MessageToHost = GetInfoFromConsole("What message would you like to tell your host: ");
                moreGuestsComing = GetInfoFromConsole("Are more guest coming (yes/no): ");

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing?.ToLower() == "yes");
        }

        private static void PrintGuestInformation()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }
        }

        private static string? GetInfoFromConsole(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
    }
}