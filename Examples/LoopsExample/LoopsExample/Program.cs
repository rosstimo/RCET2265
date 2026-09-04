namespace LoopsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("hello");
            //}

            //int someNumber = 0;
            //while (someNumber <= 7)
            //{
            //    Console.WriteLine("in the while loop");
            //    someNumber++;
            //}

            string userInput = "";
            while (userInput != "Q")
            {
                Console.WriteLine("Enter Q to quit:");
                userInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You entered {userInput}");
            }
            Console.Clear();
            Console.WriteLine("Have a nice day!");
            //pause
            Console.ReadLine();
        }
    }
}
