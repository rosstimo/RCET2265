namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int result = 0;
            bool isValid = false;
            string message = "";

            do
            {
                Console.WriteLine("Please Enter a Number: ");
                Console.WriteLine("Enter \"Q\" to quit.");
                userInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You entered {userInput}");

                try
                {
                    result = int.Parse(userInput);
                    message = $"Good job! {result} is a number!";
                    isValid = true;
                }
                catch (Exception ex)
                {
                    if (userInput == "Q" || userInput == "q")
                    {
                        message = "Have a nice day!";
                        isValid = true;
                    }
                    else
                    {
                        message = $"{userInput} is not a number";
                    }
                }

                Console.WriteLine(message);

            }
            while (!isValid);



            //pause
            Console.Read();
        }
    }
}
