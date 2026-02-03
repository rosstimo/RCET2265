namespace OutRefExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 2;
            Console.WriteLine(number);
            SetName(number); //number is unchanged
            Console.WriteLine(number);
            SetNameRef(ref number);//number is changed
            Console.WriteLine(number);
            SetNameOut(out number);//number is changed
            Console.WriteLine(number);
            Console.Read();
        }
        /// <summary>
        /// Has no affect on callers original variable
        /// </summary>
        /// <param name="aNumber"></param>
        static void SetName(int aNumber)
        {
            aNumber = 5;
        }
        /// <summary>
        /// Passes a reference of the callers original variable <br></br>
        /// This can change the value of the callers original value
        /// </summary>
        /// <param name="theNumber"></param>
        static void SetNameRef(ref int theNumber)
        {
            theNumber = 7;
        }
        /// <summary>
        /// Passes a reference of the callers original variable <br></br>
        /// This can change the value of the callers original value <br></br>
        /// Allows unassigned variable. int number; 
        /// </summary>
        /// <param name="someNumber"></param>
        static void SetNameOut(out int someNumber)
        {
            someNumber = 3;
        }


    }
}
