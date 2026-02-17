using System.Net.NetworkInformation;

namespace FileIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //WriteToFile();
            //AppendToFile();
            //ReadFile();
            ReadEntireFile("..\\..\\..\\TestFile.txt");
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
    }
}
