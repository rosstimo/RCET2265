namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int result = 0;
            
            Console.WriteLine("Please Enter a Number: ");
            userInput = Console.ReadLine();
            Console.WriteLine($"You entered {userInput}");
            try
            {
                result = int.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong: " + ex.StackTrace);
            }
            //pause
            Console.Read();
        }
    }
}
