namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //single dimensional arrays 
            int[] fruit = new int[5];
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




            //pause
            Console.Read();
        }
    }
}
