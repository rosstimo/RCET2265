namespace MathClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int currentRandomNumber = 0;
            Random randomNumber = new Random();

            //Console.WriteLine( Math.Sqrt(firstNumber) * Math.Sqrt(firstNumber));
            //Console.WriteLine(Math.Pow(2, 2));

            for (int i = 0; i < 100; i++)
            {
                currentRandomNumber = randomNumber.Next(1, 7); // Random number between 1 and 6
                Console.WriteLine(currentRandomNumber);

            }


            //pause
            Console.Read();
        }
    }
}
