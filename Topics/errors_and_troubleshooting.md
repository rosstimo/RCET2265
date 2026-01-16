# Errors and Troubleshooting in C#

## Introduction

Every programmer encounters errors. Learning to recognize, understand, and fix errors is a key skill for writing reliable code. This guide explains the main types of errors in C#, with simple examples and troubleshooting tips for beginners.

---

**Types of Errors:**

- **Compiler Errors:**
  - C# won’t even run your code (syntax, type, missing stuff)
  - Example:
    ```csharp
    int x = "hello"; // Error: cannot assign string to int
    Console.WriteLine(y); // Error: 'y' does not exist
    ```

- **Exceptions:**
  - Code crashes at runtime (divide by zero, null, out of bounds)
  - Example:
    ```csharp
    int[] numbers = {1, 2, 3};
    Console.WriteLine(numbers[5]); // Error: Index out of bounds
    int zero = 0;
    Console.WriteLine(10 / zero); // Error: Divide by zero
    ```

- **Logic Errors:**
  - Code runs, but does the wrong thing (off-by-one, bad math)
  - Example:
    ```csharp
    int total = 10;
    int count = 4;
    double average = total / count; // Logic error: integer division, result is 2 not 2.5
    ```

- **Style/Convention Violations:**
  - Code works, but it’s ugly, unreadable, or against class rules
  - Example:
    ```csharp
    int a=1;int b=2;Console.WriteLine(a+b); // Hard to read, bad style
    ```

---

## Troubleshooting Tips
- Read error messages carefully—they often tell you exactly what’s wrong.
- Fix one error at a time, starting with compiler errors.
- Use clear, consistent formatting and naming to avoid style errors.
- Test your code with different inputs to catch logic errors.
- Ask for help or search official documentation if you’re stuck.

---

## References
- [C# Programming Guide: Errors and Exceptions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/exceptions/)
- [C# Compiler Messages](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)
