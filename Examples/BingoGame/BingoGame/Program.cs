namespace BingoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayGrid(); // test display

            Console.Read();
        }

        static void DisplayGrid()
        {
            string currentLocation = "XX"; // place holder for ball numbers
            string[] header = { "B", "I", "N", "G", "O" }; //column header content
            string vDivider = " |";//column seperator
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
                    Console.Write(currentLocation.PadLeft(padding) + vDivider);
                }
                Console.WriteLine();
            }
        }
    }
}
