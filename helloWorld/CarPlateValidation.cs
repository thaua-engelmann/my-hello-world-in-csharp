namespace HelloWorld
{
    public class CarPlateValidation
    {

        public static void checkPlateIsValid()
        {
            Console.WriteLine("Enter a plate: ");
            string? plate = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(plate))
            {

                List<char> letters = new List<char>();
                List<int> numbers = new List<int>();

                foreach (char c in plate)
                {

                    if (IsCharDigit(c))
                    {
                        numbers.Add(c - '0');
                    } else
                    {
                        letters.Add(c);
                    }
                }

                Console.WriteLine($"letters: {string.Join(", ", letters)}");
                Console.WriteLine($"numbers: {string.Join(", ", numbers)}");
            }
        }

        private static bool IsCharDigit(char value)
        {
            return char.IsDigit(value);
        }

    }
}
