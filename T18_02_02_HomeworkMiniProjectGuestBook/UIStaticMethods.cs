
using System.Text.RegularExpressions;
using T18_02_02_HomeworkMiniProjectGuestBookLibrary.Models;

namespace T18_02_02_HomeworkMiniProjectGuestBook
{
    public static class UIStaticMethods
    {
        public static void GuestsInput(List<GuestModel> guests)
        {
            do
            {
                GuestModel guest = new();

                Console.WriteLine("Welcome to Guest Book application.");
                Console.WriteLine("(Type \"exit\" at any line to exit application)");
                Console.WriteLine();

                do
                {
                    Console.Write("Please type your first name: ");

                    if (string.IsNullOrWhiteSpace(guest.FirstName = Console.ReadLine()))
                    {
                        Console.WriteLine("ERROR. Please type your first name or \"exit\" to exit application.");
                        continue;
                    }

                    break;
                } while (true);

                if (guest.FirstName.ToLower() == "exit")
                {
                    return;
                }

                guest.FirstName = Regex.Replace(guest.FirstName, "^[a-z]", c => c.Value.ToUpper());

                do
                {
                    Console.Write("Please type your last name: ");

                    if (string.IsNullOrWhiteSpace(guest.LastName = Console.ReadLine()))
                    {
                        Console.WriteLine("ERROR. Please type your last name or \"exit\" to exit application.");
                        continue;
                    }

                    break;
                } while (true);

                if (guest.LastName.ToLower() == "exit")
                {
                    return;
                }

                guest.LastName = Regex.Replace(guest.LastName, "^[a-z]", c => c.Value.ToUpper());

                Console.Write("Please type your message to host: ");
                guest.MessageToHost = Console.ReadLine() ?? "n/a";

                if (guest.MessageToHost.ToLower() == "exit")
                {
                    return;
                }

                guests.Add(guest);
                Console.Clear();
            } while (true);
        }

        public static void GuestsOutput(List<GuestModel> guests)
        {
            Console.Clear();
            Console.WriteLine("Guests list:");
            Console.WriteLine("-------------------------------------------------------------------------");

            foreach (var guest in guests)
            {
                Console.WriteLine(guest.GuestToString());
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for using Guest Book application.");
            Console.WriteLine("Have a nice day.");
        }
    }
}
