namespace BingoGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display(); // test display

            Console.Read();
        }

        static void Display()
        {
            string currentLocation = "XX";
            string[] header = { "B", "I", "N", "G", "O" };

            foreach (string letter in header)
            {
                Console.Write(letter);
            }

                ,
            //write 50 "-" to console
            Console.WriteLine(new string('-', 25));



            // Display user interface

            for (int row = 0; row < 15; row++)
            {
                for (int column = 0; column < 5; column++)
                {
                    Console.Write(currentLocation.PadLeft(3) + " |");
                }
                Console.WriteLine();
            }
        }
    }
}
