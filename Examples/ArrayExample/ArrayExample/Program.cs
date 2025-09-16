namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single dimensional arrays 
            int[] fruit = new int[5];
            int[] rolls = new int[6];

            string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

            //multi-dimensional arrays
            int[,] grid = new int[3, 5];
            bool[,] deck = { { false , false}, { false, true } , { true, true} };



            //assign values to each element
            fruit[0] = 3;
            fruit[1] = 4;
            fruit[2] = 7;
            fruit[3] = 8;
            fruit[4] = 133;

            Console.WriteLine(fruit[3]);

            //access elements in an array
            Console.WriteLine(weekDays[0]);
            Console.WriteLine(weekDays[1]);
            Console.WriteLine(weekDays[2]);
            Console.WriteLine(weekDays[3]);
            Console.WriteLine(weekDays[4]);
            Console.WriteLine(weekDays[5]);
            Console.WriteLine(weekDays[6]);
            Console.WriteLine();

            //for (int i = 0; i < 8 ; i++) //crashes
            for (int i = 0; i < weekDays.Length; i++)
            {
                Console.WriteLine(weekDays[i]);
            }

            Console.WriteLine();
            foreach (string day in weekDays)
            {
                Console.WriteLine(day);
            }
            Console.WriteLine();

            //assign multi-dimensional array elements
            grid[0, 0] = 55;
            grid[1, 2] = 7;
            grid[2, 4] = 23;


            //check randomness
            Random roll = new Random();
            
            for (int i = 0; i < 1000000; i++)
            {
                
                switch (roll.Next(0, 6))
                {
                    case 0:
                        rolls[0]++;
                        break;

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

                    default:
                        Console.WriteLine("out of bounds");
                        break;
                }
            }

            foreach (int count in rolls)
            {
                Console.WriteLine(count);
            }


            //pause
            Console.Read();
        }
    }
}
