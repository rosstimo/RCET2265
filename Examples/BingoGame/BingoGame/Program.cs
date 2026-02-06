/*
 * TODO:
 * [ ] Track bingo balls drawn in a two dimensional array
 * [x] Display status of all balls on the console
 * [ ] Clear all drawn balls to start a new game
 * [ ] Let the user quit
 * [ ] Draw a random ball
 * [ ] get a random number to determine ball letter
 * [ ] get a random number to determine ball number
 * [ ] check if ball has already been drawn. no: mark as drawn, yes: draw another
 
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

            drawnBalls[1,0] = true;
            drawnBalls[4,5] = true;
            drawnBalls[3,6] = true;
            drawnBalls[2,13] = true;
            drawnBalls[0,11] = true;

            // Display();

            DrawBall();
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
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(RandomNumberZeroTo(14));
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
