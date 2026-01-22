namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score = 69;
            if (score >= 90)
            {
                Console.WriteLine("Excellent! You got an A.");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Good job! You passed.");
            }
            else
            {
                Console.WriteLine("Keep trying! Practice makes perfect.");
            }
                //pause
                Console.Read();
        }
    }
}
