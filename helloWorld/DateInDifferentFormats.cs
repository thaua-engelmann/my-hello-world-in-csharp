using System.Globalization;

namespace HelloWorld
{
    public class DateInDifferentFormats
    {

        // In this logic, I'll be validating two formats: dd/mm/yyyy and yyyy-mm-dd.
        public static void AskUserSomeDate()
        {
            Console.WriteLine("Enter a date:");
            string? date = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(date) || !CheckDateFormatIsValid(date, out DateTime parsedDate))
            {
                Console.WriteLine($"Date \"{date}\" is not valid.");
                return;
            }

            ShowDateInDifferentFormats(parsedDate);

        }

        private static bool CheckDateFormatIsValid(string date, out DateTime parsedDate)
        {
            string[] allowedFormats = { "dd/MM/yyyy", "yyyy/MM/dd", "yyyy-MM-dd" };
            return DateTime.TryParseExact(date, allowedFormats, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);
        }

        private static void ShowDateInDifferentFormats(DateTime date)
        {
            Console.WriteLine("\nDate in different formats:");
            Console.WriteLine($"1. Full format: {date.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"2. Date only: {date:dd/MM/yyyy}");
            Console.WriteLine($"4. Date with month name: {date.ToString("dd 'de' MMMM 'de' yyyy", new CultureInfo("pt-BR"))}");
        }

    }
}
