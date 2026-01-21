// Tim Rossiter
// Spring 2026
// RCET2265
// Console Practice Program
// github url

namespace ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World!");
            //Console.Beep();
            //Console.Beep(100, 1000);

            string userInput = "hello"; 

            Console.WriteLine("Please Type Some Text");
            userInput = Console.ReadLine();

            Console.WriteLine($"You entered: \"{userInput}\""); // formatted string
            Console.WriteLine("You entered: " + "\"" + userInput + "\""); //concatinated string

            Console.Read();
        }
    }
}
