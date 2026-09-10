namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] measurements = new int[5];

            measurements[0] = 1;
            measurements[1] = 7;
            measurements[2] = 3;
            measurements[3] = 5;
            measurements[4] = 2;
            
            foreach (int measurement in measurements)
            {
                for (int i = 0; i < measurement; i++)
                {
                    Console.Write("-");
                }
                Console.WriteLine(">");
            }




            //pause
            Console.ReadLine();
        }
    }
}
