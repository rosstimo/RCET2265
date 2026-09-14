namespace RandomNumbersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(rnd.Next(3,7));
            }

            Console.Read();
        }
    }
}
