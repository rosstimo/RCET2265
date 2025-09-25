namespace MethodExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myLuckyNumber = 5;

            // call SayHello Method
            //SayHello();
            

            //PrintSum(5, 5);


            Console.WriteLine(myLuckyNumber);
            LuckyNumber();
            OtherLuckyNumber(myLuckyNumber);
            //NotSoLuckyNumber(ref myLuckyNumber);
            Console.WriteLine(myLuckyNumber);

            Console.WriteLine(CalculateSum(5, 3));
            myLuckyNumber = CalculateSum(5, 2);
            Console.WriteLine(myLuckyNumber);
            //pause
            Console.Read();
        }

        //define the SayHello Method
        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void PrintSum(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
        static void LuckyNumber()
        {
            int myLuckyNumber = 7;
            Console.WriteLine(myLuckyNumber);
        }
        static void OtherLuckyNumber(int myLuckyNumber)
        {
            myLuckyNumber++;
            Console.WriteLine(myLuckyNumber);
        }
        static void NotSoLuckyNumber(ref int myLuckyNumber)
        {
            myLuckyNumber++;
            Console.WriteLine(myLuckyNumber);
        }
        static int CalculateSum(int firstNumber, int secondNumber)
        {
            int result = firstNumber + secondNumber;
            return result;
        }

    }
}
