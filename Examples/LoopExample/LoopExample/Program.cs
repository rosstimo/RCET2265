namespace LoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Count: {i}");
            }

            for (int i = 5; i >= -5; i--)
            {
                Console.WriteLine($"Count: {i}");
            }

            //pause
            Console.Read();
        }
    }
}
