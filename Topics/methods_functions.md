# Methods & Functions in C#

## Introduction

Methods and functions are blocks of code that perform specific tasks. They help you organize, reuse, and structure your programs. This section explains how to write methods, return values, pass arguments, and use features like overloading and recursion.

---

**Subroutines (`void`):**
- Methods that do something but return nothing
- Syntax:
  ```csharp
  void SayHello()
  {
      Console.WriteLine("Hello!");
  }
  SayHello(); // Call the method
  ```

---

**Functions (Return):**
- Methods that return values
- Syntax:
  ```csharp
  int Add(int x, int y)
  {
      return x + y;
  }
  int sum = Add(3, 4); // sum is 7
  ```
- Used for calculations, logic, transformations

---

**Scope & Lifetime:**
- Local variables: Exist only inside method/block
- Class variables (fields): Exist as long as object exists
- Static variables: Belong to the class, not instances
- Example:
  ```csharp
  class Counter
  {
      int count = 0; // field
      static int total = 0; // static field
      void Increment()
      {
          count++;
          total++;
      }
  }
  ```

---

**Argument Passing:**
- By value: default (makes a copy)
- By reference: use `ref`/`out` (changes original); demo, but don’t overuse
- Example:
  ```csharp
  void SetToTen(ref int number)
  {
      number = 10;
  }
  int myNum = 5;
  SetToTen(ref myNum); // myNum is now 10
  ```

---

**Overloading:**
- Same method name, different parameter list (C# picks the right one)
- Makes APIs more flexible and code more readable
- Example:
  ```csharp
  int Add(int x, int y) { return x + y; }
  double Add(double x, double y) { return x + y; }
  Console.WriteLine(Add(2, 3)); // 5
  Console.WriteLine(Add(2.5, 3.5)); // 6.0
  ```

---

**Recursion:**
- Method calls itself (with a base case, or you’ll crash)
- Classic example: factorial, Fibonacci, sum array
- Example:
  ```csharp
  int Factorial(int n)
  {
      if (n <= 1) return 1;
      return n * Factorial(n - 1);
  }
  Console.WriteLine(Factorial(5)); // 120
  ```

---

**Why it Matters:**
- Methods keep code organized, reusable, and readable
- Understanding arguments, scope, and return values is core to all coding

---

**Practical:**
- Practice writing methods that do something and methods that return values.
- Try passing arguments by value and by reference.
- Experiment with method overloading and recursion.
- Use methods to break up big problems into smaller, reusable pieces.

---

## References
- [C# Programming Guide: Methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods/)
- [C# Programming Guide: Parameters](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/methods/#parameters)
- [C# Programming Guide: Recursion](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/recursion)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

