using System.Text;

namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //numeric
            int firstNumber;
            int secondNumber;
            int result;
            double firstValue = 5d;
            decimal total = 42.45m;

            char symbol = '7';
            int charCode = 81;

            //Constants (don't change, read only)

            const decimal TAXRATE = 0.06m;

            //firstNumber = 7; // varibles can change 
            //TAXRATE = 0.09m; // contants can not change


            //print the ascii code to the console
            //Console.WriteLine((int)symbol);
            //Console.WriteLine((char)charCode);




            //text data
            string name = "Bill";
            string userInput;

            // true or false, 1 or 0
            bool done = false;

            firstNumber = 5;
            


            Console.WriteLine("Please Enter a Whole Number");
            userInput = Console.ReadLine();
            Console.WriteLine($"Your number is {userInput}");
            secondNumber = int.Parse(userInput); //convert string to int
            result = firstNumber + secondNumber; //do the math
            Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");//display the math

            //pause
            Console.Read();
        }
    }
}
