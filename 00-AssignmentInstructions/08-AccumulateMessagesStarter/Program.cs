using System;

public static class Program
{
    private static string messages = "";

    // Do not change the code in Main
    public static void Main(string[] args)
    {
        string input = "";
        Console.WriteLine("Choose test mode: (M)anual, (A)uto, or (Q)uit");
        input = Console.ReadLine();
        
        switch (input.Trim().ToUpper())
        {
            case "M":
                Test.Manual();
                break;
            case "A":
                Test.Auto();
                break;
            case "Q":
                Console.WriteLine("Quitting.");
                break;
            default:
                Console.WriteLine("Invalid input. Quitting.");
                break;
        }
    }
        //TODO:
        // [ ] - If clear is true, erase all saved messages.
        // [ ] - Do not save empty messages.
        // [ ] - add a new line after each new message.
        // [ ] - Always return currently saved messages.
        // [ ] - Make sure all auto tests pass.
    public static string UserMessages(string newMessage, bool clear)
    {
        //Write your code here.
        return messages;
    }


}
