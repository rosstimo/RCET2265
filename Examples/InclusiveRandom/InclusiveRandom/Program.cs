namespace InclusiveRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = RandomNumberFrom(10, 3);
            // pause
            Console.ReadLine();
        }
        
        // TODO
        // [ ] Random number from min to max inclusive
        // [ ] returns and integer
        // [x] takes two argument max, min in that order
        // [ ] later make max and min optional with reasonable default values

        static void RandomNumberFrom(int max, int min)
        {
            return max + min;
        }


    }
}
