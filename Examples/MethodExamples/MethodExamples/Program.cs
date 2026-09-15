namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting("Nancy");
            // pause
            Console.ReadLine();
        }

        static void PrintGreeting(string name)
        {
            Console.WriteLine($"hello, {name}");
        }
    }
}
