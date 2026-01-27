namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random rand = new Random(); // constructor

            //test randomness and range with a for loop
            for (int i = 0; i < 1000; i++)
            {
                //rand.Next(min,max) max is not inclusive
                int n = rand.Next(1, 7); // Random number between 1 and 6
                
                Console.Write(n);
            }

            //pause
            Console.Read();
        }
    }
}
