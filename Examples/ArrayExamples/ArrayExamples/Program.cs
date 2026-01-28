namespace ArrayExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            string[] fruits = new string[7];
            string[] daysOfTheWeek = ["Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"];
            int[,] grid = new int[5, 5];


            //fruits[0] = "apple";
            //fruits[1] = "banana";
            //fruits[2] = "kiwi";
            //fruits[3] = "tomato";
            //fruits[4] = "pineapple";
            //fruits[5] = "dragon fruit";
            //fruits[6] = "watermelon";
            ////fruits[7] = "tangerine"; //this will crash. index out of range
            ////Console.WriteLine(fruits[3]);

            //// read all the fruits
            //for (int i = 0; i < 7; i++) 
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            //// same with no index or need for known length
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Console.WriteLine($"The length of fruits is: {fruits.Length}");


            for (int column = 0; column < 5; column++)
            {
                for (int row = 0; row < 5; row++)
                {
                    grid[column,row] = column * row;   

                }
            }

                    Console.Write(grid[3,3]);

            //pause
            Console.Read();
        }
    }
}
