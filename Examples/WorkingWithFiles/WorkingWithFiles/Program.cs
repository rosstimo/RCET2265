using System.IO;

namespace WorkingWithFiles
{
    internal class Program
    {

        static void WriteFile(string path)
        {
            // open/create a new file to write text
            // overwrites existing content!!
            using (StreamWriter testFile = File.CreateText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("this is a line of text");
                }
            }
        }

        static void AppendFile(string path) 
        {
            // open/create a new file to append text
            // Appends text to existing file content
            using (StreamWriter testFile = File.AppendText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("Append this line of text");
                }
            }
        }

        static void ReadFile(string path)
        {
            using (StreamReader testFile = new StreamReader(path))
            {

                // returns empty line if reading past end of file
                //for (int i = 0; i < 100; i++)
                //{
                //    Console.WriteLine(testFile.ReadLine());

                //}

                //stops when it reaches the end of file
                do
                {
                    Console.WriteLine(testFile.ReadLine());
                } while (testFile.EndOfStream == false);

            }
        }



        static void Main(string[] args)
        {
            // string path = "test.txt";
            string path = "..\\..\\..\\email.txt";
            string customer = "";
            string[] temp;

            //ReadFile(path);

            using (StreamReader testFile = new StreamReader(path))
            {
                do
                {
                    customer = testFile.ReadLine();
                    temp = customer.Split(",");
                    foreach (var record in temp)
                    {
                        Console.Write(record.PadRight(15));
                    }
                    Console.WriteLine();
                } while (testFile.EndOfStream == false);
            }


            Console.Read();
        }
    }
}
