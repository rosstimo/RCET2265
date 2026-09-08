namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] measurements = new int[5];
            int[,] grid = new int[3, 5];

            measurements[2] = 34;
            measurements[4] = 47;
            measurements[0] = 55;
            
            foreach (int measurement in measurements)
            {
                Console.WriteLine(measurement);
            }

           Console.WriteLine($"the array is {measurements.Length} elements long");


            grid[0, 0] = 35;
            grid[2, 3] = 55;
            grid[2, 4] = 999;
            foreach (int coordinate in grid)
            {
                Console.WriteLine(coordinate);
            }
            Console.WriteLine($"the array is {grid.Length} elements in length");
            Console.WriteLine($"the array is {grid.LongLength} elements long length");




            //pause
            Console.ReadLine();
        }
    }
}
