# Loops in C#

## Introduction

Loops let you repeat actions in your code, making it possible to process data, automate tasks, and build useful programs. Understanding loops is essential for handling lists, tables, and any repetitive work. This section covers the main types of loops, how to control them, and common mistakes to avoid.

---

**Types of Loops:**
- `for` loop: Use when you know how many times to repeat
  - Example:
    ```csharp
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Count: {i}");
    }
    ```
- `while` loop: Repeat as long as a condition is true
  - Example:
    ```csharp
    int number = 1;
    while (number <= 3)
    {
        Console.WriteLine($"Number: {number}");
        number++;
    }
    ```
- `do-while` loop: Always runs at least once
  - Example:
    ```csharp
    int tries = 0;
    do
    {
        Console.WriteLine($"Try #{++tries}");
    } while (tries < 3);
    ```

---

**Loop Control:**
- `break`: Exit loop early
  - Example:
    ```csharp
    for (int i = 0; i < 10; i++)
    {
        if (i == 5)
        {
            break; // Stop the loop when i is 5
        }
        Console.WriteLine(i);
    }
    ```
- `continue`: Skip to next iteration
  - Example:
    ```csharp
    for (int i = 0; i < 5; i++)
    {
        if (i == 2)
        {
            continue; // Skip printing 2
        }
        Console.WriteLine(i);
    }
    ```
- Nested loops: Use for tables and grids, but keep it simple to avoid confusion

---

**Common Mistakes:**
- Off-by-one errors (classic)
  - Example:
    ```csharp
    for (int i = 1; i <= 5; i++) // Prints 1 to 5, not 0 to 4
    {
        Console.WriteLine(i);
    }
    ```
- Infinite loops (forgot to update your condition)
  - Example:
    ```csharp
    int x = 0;
    while (x < 5)
    {
        // Missing x++ means this loop never ends
    }
    ```

---

**Real Tasks:**
- Counting, summing, searching, table generation
- Example:
  ```csharp
  int sum = 0;
  for (int i = 1; i <= 5; i++)
  {
      sum += i;
  }
  Console.WriteLine($"Sum: {sum}");
  ```

---

**Why it Matters:**
- Loops let you process data, automate repetitive work, and make useful programs
- Mastering loops makes you a more efficient and confident programmer

---

**Practical:**
- Practice writing each type of loop and controlling them with `break` and `continue`.
- Try using loops to count, sum, and search through lists of data.
- Watch out for off-by-one and infinite loop mistakes.

---

## References
- [C# Programming Guide: Loops](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/loops/)
- [C# Programming Guide: Statements, Expressions, and Operators](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

