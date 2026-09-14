namespace RandomNumbersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();

                Console.WriteLine(rnd.Next(3,7));
                Console.WriteLine(rnd.Next(3,7));
                Console.WriteLine(rnd.Next(3,7));
                Console.WriteLine(rnd.Next(3,7));
            Console.WriteLine(rnd.NextSingle());
            Console.WriteLine(rnd.NextDouble());
                

            Console.Read();
        }
    }
}
