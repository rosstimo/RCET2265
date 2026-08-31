namespace ConsoleExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            //Console.Beep();
            //Console.Beep(1000, 1000);

            //send a message to  user
            Console.WriteLine("What is your favorite vegetable?");
            //get user input
            userInput = Console.ReadLine();
            Console.WriteLine("eww " + userInput + " is so gross!");

            //pause before close
            Console.ReadLine();
        }
    }
}
