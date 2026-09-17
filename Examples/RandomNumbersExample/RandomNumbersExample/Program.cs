namespace RandomNumbersExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new();
            int choice = 0;
            int[] rolls = new int[8];

            for (int i = 0; i < 1000; i++)
            {
                choice = rnd.Next(1,7);

                switch (choice) 
                {
                    //case 0:
                    //    rolls[0]++;
                    //    break;
                    case 1:
                        rolls[1]++;
                        break;
                    case 2:
                        rolls[2]++;
                        break;
                    case 3:
                        rolls[3]++;
                        break;
                    case 4:
                        rolls[4]++;
                        break;
                    case 5:
                        rolls[5]++;
                        break;
                    case 6:
                        rolls[6]++;
                        break;
                    //case 7:
                    //    rolls[7]++;
                    //    break;
                    default:
                        Console.WriteLine($"You rolled a {choice}. So something weird happened.");
                        break;
                }
            }

            foreach (int rollcount in rolls)
            {
                Console.WriteLine(rollcount);
            }
            Console.WriteLine("All done");
            Console.Read();
        }
    }
}
