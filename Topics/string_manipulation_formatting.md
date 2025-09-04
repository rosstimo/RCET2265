# String Manipulation & Formatting in C#

## Introduction

Strings are used for text in your programs—names, messages, user input, and more. Learning to create, format, and manipulate strings is essential for almost every project. This section covers string creation, common methods, formatting, parsing, and fun assignments.

---

**String Creation:**
- Literal: `string name = "Sheila";`
- Concatenation: `string full = first + " " + last;`
- Interpolation: `$"Hi {name}, your score is {score}!"`
- Example:
  ```csharp
  string first = "Sheila";
  string last = "Rocks";
  string full = first + " " + last;
  string message = $"Hi {first}, welcome!";
  Console.WriteLine(message);
  ```

---

**Common Methods:**
- `ToUpper()`, `ToLower()`, `Substring()`, `IndexOf()`, `Contains()`, `Split()`, `Join()`
- Example:
  ```csharp
  string input = "Yes";
  if (input.ToLower().Contains("yes"))
  {
      Console.WriteLine("You said yes!");
  }
  string part = input.Substring(0, 1); // "Y"
  ```

---

**Formatting and Padding:**
- Align numbers/strings: `String.Format()`, `PadLeft()`, `PadRight()`, interpolation
- Example:
  ```csharp
  int score = 42;
  string formatted = String.Format("Score: {0,5}", score); // right-align
  string padded = score.ToString().PadLeft(5, '0'); // "00042"
  Console.WriteLine(formatted);
  Console.WriteLine(padded);
  ```

---

**Parsing and Conversion:**
- `int.Parse()`, `double.Parse()`, `TryParse()` for safe conversions
- Always check for invalid input, use `TryParse` inside a `try/catch` or if statement
- Example:
  ```csharp
  string numberText = "123";
  if (int.TryParse(numberText, out int number))
  {
      Console.WriteLine($"Parsed number: {number}");
  }
  else
  {
      Console.WriteLine("Invalid number!");
  }
  ```

---

**Why it Matters:**
- Strings are everywhere—files, input, output
- Learn to manipulate strings early = less pain later

---

**Practical:**
- Practice creating, formatting, and manipulating strings.
- Try parsing user input and handling errors.
- Build a simple MadLib or string reverser for fun.

---

## References
- [C# Programming Guide: Strings](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
- [C# Programming Guide: Formatting Types](https://learn.microsoft.com/en-us/dotnet/standard/base-types/formatting-types)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

