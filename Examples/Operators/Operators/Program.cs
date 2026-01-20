namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(5 + 5);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 5);
            Console.WriteLine(13 / 5); // integer division
            Console.WriteLine(13 % 5); // remainder
            Console.WriteLine(13d / 5d); // floating point division
            Console.WriteLine(13.0 / 5); // floating point division
            Console.WriteLine(13 / 5.0); // floating point division
            Console.WriteLine(13.0 / 5.0); // floating point division

            //pause
            Console.Read();
        }
    }
}
