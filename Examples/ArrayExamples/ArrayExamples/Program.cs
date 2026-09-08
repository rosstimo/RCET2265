namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] measurements = new int[5];

            measurements[2] = 34;
            measurements[4] = 47;
            measurements[0] = 55;
            
            for (int i =0; i <= measurements.GetUpperBound(0); i++)
            {
                Console.WriteLine(measurements[i]);
            }

           Console.WriteLine($"the array is {measurements.Length} elements long");

        //pause
            Console.ReadLine();
        }
    }
}
