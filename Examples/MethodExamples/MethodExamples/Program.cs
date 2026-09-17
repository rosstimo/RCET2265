namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Joe", "Nancy", "Jimmy", "Sally" , "Bob"};
            int value = 7;
            int someNumber = 10;

            // iterate through names and print greeting
            foreach (string name in names )
            {
                PrintGreeting(name);
            }
            
            // demo return
            Console.WriteLine(SumOf(5, 6));

            Console.WriteLine(value);
            value = ChangeMy(value);
            Console.WriteLine(value);

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

        static int ChangeMy(int value)
        {
            value = value + 5;
            value += 5;
            return value;
        }

    }
}
