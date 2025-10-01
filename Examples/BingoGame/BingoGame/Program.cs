using System.Dynamic;
using System.Net.NetworkInformation;

namespace BingoGame
{
    internal class Program
    {
        private static bool[,] ballCage = new bool[15, 5];
        private static string message = "fake message";

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
            int column = 0;
            int row = 0;

            //draw random ball
            //check if drawn already
            //yes: draw another
            //no: success! mark as drawn
            do
            {
                //get random column
                column = RandomNumberBetween(0, 4);

                //get random row
                row = RandomNumberBetween(0, 14);

            } while (ballCage[row, column] == true);
            ballCage[row, column] = true;
        }

        //get random number in a range max/min inclusive
        static int RandomNumberBetween(int min, int max)
        {
            Random RandomNumber = new Random();
            return RandomNumber.Next(min, max + 1);
        }

        static void NewGame()
        {
            // this works if default values are what you want
            // create a local array that has same type, dimensions, size
            bool[,] empty = new bool[15, 5];
            // overwrite the tracker array with the default contents of the temp array
            ballCage = empty;

            // this always works but take longer/more steps
            // iterate through the entire array and mark everything false
            //for (int i = ballCage.GetLowerBound(0);  i <= ballCage.GetUpperBound(0); i++)
            //{
            //    for (int j = ballCage.GetLowerBound(1); j <= ballCage.GetUpperBound(1); j++)
            //    {
            //        ballCage[i, j] = false;
            //    }
            //}

        }

        static void Main(string[] args)
        {
            string userInput = "";
            bool userQuit = false;
            int count = 0;

            //friendly start message
            //display w' instructions
            //draw balls, update display, until all balls drawn or user quits
            //new game/start over options clears draws and update display
            //when user quits confirmation then friendly message
            //remove duplicate code, refactor
            //make prettier
            //message accumulator

            //start message here
            do
            {
                userInput = Console.ReadLine();

                if (userInput == "Q" || userInput == "q")
                { 
                    userQuit = true; // set flag for user quitting
                }
                else if (userInput == "C" || userInput == "c")
                {
                    NewGame(); // clear ball tracker
                    count = 0; // reset count
                }
                else
                {
                    if (count >= 75) 
                    {
                        // update message and don't draw if all balls drawn
                        message = "All Balls Have Been Drawn";
                    }
                    else
                    {
                        // draw new ball and increment counter
                        DrawBall();
                        count++;
                    }
                }

                // if user quits confirm
                if (userQuit)
                {
                    Console.Clear();
                    Console.WriteLine("Are you sure you want to quit? y/n");
                    userInput = Console.ReadLine();
                    if (userInput == "n")
                    {
                        //if they changed their mind don't quit
                        userQuit=false;
                    }
                }
                DisplayGrid();

            } while (userQuit == false);



            // say bye
            Console.Clear();
            Console.WriteLine("Have a nice day!");

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

            Console.Clear(); //clear console for fresh display
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
            Console.WriteLine(message);
        }
    }
}
