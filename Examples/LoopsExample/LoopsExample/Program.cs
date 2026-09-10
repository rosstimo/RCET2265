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

            //string userInput = "Q";
            //while (userInput != "Q")
            //{
            //    Console.WriteLine("Enter Q to quit:");
            //    userInput = Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine($"You entered {userInput}");
            //}

            //do
            //{
            //    Console.WriteLine("the do loop always runs at least once");
            //    Console.WriteLine("Enter Q to quit:");
            //    userInput = Console.ReadLine();
            //    Console.Clear();
            //    Console.WriteLine($"You entered {userInput}");
            //} while (userInput != "Q");


            //string userInput = "";
            //int firstNumber = 0;
            //bool isValid = false;
            //do
            //{
            //    Console.WriteLine("Please enter a whole number:");
            //    Console.WriteLine("Enter Q to quit:");
            //    userInput = Console.ReadLine();
            //    Console.WriteLine($"You entered {userInput}");
            //    Console.Clear();
            //    try
            //    {
            //        firstNumber = int.Parse(userInput);
            //        isValid = true;
            //        Console.WriteLine("Success!");
            //    }
            //    catch (Exception)
            //    {   
            //        isValid = false;
            //        Console.WriteLine("FAIL!!!");
            //    }
            //} while (!isValid);
            // Console.Clear();

            int result = 0;
            string output = "";
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    result = i + j;
                    output = $"{result} |";
                    output = output.PadLeft(5);
                    Console.Write(output);
                }
                Console.WriteLine();
            }



            Console.WriteLine("Have a nice day!");
            //pause
            Console.ReadLine();
        }
    }
}
