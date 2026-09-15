namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Joe", "Nancy", "Jimmy", "Sally" , "Bob"};
            foreach (string name in names )
            {
                PrintGreeting(name);
            }
            // pause
            Console.ReadLine();
        }

        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
