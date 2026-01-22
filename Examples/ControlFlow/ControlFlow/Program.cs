namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int score = 59;
            if (score >= 60)
            {
                Console.WriteLine("Pass. You did well enough.");
            }
            else
            {
                Console.WriteLine("Fail. Let's review and try again.");
            }

            //pause
            Console.Read();
        }
    }
}
