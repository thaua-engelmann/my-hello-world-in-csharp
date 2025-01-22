namespace HelloWorld
{
    public class CountCaracters
    {

        public static void AskForWord()
        {
            Console.WriteLine("Enter a word:");
            string? word = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(word))
            {
                // Check if user has entered a phrase.
                // We can check it splitting the string word by a "space" caracter,
                // indicating two or more words. 
                string[] wordSplitted = word.Split(' ');
                
                if (wordSplitted.Length > 1)
                {
                    Console.WriteLine("You did not enter a single word.");
                    return;
                }

                int count = CountCaractersFromWord(word);
                Console.WriteLine($"The word {word} contains {count} caracters.");
            }
        }

        private static int CountCaractersFromWord(string word)
        {
            return word.Count();
        }

    }
}
