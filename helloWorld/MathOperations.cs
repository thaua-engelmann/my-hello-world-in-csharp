namespace HelloWorld
{
    public class MathOperations
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        public MathOperations(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public void Add() { 
            double sum = Num1 + Num2;
            Console.WriteLine($"The sum of {Num1} and {Num2} is equal to {sum:F1}");
        }

        public void Subtract()
        {
            double difference = Num1 - Num2;
            Console.WriteLine($"The difference between {Num1} and {Num2} is equal to {difference:F1}");
        }

        public void Multiply() { 
            double result = Num1 * Num2;
            Console.WriteLine($"The product of {Num1} and {Num2} is equal to {result:F1}");
        }

        public void Divide() { 
            double result = Num1 / Num2;
            Console.WriteLine($"The quotient of {Num1} and {Num2} is equal to {result:F1}");
        }

        public void Mean()
        {
            double result = (Num1 + Num2) / 2;
            Console.WriteLine($"The mean of {Num1} and {Num2} is equal to {result:F1}");
        }
    }
}
