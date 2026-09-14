namespace RandomNumbersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int choice = 0;

            for (int i = 0; i < 10000; i++)
            {
                choice = rnd.Next(10);

                switch (choice)
                {
                    case 10:
                        Console.WriteLine($"{choice} is 10");
                        break;
                    case < 5:
                        Console.WriteLine($"{choice} is less than 5");
                        break;
                    case 5:
                        Console.WriteLine($"{choice} is 5");
                        break;
                    case > 5:
                        Console.WriteLine($"{choice} is greater than 5");
                        break;
                    default:
                        Console.WriteLine($"Choice is {choice}. So something weird happened.");
                        break;
                }
            }
            Console.WriteLine("All done");
            Console.Read();
        }
    }
}
