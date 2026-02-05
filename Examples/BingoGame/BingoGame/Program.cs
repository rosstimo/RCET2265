/*
 * TODO:
 * [ ] Track bingo balls drawn in a two dimensional array
 * [ ] Display status of all balls on the console
 * [ ] Clear all drawn balls to start a new game
 * [ ] Let the user quit
 * [ ] Draw a random ball
 * [ ] get a random number to determine ball letter
 * [ ] get a random number to determine ball number
 * [ ] check if ball has already been drawn. no: mark as drawn, yes: draw another
 
*/


using System.Globalization;

namespace BingoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[,] drawnBalls = new bool[5, 15];

            drawnBalls[1,0] = true;

            Display();
            //pause
            Console.Read();
        }


        static void Display()
        {
            int padding = 3;
            //print heading row
            string[] heading = { "B", "I", "N", "G", "O" };
            foreach (string thing in heading)
            {
                Console.Write(thing.PadLeft(padding) + " |");
            }
            Console.WriteLine();

            // print the rest of the rows
            for (int letter = 0; letter < 5; letter++)
            {
                Console.Write(letter.ToString().PadLeft(padding) + " |");
            }
        }
    }
}
