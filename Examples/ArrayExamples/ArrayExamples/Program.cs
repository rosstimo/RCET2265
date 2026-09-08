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
            
            foreach (int measurement in measurements)
            {
                Console.WriteLine(measurement);
            }

           Console.WriteLine($"the array is {measurements.Length} elements long");

        //pause
            Console.ReadLine();
        }
    }
}
