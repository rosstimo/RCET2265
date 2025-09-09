namespace LooptyLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop. loops a number of times
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}

            //nested for loop

            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            //pause
            Console.Read();
        }
    }
}
