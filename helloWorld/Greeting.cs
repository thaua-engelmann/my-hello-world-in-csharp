﻿namespace HelloWorld
{
    public class Greeting
    {

        public static void askUserForNameAndMessage()
        {
            Console.WriteLine("Enter your name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Enter a message:");
            string? message = Console.ReadLine();

            if (isUserInfosInvalid(name, message))
            {
                askUserForNameAndMessage();
            } else
            {
                showGreeting(name, message);
            }
        }

        private static bool isUserInfosInvalid(string name, string message) => string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(message);

        private static void showGreeting(string name, string message)
        {
            Console.WriteLine($"Hello, your name is {name} and your message is: \n{message}");
        }
    }
}
