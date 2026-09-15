namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Joe", "Nancy", "Jimmy", "Sally" , "Bob"};

            // iterate through names and print greeting
            foreach (string name in names )
            {
                PrintGreeting(name);
            }
            
            // demo return
            Console.WriteLine(SumOf(5, 6));

            // pause
            Console.ReadLine();
        }

        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }

        static int SumOf(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

    }
}
