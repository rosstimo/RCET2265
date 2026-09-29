using System;

public static class Program
{
    private static string messages = "";

    public static object Envirnment { get; private set; }

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
        // pause
        Console.ReadLine();
    }
        //TODO:
        // [x] - If clear is true, erase all saved messages.
        // [x] - Do not save empty messages.
        // [x] - add a new line after each new message.
        // [x] - Always return currently saved messages.
        // [x] - Make sure all auto tests pass.
    public static string UserMessages(string newMessage, bool clear)
    {
        if (clear)
        {
            messages = "";
        }
        else if (newMessage != "")
        {
            messages += newMessage + Environment.NewLine; // can't simply use /n or /r/n because will not match ion all systems.
        }
        return messages;
    }
}
