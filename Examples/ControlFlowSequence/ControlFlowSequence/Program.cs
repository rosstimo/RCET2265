
/*
 TODO:
[x] user can quit at any time skips remaining prompts
[x] get a valid number - alway runs once
[x] get a valid number - only runs if user didn't quit
[x] get a choice - only runs if user didn't quit
[x] repeat the whole thing if user didn't quit
 */
using System.Diagnostics;
using System.Xml;

namespace ControlFlowSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            bool userQuit = false, validResponse = false;
            string userInput = "";
            do
            {
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
                validResponse = false; //reset flag
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


            } while (userQuit == false);
            Console.WriteLine("Have a nice day!");
                // pause
                Console.Read();
        } 
    }
}
