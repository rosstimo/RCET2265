namespace DecisionsDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int theNumber = 5;
            int age = 28;

            ////simple if statement
            //if (theNumber == 5)
            //{
            //    //when the evaluation is true all code here runs
            //    //when false all code here is skipped
            //    Console.WriteLine("my number is 5");
            //}

            //if (theNumber < 6) 
            //{
            //    //runs when true
            //    Console.WriteLine("The number is less than 6");
            //}
            //else
            //{
            //    // runs when false
            //    Console.WriteLine("The number is bigger than 6");
            //}

            //theNumber = 7;

            //if (theNumber < 6)
            //{
            //    Console.WriteLine("The number is less than 6");
            //}
            //else if (theNumber == 6)
            //{
            //    Console.WriteLine("The number is 6");
            //}
            //else
            //{
            //    Console.WriteLine("The number is greater than 6");
            //}

            age = 30;
            switch (age)
            {
                case < 0:
                    Console.WriteLine("Age not valid");
                    break;
                case > 0 and < 10:
                    Console.WriteLine("Sorry kid your too short!");
                    break;
                case > 13 and < 55:
                    Console.WriteLine("The kiddy ride has a strict weight limit sir...");
                    break;
                case > 54 and < 80:
                    Console.WriteLine("You may try the merry go round instead...");
                    break;
                default:
                    Console.WriteLine("Enjoy the Ride!");
                    break;
            }




            //pause
            Console.Read();
        }
    }
}
