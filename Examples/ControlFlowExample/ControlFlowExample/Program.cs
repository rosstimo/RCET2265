namespace ControlFlowExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            string userInput;
            bool keepGoing = false;


            //ask for whole number
            //user must enter a valid whole number or quit
            do
            {
                Console.WriteLine("Please Enter a Whole Number");
                userInput = Console.ReadLine();
                Console.WriteLine($"You Entered: {userInput}");

                try
                {
                    //code that may raise an exception (crash)
                    firstNumber = int.Parse(userInput);
                    //only makes it here if the above line doesn't crash
                    keepGoing = true;
                }
                catch (Exception)
                {
                    //This code runs if somthing in the Try crashes the program
                    if (userInput == "Q")
                    {
                        //if the user quits nice message and let them leave
                        Console.WriteLine($"Have a nice day!");
                        keepGoing = true;
                    }
                    else
                    {
                        //if the user gives bad input trap them here forever
                        Console.WriteLine($"{userInput} is not a number!");
                    }
                }
            } while (keepGoing == false);

            //pause
            Console.Read();
        }
    }
}
