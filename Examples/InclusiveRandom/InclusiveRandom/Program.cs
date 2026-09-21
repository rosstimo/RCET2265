namespace InclusiveRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRandomNumberInclusive();
            // pause
            Console.ReadLine();
        }

        static void TestRandomNumberInclusive()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (RandomNumberFrom(10, 3) < 3 || RandomNumberFrom(10, 3) > 10)
                {
                    Console.WriteLine($"Error {RandomNumberFrom(10, 3) } is out of range");
                }
                //else
                //{ 
                //    Console.WriteLine(RandomNumberFrom(10, 3));
                //}
            }

        }
        
        // TODO
        // [ ] Random number from min to max inclusive
        // [x] returns and integer
        // [x] takes two argument max, min in that order
        // [ ] later make max and min optional with reasonable default values

        static int RandomNumberFrom(int max, int min)
        {
            Random randy = new Random();
            return randy.Next(min, max + 1 + 1);
        }


    }
}
