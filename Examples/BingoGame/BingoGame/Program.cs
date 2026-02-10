/*
 * TODO:
 * [x] Track bingo balls drawn in a two dimensional array
 * [x] Display status of all balls on the console
 * [ ] Clear all drawn balls to start a new game
 * [x] Let the user quit
 * [x] Draw a random ball
 * [x] get a random number to determine ball letter
 * [x] get a random number to determine ball number
 * [x] check if ball has already been drawn. no: mark as drawn, yes: draw another
 
*/


using System.Data;
using System.Globalization;

namespace BingoGame
{
    internal class Program
    {
        //make this global so it can be accessed by all methods
        static bool[,] drawnBalls = new bool[5, 15];
        static void Main(string[] args)
        {
            string userInput = "";
            int ballCount = 0;
            do
            {
                Console.Clear();
                if (ballCount < 75)
                {
                    DrawBall();
                    ballCount++;
                }
                Console.WriteLine(ballCount);
                Display();
                userInput = Console.ReadLine(); //fixed double draw
                if (userInput == "c" || userInput == "C")
                {
                    ClearDrawnBalls();
                    ballCount = 0;
                }
            } while (userInput != "Q" && userInput != "q");
            Console.Clear();
            Console.WriteLine("Have a nice day!");
            //pause
            Console.Read();
        }
        static void Display()
        {
            int padding = 4;
            int prettyNumber = 0;
            string placeHolder = "";
            string columnSeperator = " |";
            string currentRow = "";
            //print heading row
            string[] heading = { "B", "I", "N", "G", "O" };
            foreach (string thing in heading)
            {
                Console.Write(thing.PadLeft(padding) + columnSeperator);
            }
            Console.WriteLine();

            // print the rest of the rows
            for (int number = 1; number <= 15; number++)
            {
                //assemble the row
                for (int letter = 0; letter < 5; letter++)
                {
                    if (drawnBalls[letter, number - 1])
                    {
                        prettyNumber = number + (letter * 15); //offset the number by the letter column
                        currentRow += prettyNumber.ToString().PadLeft(padding) + columnSeperator;
                    }
                    else
                    {
                        currentRow += placeHolder.PadLeft(padding) + columnSeperator;
                    }
                }
                Console.WriteLine(currentRow);
                currentRow = ""; //reset 
            }
        }
        static void DrawBall()
        {
            int letter = 0 , number = 0;
            do
            {
                letter = RandomNumberZeroTo(4);
                number = RandomNumberZeroTo(14);
            } while (drawnBalls[letter, number]);

            drawnBalls[letter, number] = true;

        }
        static void ClearDrawnBalls()
        {
           for( int i = 0; i <= 4; i++)
           {
                for(int j = 0; j <= 14; j++)
                {
                    drawnBalls[i, j] = false;
                }
           }
        }
/// <summary>
/// Get a random integer from 0 to max inclusive.
/// </summary>
/// <param name="max"></param>
/// <returns>integer</returns>
        static private int RandomNumberZeroTo(int max)
        {
            int range = max + 1; //make max inclusive
            Random rand = new Random();
            return rand.Next(range);
        }

    }
}
