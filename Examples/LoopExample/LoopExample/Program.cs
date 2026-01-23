namespace LoopExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Count: {i}");
            //}

            //for (int i = 5; i >= -5; i--)
            //{
            //    Console.WriteLine($"Count: {i}");
            //}

            //int number = 1;

            ////only runs if condition is true
            //while (number <= 3)
            //{
            //    Console.WriteLine($"In While Loop Number: {number}");
            //    number++;
            //}

            ////always runs at least one time
            //do
            //{
            //    Console.WriteLine($"In Do Loop Number: {number}");
            //    number++;
            //} while (number <= 3);

            string userInput = "";
            Console.WriteLine("The password is 12345 just like my luggage");

            while (Console.ReadLine() != "12345");
            {
                Console.WriteLine("All my secrets");
            }


            //pause
            Console.Read();
        }
    }
}
