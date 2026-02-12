using System.Net.NetworkInformation;

namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            int someNumber = 5, someOtherNumber = 7;

            //SayHello();
            //AddNumbers();
            //AddNumbers();
            //SayHello();
            //ShowCount();
            //Console.WriteLine(count);
            //count = SumOf(someNumber,someOtherNumber);
            //Console.WriteLine(count);
            Console.WriteLine(count);
            ChangeMyNumber(ref count);
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

        static int SumOf(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        static void ChangeMyNumber(ref int theNumber )
        {
            theNumber *= 2;
            Console.WriteLine(theNumber);
        }

        static bool ConvertToInt(string input, out int result)
        {
            bool successful = false;
            result = 0; //out requires an assignment no matter what


            return successful;
        }
    }
}
