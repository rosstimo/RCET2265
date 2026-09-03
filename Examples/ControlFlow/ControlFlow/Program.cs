namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 7;
            string userInput = "";
            string userPrompt = "Please Choose One of:\n" +
                                "1. maybe\n" + 
                                "2. could be\n" +
                                "3. probably this one\n";

            //if (firstNumber > 1)
            //{
            //    Console.WriteLine("Bigger than 1!");
            //}
            //else
            //{
            //    Console.WriteLine("Not bigger than 1!");
            //}

            //if (firstNumber > 1)
            //{
            //    Console.WriteLine("Bigger than 1!");
            //}
            //else if (firstNumber < 1)
            //{
            //    Console.WriteLine("Not bigger than 1!");
            //}
            //else
            //{
            //    Console.WriteLine("something else happened");
            //}

            Console.WriteLine(userPrompt);
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("you have chosen poorly");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("you have chosen poorly");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("you have chosen wisely");
            }
            else
            {
                Console.WriteLine($"{userInput}!?... that is way off...");
            }



            //pause
            Console.ReadLine();
        }
    }
}
