namespace WorkingWithFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";

            // open/create a new file to write text
            // overwrites existing content!!
            using (StreamWriter testFile = File.CreateText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("this is a line of text");
                }
            }

            // open/create a new file to append text
            // Appends text to existing file content
            using (StreamWriter testFile = File.AppendText(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    testFile.WriteLine("Append this line of text");
                }
            }

            using (StreamReader testFile = new StreamReader(path))
            {
                Console.WriteLine(testFile.ReadLine());
            }
           

            Console.Read();
        }
    }
}
