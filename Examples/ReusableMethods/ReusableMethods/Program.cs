using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ReusableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestRandomNumber();
            TestRunningTotal();
            //pause
            Console.Read();
        }
        
        static void TestRunningTotal()
        {
            string userInput = "";

            do
            {
            Console.WriteLine("Enter a number to add to running total" +
                "\nenter c to clear\nenter q to quit");
            userInput = Console.ReadLine();
                try
                {
                    RunningTotal(int.Parse(userInput));
                }
                catch (Exception)
                {
                    switch (userInput)
                    {
                        case "c":
                            RunningTotal(0, true);
                            break;
                        case "C":
                            RunningTotal(0, true);
                            break;
                         default:
                            break;
                    }
                }
                Console.WriteLine($"You entered {userInput}");
                Console.WriteLine($"The current total is: {RunningTotal()}");
            } while (userInput != "Q" && userInput != "q");

            Console.WriteLine("Have a nice day!");

        }
        // [x] keep track of a running total
        // [x] optionally add the integer passed in as an argument to the total
        // [x] return the running total
        // [x] optionally clear the running total
        static private int _runningTotal = 0;
        static int RunningTotal(int currentValue = 0, bool clear = false)
        {
            _runningTotal += currentValue;
            if (clear)
            {
                _runningTotal = 0;
            }
            return _runningTotal;
        }

        // test and visualize random number method
        static void TestRandomNumber()
        {
            int[] counts = new int[12];
            int max = 11, min = 0, currentNumber = 0, padding = 5;
            
            for (int i = 0; i < 1000; i++)
            {
                //Console.Write(RandomNumberBetween(10, 5).ToString().PadLeft(2));
                currentNumber = RandomNumberBetween(max,min);
                counts[currentNumber] += 1;

            }

            //make column headers
            for (int i = 0;i < counts.Length;i++)
            {
                Console.Write(i.ToString().PadLeft(padding) + "|");
            }
            Console.WriteLine();
            //display counts in nice columns
            foreach (int count in counts)
            {
                Console.Write(count.ToString().PadLeft(padding) + "|");
            }
        }
        /// <summary>
        /// Returns a random integer with in min to max range inclusive.
        /// </summary>
        /// <param name="max"></param>
        /// <param name="min"></param>
        /// <returns>Integer</returns>
        static int RandomNumberBetween(int max, int min)
        {
            Random rand = new Random();
            max += 1; //make max inclusive
            int range = max - min; //get the actual number of random numbers possible
            int randomNumber = rand.Next(range);
            randomNumber += min; //shift value back up so it falls between min and max
            return randomNumber;
        }
    }
}
