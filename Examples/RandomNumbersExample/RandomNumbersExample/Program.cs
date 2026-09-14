namespace RandomNumbersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rnd.Next());
            }

            Console.Read();
        }
    }
}
