namespace HelloWorld
{
    public class CarPlateValidation
    {

        public static void CheckPlateIsValid()
        {
            Console.WriteLine("Enter a plate: ");
            string? plate = Console.ReadLine();

            // Plate must not be longer than 7 caracters.
            // First 3 caracters of the plate must be a char.
            // The remaining 4 caracters must be an int.

            if (!string.IsNullOrWhiteSpace(plate) && plate.Count() == 7)
            {

                List<char> letters = new List<char>();
                List<int> numbers = new List<int>();

                for (int i = 0; i < plate.Length; i++)
                {

                    char singleChar = plate[i];
                    var lettersRange = 3;

                    if (i < lettersRange)
                    {

                        if (!char.IsLetter(singleChar))
                        {
                            Console.WriteLine("First 3 caracters must be a letter.");
                            return;
                        }

                        letters.Add(singleChar);
                    } else
                    {

                        if (!char.IsDigit(singleChar))
                        {
                            Console.WriteLine("Last 4 caracters must be an integer.");
                            return;
                        }

                        numbers.Add(singleChar - '0');
                    }
                }

                Console.WriteLine($"Plate {plate} is valid.");

            } else
            {
                Console.WriteLine("Plate must have exactly 7 caracters.");
            }
        }
    }
}
