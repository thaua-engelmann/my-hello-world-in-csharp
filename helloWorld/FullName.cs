namespace HelloWorld
{
    public class FullName
    {

        public static void AskUserNameAndLastName()
        {
            Console.WriteLine("Enter your name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string? lastName = Console.ReadLine();

            string fullName = $"{name} {lastName}";
            Console.WriteLine($"Full name: {fullName}");
        }

    }
}
