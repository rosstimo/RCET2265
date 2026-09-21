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
            int currentNumber; 
            for (int i = 0; i < 1000000; i++)
            {
                currentNumber = RandomNumberFrom(10, 3);
                if (currentNumber < 3 || currentNumber > 10)
                {
                    Console.WriteLine($"Error {currentNumber} is out of range");
                }
                //else
                //{ 
                //    Console.WriteLine(currentNumber(10, 3));
                //}
            }
                Console.WriteLine("Test Complete");

        }
        
        // TODO
        // [x] Random number from min to max inclusive
        // [x] returns and integer
        // [x] takes two argument max, min in that order
        // [ ] later make max and min optional with reasonable default values

        static int RandomNumberFrom(int max, int min)
        {
            Random randy = new Random();
            return randy.Next(min, max + 1);
        }


    }
}
