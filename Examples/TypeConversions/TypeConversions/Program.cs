namespace TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int firstNumber;
            int secondNumber;
            int result = 0;

            Console.WriteLine("Please enter a whole number:");
            userInput = Console.ReadLine();
            Console.WriteLine($"You entered {userInput}");
            firstNumber = int.Parse(userInput);

            Console.WriteLine("Please enter a whole number:");
            userInput = Console.ReadLine();
            Console.WriteLine($"You entered {userInput}");
            secondNumber = int.Parse(userInput);

            result = firstNumber + secondNumber;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");

            //pause
            Console.ReadLine();
        }
    }
}
