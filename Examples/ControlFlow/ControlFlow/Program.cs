namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int score = 101;
            //if (score >= 100)
            //{
            //    Console.WriteLine("Ace!");
            //}

            //if (score >= 90)
            //{
            //    Console.WriteLine("Excellent! You got an A.");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("Good job! You passed.");
            //}
            //else
            //{
            //    Console.WriteLine("Keep trying! Practice makes perfect.");
            //}

            Console.WriteLine("Please enter a number for the day of the week 1-7");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("It's Monday. Time to start the week!");
                    break;
                case "2":
                    Console.WriteLine("It's Tuesday. Keep going!");
                    break;
                case "3":
                    Console.WriteLine("It's Wednesday. Halfway there!");
                    break;
                default:
                    Console.WriteLine("It's another day. Make it count!");
                    break;
            }



            //pause
            Console.Read();
        }
    }
}
