namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fruit = new int[5];
            string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

            fruit[0] = 3;
            fruit[1] = 4;
            fruit[2] = 7;
            fruit[3] = 8;
            fruit[4] = 133;

            Console.WriteLine(fruit[3]);



            Console.WriteLine(weekDays[0]);
            Console.WriteLine(weekDays[1]);
            Console.WriteLine(weekDays[2]);
            Console.WriteLine(weekDays[3]);
            Console.WriteLine(weekDays[4]);
            Console.WriteLine(weekDays[5]);
            Console.WriteLine(weekDays[6]);

            /*Output:
            Sun
            Mon
            Tue
            Wed
            Thu
            Fri
            Sat
            */

            //pause
            Console.Read();
        }
    }
}
