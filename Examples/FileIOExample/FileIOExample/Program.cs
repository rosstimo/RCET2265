using System.Net.NetworkInformation;

namespace FileIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "..\\..\\..\\email.txt";
            string[,] customerInfo;

            //WriteToFile();
            //AppendToFile();
            //ReadFile();
            //ReadEntireFile("..\\..\\..\\email.txt");
            customerInfo = FileToArray(path); //TODO: add display array method
            DisplayData(customerInfo);
            //pause
            Console.Read();
        }

        static void WriteToFile()
        {
            using (StreamWriter testFile = File.CreateText("..\\..\\..\\TestFile.txt"))
            {
                testFile.WriteLine("Wake up Neo...");
            }
        }

        static void AppendToFile()
        {
            using (StreamWriter testFile = File.AppendText("..\\..\\..\\TestFile.txt"))
            {
                testFile.WriteLine("Follow the white rabbit...");
            }
        }

        static void ReadFile()
        {
            using (StreamReader testFile = new StreamReader("..\\..\\..\\TestFile.txt"))
            {
                Console.WriteLine(testFile.ReadLine());
                Console.WriteLine(testFile.ReadLine());

            }
        }

        static void ReadEntireFile(string filePath)
        {
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    Console.WriteLine(testFile.ReadLine());

                } while (!testFile.EndOfStream);

            }
        }

        static int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }

        static string[,] FileToArray(string filePath)
        {
            string[,] customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;
            
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$","");
                        temp[3] = temp[3].Replace("\"","");
                        customerData[0, counter] = temp[0];
                        customerData[1, counter] = temp[1];
                        customerData[2, counter] = temp[2];
                        customerData[3, counter] = temp[3];
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            return customerData;
        }

        static void DisplayData(string[,] data)
        {
            string formattedRow = "";
            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null)
                    {
                        formattedRow += data[column, row].PadRight(14);
                    }
                }
                if (formattedRow != "")
                {
                    Console.WriteLine(formattedRow);
                }
                formattedRow = "";
            }
        }

    }
}
