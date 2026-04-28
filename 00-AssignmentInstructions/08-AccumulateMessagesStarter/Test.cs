using System;

public static class Test
{
    private static readonly Random random = new Random();

    /// <summary>
    /// Manually verify the function.
    /// </summary>
    public static void Manual() // Do not change the code in Manual
    {
        bool exit = false;
        do
        {
            Console.Clear();
            Console.WriteLine("Please type a message:\n");
            Console.WriteLine("D: Display all saved messages");
            Console.WriteLine("C: Clear all saved messages");
            Console.WriteLine("Q: Quit");
            Console.WriteLine();

            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "q":
                    exit = true;
                    break;
                case "d":
                    Console.Clear();
                    Console.WriteLine("Messages:\n");
                    Console.WriteLine(Program.UserMessages("", false));
                    break;
                case "c":
                    Console.Clear();
                    Console.WriteLine("Messages Cleared");
                    Program.UserMessages("", true);
                    break;
                default:
                    Program.UserMessages(userInput, false);
                    Console.Clear();
                    Console.WriteLine("Message saved.");
                    break;
            }

            Console.WriteLine("\nPress Enter to continue");
            Console.ReadLine();
        } while (!exit);

        Console.Clear();
        Console.WriteLine("Have a nice day!");
    }

    /// <summary>
    /// Automatic testing. Make all tests pass.
    /// </summary>
    public static void Auto() // Do not change the code in Auto
    {
        string expected;
        string actual = "";
        int clearAfter;

        string[] testData =
        {
            "Hello",
            "Good bye",
            "Jimmy likes pizza!!",
            "too many bananas",
            "more",
            "aardvark",
            "must be a number",
            "I need one more message"
        };

        // Start from a known state.
        Program.UserMessages("", true);

        Console.WriteLine("Call with empty strings:");
        expected = "";
        for (int i = 0; i < 3; i++)
        {
            Program.UserMessages("", false);
        }

        AreEqual(expected, Program.UserMessages("", false));

        Console.WriteLine("Call with many sequential messages:");
        expected = "";
        Program.UserMessages("", true);

        for (int i = 0; i < testData.Length; i++)
        {
            expected += testData[i] + Environment.NewLine;
            actual = Program.UserMessages(testData[i], false);
        }

        AreEqual(expected, actual);

        Console.WriteLine("Call with clear messages true:");
        expected = "";
        actual = Program.UserMessages("", true);
        AreEqual(expected, actual);
        actual = Program.UserMessages("Anything", true);
        AreEqual(expected, actual);

        Console.WriteLine("Call with clear midway in sequential messages:");
        expected = "";
        Program.UserMessages("", true);
        clearAfter = RandomNumberInRange(7, 3);

        for (int i = 0; i < testData.Length; i++)
        {
            if (i == clearAfter)
            {
                expected = "";
                Program.UserMessages("", true);
            }

            expected += testData[i] + Environment.NewLine;
            actual = Program.UserMessages(testData[i], false);
        }

        AreEqual(expected, actual);
    }

    private static bool AreEqual(string expected, string actual)
    {
        ConsoleColor textColor;
        string result;

        if (actual == expected)
        {
            textColor = ConsoleColor.Green;
            result = "PASS";
        }
        else
        {
            textColor = ConsoleColor.Red;
            result = "FAIL";
        }

        Console.ForegroundColor = textColor;
        Console.WriteLine($"{new string('*', 4)} {result}: {new string('*', 4)}");
        Console.WriteLine(">> Expected:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(expected);
        Console.ForegroundColor = textColor;
        Console.WriteLine(">> Actual:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(actual);
        Console.ForegroundColor = textColor;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;

        return actual == expected;
    }

    private static int RandomNumberInRange(int max = 10, int min = 0)
    {
        return random.Next(min, max + 1);
    }
}
