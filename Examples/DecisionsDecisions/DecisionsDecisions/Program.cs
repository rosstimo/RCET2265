namespace DecisionsDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int theNumber = 5;

            //simple if statement
            if (theNumber == 5)
            {
                //when the evaluation is true all code here runs
                //when false all code here is skipped
                Console.WriteLine("my number is 5");
            }

            if (theNumber < 6) 
            {
                //runs when true
                Console.WriteLine("The number is less than 6");
            }
            else
            {
                // runs when false
                Console.WriteLine("The number is bigger than 6");
            }

            theNumber = 7;

            if (theNumber < 6)
            {
                Console.WriteLine("The number is less than 6");
            }
            else if (theNumber == 6)
            {
                Console.WriteLine("The number is 6");
            }
            else
            {
                Console.WriteLine("The number is greater than 6");
            }




                //pause
                Console.Read();
        }
    }
}
