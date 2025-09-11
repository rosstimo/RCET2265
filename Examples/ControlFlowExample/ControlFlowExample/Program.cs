namespace ControlFlowExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            string userInput;


            //ask for whole number
            //user must enter a valid whole number or quit

            Console.WriteLine("Please Enter a Whole Number");
            userInput = Console.ReadLine();
            Console.WriteLine($"You Entered: {userInput}");

            try
            {
                firstNumber = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine($"{userInput} is not a number!");
            }


            //pause
            Console.Read();
        }
    }
}
