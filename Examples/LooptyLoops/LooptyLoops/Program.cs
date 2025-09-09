using Microsoft.VisualBasic;

namespace LooptyLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string userInput = "";


            ////for loop. loops a number of times
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            ////nested for loop

            //for (int i = 0; i < 10; i++)
            //{
            //    for(int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // Evaluates before loop
            // skips loop content if evaluation is true
            // may never run
            while (userInput != "Q")
            {
                Console.WriteLine("In the while loop");
                Console.WriteLine("Press Q to quit");
                userInput = Console.ReadLine();
            }

            //do loop
            //always runs at least once
            //evaluates after loop content
            do
            {
                Console.WriteLine("In the do loop");
                Console.WriteLine("Press Q to quit");
                userInput = Console.ReadLine();
            } while (userInput != "Q");





            //pause
            //Console.Read();
        }
    }
}
