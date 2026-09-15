namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting();
            PrintGreeting();
            PrintGreeting();
            PrintGreeting();
            PrintGreeting();
            // pause
            Console.ReadLine();
        }

        static void PrintGreeting()
        {
            Console.WriteLine("hello from inside the method");
        }
    }
}
