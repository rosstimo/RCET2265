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
            int max = 1;
            int min = 0;
            int currentNumber; 
            for (int i = 0; i < 1000; i++)
            {
                currentNumber = RandomNumberFrom(max,min);
                if (currentNumber < min || currentNumber > max)
                {
                    Console.WriteLine($"Error {currentNumber} is out of range");
                }
                else
                {
                    Console.WriteLine(currentNumber);
                }
            }
            Console.WriteLine("Test Complete");

        }
        
        // TODO
        // [x] Random number from min to max inclusive
        // [x] returns and integer
        // [x] takes two argument max, min in that order
        // [x] later make max and min optional with reasonable default values

        static int RandomNumberFrom(int max = 10, int min = 1)
        {
            Random randy = new Random();
            return randy.Next(min, max + 1);
        }


    }
}
