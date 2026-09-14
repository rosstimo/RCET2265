namespace RandomNumbersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(rnd.Next(10));
            }

            Console.Read();
        }
    }
}
