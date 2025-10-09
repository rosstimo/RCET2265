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

        static void AddCustomer(string path, string[] customerData)
        {
            string _customerData = "";

            using (StreamWriter customerDataFile = File.AppendText(path))
            {

                //foreach (string customerRecord in customerData)
                //{
                //    _customerData += customerRecord;
                //}
                try
                {
                    //TODO: add customer number, address, zip, state, phone
                    _customerData = $"{customerData[0]},{customerData[1]},{customerData[2]},{customerData[3]}";
                    customerDataFile.WriteLine(_customerData);
                }
                catch (Exception ex)
                {
                    //log record and error description to log file
                    //get exception message
                    Console.WriteLine($"{ex.StackTrace}\n\n{customerData.Length}");
                }

            }
        }


        static void Main(string[] args)
        {
            // string path = "test.txt";
            string path = "..\\..\\..\\email.txt";
            string customer = "";
            string[] temp;
            string formatedRecord = "";
            int counter = 0;

            using (StreamReader testFile = new StreamReader(path))
            {
                do
                {
                    customer = testFile.ReadLine();
                    temp = customer.Split(",");

                    //Console.Write($"Length: {temp.Length}".PadRight(15)); TODO filter bad records
                    
                    for (int i = 0; i < temp.GetUpperBound(0); i++)
                    {
                        temp[i] = temp[i].Replace('"', '$');
                        temp[i] = temp[i].Replace("$", "");
                        //Console.WriteLine(i + ": " + temp[i]);
                    }
                    AddCustomer("..\\..\\..\\CustomerDB.txt",temp);

                //    foreach (string record in temp)
                //    {
                //        formatedRecord = record;

                //        formatedRecord = formatedRecord.Replace('"', '$');
                //        //formatedRecord = formatedRecord.Replace('"'.ToString(), "");
                //        formatedRecord = formatedRecord.Replace("$", "");
                //        //Console.Write(formatedRecord.PadRight(15));
                //       //Console.WriteLine(record.Count());
                //    }
                //    //Console.WriteLine();
                //    counter++;
                } while (testFile.EndOfStream == false);
                //Console.WriteLine($"Read {counter} lines from {path}");
            }

            Console.Read();
        }
    }
}
