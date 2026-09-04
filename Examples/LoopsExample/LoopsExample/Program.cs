namespace LoopsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("hello");
            //}

            int someNumber = 0;
            while (someNumber <= 7)
            {
                Console.WriteLine("in the while loop");
                someNumber++;
            }

            //pause
            Console.ReadLine();
        }
    }
}
