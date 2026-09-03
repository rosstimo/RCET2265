namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 7;
            //if (firstNumber > 1)
            //{
            //    Console.WriteLine("Bigger than 1!");
            //}
            //else
            //{
            //    Console.WriteLine("Not bigger than 1!");
            //}

            if (firstNumber > 1)
            {
                Console.WriteLine("Bigger than 1!");
            }
            else if (firstNumber < 1)
            {
                Console.WriteLine("Not bigger than 1!");
            }
            else
            {
                Console.WriteLine("something else happened");
            }



            //pause
            Console.ReadLine();
        }
    }
}
