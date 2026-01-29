using System.Net.NetworkInformation;

namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;

            //SayHello();
            //AddNumbers();
            //AddNumbers();
            //SayHello();
            ShowCount();
            Console.WriteLine(count);
            //pause
            Console.Read();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        static void AddNumbers()
        {
           
            Console.WriteLine(1 + 1);
        }

        static void ShowCount()
        {
            int count = 7;
            Console.WriteLine(count);
        }

    }
}
