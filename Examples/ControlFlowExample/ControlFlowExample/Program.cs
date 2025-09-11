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
            firstNumber = int.Parse(userInput);


            //pause
            Console.Read();
        }
    }
}
