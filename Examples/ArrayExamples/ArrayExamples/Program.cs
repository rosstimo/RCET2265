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

            Console.WriteLine(measurements[3]);

        //pause
            Console.ReadLine();
        }
    }
}
