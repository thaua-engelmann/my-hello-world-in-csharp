namespace HelloWorld
{
    class Program
    {

        static void Main()
        {
            // The following lines of code are exercices from Rocketseat's C# Course.
            // Each of them are part of the C#'s Fundamentals Module
            // They'll help you to practice your first steps in the language. 

            // First - Personalized Greeting Exercice. It takes up two inputs from user, a name and a message.
            // We'll be concatenating both into one string, but also making it recursive once validation goes wrong. 
            //Greeting.askUserForNameAndMessage();

            // Second - Ask user first name and last name and show it concatenated into a string. Let's try to keep this one a bit simpler, without any further validation or recursivity.
            //FullName.AskUserNameAndLastName();

            // Third - In this one, let's get to play a bit with math. I'll be doing some basic operations with two double numbers.
            //MathOperations myMath = new(10.6, 2.2);
            //myMath.Add();
            //myMath.Subtract();
            //myMath.Multiply();
            //myMath.Divide();
            //myMath.Mean();

            CountCaracters.AskForWord();
        }
    };

}