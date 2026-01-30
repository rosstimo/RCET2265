
/*
 TODO:
[ ] user can quit at any time skips remaining prompts
[ ] get a valid number - alway runs once
[ ] get a valid number - only runs if user didn't quit
[ ] get a choice - only runs if user didn't quit
[ ] repeat the whole thing if user didn't quit
 */
using System.Diagnostics;

namespace ControlFlowSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            bool userQuit = false, validResponse = false;
            string userInput = "";

            //first number
            do
            {
                Console.WriteLine("please enter a number");
                userInput = Console.ReadLine();
                try
                {
                    Console.WriteLine($"you entered {int.Parse(userInput)}");
                    validResponse = true;
                }
                catch (Exception)
                {
                    if (userInput == "Q" || userInput == "q")
                    {
                        userQuit = true;
                    }
                    else
                    {
                        Console.WriteLine($"{userInput} is not a number");
                    }
                   
                }
            } while (validResponse == false && userQuit == false);
            Console.WriteLine("end first loop");
            validResponse = false; //reset flag
            //second number
            while (validResponse == false && userQuit == false)
            {
                Console.WriteLine("please enter a number");
                userInput = Console.ReadLine();
                try
                {
                    Console.WriteLine($"you entered {int.Parse(userInput)}");
                    validResponse = true;
                }
                catch (Exception)
                {
                    if (userInput == "Q" || userInput == "q")
                    {
                        userQuit = true;
                    }
                    else
                    {
                        Console.WriteLine($"{userInput} is not a number");
                    }

                }
            }
            Console.WriteLine("end second loop");
            // operation chioce
            while (validResponse == false && userQuit == false)
            {
                validResponse = true; //reset flag
                Console.WriteLine("Please make a choice:\n 1. Option 1\n2. Option 2\n3. Option 3\n");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("You have chosen wiseley");
                        break;
                    case "2":
                        Console.WriteLine("You have chosen wiseley");
                        break;
                    case "3":
                        Console.WriteLine("You have chosen wiseley");
                        break;
                    case "q":
                        userQuit = true;
                        break;
                    case "Q":
                        userQuit = true;
                        break;
                    default:
                        Console.WriteLine("You have chosen falsey");
                        validResponse = false;
                        break;
                }
            }
            Console.WriteLine("end third loop");


            // pause
            Console.Read();
        }
    }
}
