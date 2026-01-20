namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 5);
            Console.WriteLine(13 / 5); // integer division
            Console.WriteLine(13 % 5); // remainder
            Console.WriteLine(13d / 5d); // floating point division
            Console.WriteLine(13.0 / 5); // floating point division
            Console.WriteLine(13 / 5.0); // floating point division
            Console.WriteLine(13.0 / 5.0); // floating point division
            */

            //Console.WriteLine(5 > 2);
            //Console.WriteLine(5 < 2);
            //Console.WriteLine(5 == 2); // test if equal
            //Console.WriteLine(5 != 2); // test if not equal
            //Console.WriteLine(5 >= 2);
            //Console.WriteLine(5 <= 2);

            //// compund operators
            //int a = 5; //assign 5 to variable a
            ////a = a + 9;
            //a += 9; //compound asignment of a + 9
            //Console.WriteLine(a);

            //Console.WriteLine(++a); // incriment then print
            //Console.WriteLine(a);
            //Console.WriteLine(a++); // print then increment
            //Console.WriteLine(a);

            int firstNumber = 13;
            int secondNumber = 5;
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}");
            //Console.WriteLine(5 - 3);
            //Console.WriteLine(5 * 5);
            //Console.WriteLine(13 / 5); // integer division
            //Console.WriteLine(13 % 5); // remainder




            //pause
            Console.Read();
        }
    }
}
