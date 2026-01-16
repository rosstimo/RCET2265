# Getting Started & Console Fundamentals in C#

## Introduction

The console is the simplest way to interact with your programs. It lets you print messages, get user input, and see what your code is doing. Learning console basics is the best way to start programming in C#.

---

**Console Basics:**
- `Console.WriteLine()`, `Console.Write()`: Print to the screen
  - Example:
    ```csharp
    Console.WriteLine("Hello, World!");
    Console.Write("Enter your name: ");
    ```
- `Console.ReadLine()`: Get user input
  - Example:
    ```csharp
    string name = Console.ReadLine();
    Console.WriteLine($"Hello, {name}!");
    ```
- `Console.Beep()`, `Console.Clear()`: Make noise, clear screen
  - Example:
    ```csharp
    Console.Beep();
    Console.Clear();
    ```
- Demo: Play tones (e.g., Close Encounters), use colored text for fun

---

**Running Programs:**
- Run from IDE (F5), see the output window
- If the console closes too fast, add `Console.ReadLine()` at the end
  - Example:
    ```csharp
    Console.WriteLine("Press Enter to exit...");
    Console.ReadLine();
    ```

---

**Documentation & Help:**
- Hit F1 to get docs for anything in Visual Studio
- Look up methods: what parameters they take, what they return
- Practice: “How do I make the console beep for 1 second?”

---

**Debugging First Steps:**
- Use breakpoints to pause and inspect values
- Step through code line-by-line (F10/F11)

---

**Why it Matters:**
- Console is the best place to learn the basics before you touch GUIs
- Real programmers look up docs, don’t just guess and pray

---

**Practical:**
- Practice printing messages and reading user input.
- Try using `Console.Beep()` and `Console.Clear()` for fun effects.
- Add `Console.ReadLine()` at the end of your program to keep the window open.
- Use breakpoints and step through your code to see how it works.

---

## References
- [C# Programming Guide: Console](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/console/)
- [C# Programming Guide: Statements, Expressions, and Operators](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

