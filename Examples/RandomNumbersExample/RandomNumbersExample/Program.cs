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
                    case 0:
                        Console.WriteLine(choice);
                        break;
                    case 1:
                        Console.WriteLine(choice);
                        break;
                    case 2:
                        Console.WriteLine(choice);
                        break;
                    case 3:
                        Console.WriteLine(choice);
                        break;
                    case 4:
                        Console.WriteLine(choice);
                        break;
                    case 5:
                        Console.WriteLine(choice);
                        break;
                    case 6:
                        Console.WriteLine(choice);
                        break;
                    case 7:
                        Console.WriteLine(choice);
                        break;
                    default:
                        Console.WriteLine($"You rolled a {choice}. So something weird happened.");
                        break;
                }
            }
            Console.WriteLine("All done");
            Console.Read();
        }
    }
}
