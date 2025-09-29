using System.Net.NetworkInformation;

namespace BingoGame
{
    internal class Program
    {
        private static bool[,] ballCage = new bool[15, 5];

        //get the drawn/not drawn status of a specific ball
        static bool BallIsDrawn(int row, int column)
        {
            bool status = false;

            try
            {
                status = ballCage[row, column];
            }
            catch (Exception)
            {
                //reading outside the boundary of the array will crash
                //maybe log exception here
            }
            return status;
        }

        static void DrawBall()
        {
            //get random column
            //get random row
            //check if drawn already
            //yes: draw another
            //no: success! mark as drawn

            //make on ball drawn for testing
            ballCage[5,2] = true;
            ballCage[0,0] = true;
            ballCage[14,4] = true;
        }

        static void Main(string[] args)
        {
            DrawBall();
            DisplayGrid(); // test display

            Console.Read();
        }

        static void DisplayGrid()
        {
            string currentLocation = "  "; // show spaces for not drawn, number for drawn
            string[] header = { "B", "I", "N", "G", "O" }; //column header content
            string vDivider = " |";//column separator
            int padding = 3;//right justify numbers
            int totalWidth = 5 * (padding + vDivider.Length); //calculate total width
            string hDivider = new string('-', totalWidth); //dynamic length horizontal divider

            //print header row
            foreach (string letter in header)
            {
                Console.Write(letter.PadLeft(padding) + vDivider);
            }
            Console.WriteLine();

            //horizontal divider
            Console.WriteLine(hDivider);

            // Display user interface
            for (int row = 0; row < 15; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    //need to check each possible ball and display those already drawn
                    if (BallIsDrawn(row, column))
                    {
                        currentLocation = ((column * 15) + row +1).ToString();
                    }
                    else
                    {
                        currentLocation = "  ";
                    }
                    Console.Write(currentLocation.PadLeft(padding) + vDivider);
                }
                Console.WriteLine();
            }
        }
    }
}
