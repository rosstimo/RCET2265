namespace WorkingWithStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string theString = "Hello, World!";

            theString = theString.ToLower();
            Console.WriteLine(theString);

            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                Console.Write((i + j).ToString().PadLeft(3) + " |");

                }
                Console.WriteLine();
            }

            Console.WriteLine($"The string '{theString}' is {theString.Length} characters long.");



            //pause
            Console.Read();
        }
    }
}
