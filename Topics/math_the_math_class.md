# Math & The Math Class in C#

## Introduction

Math is everywhere in programming—from simple calculations to games and simulations. C# gives you built-in math operators and the powerful Math class to help you solve real problems. This section covers basic math, the Math class, and how to use them in your code.

---

**Basic Math:**
- Addition, subtraction, multiplication, division, modulus
- Example:
  ```csharp
  int a = 5;
  int b = 2;
  int total = a + b * 5;
  int remainder = a % b;
  Console.WriteLine(total); // 15
  Console.WriteLine(remainder); // 1
  ```
- Watch out for integer division (`5/2 = 2`, not 2.5)
  - Example:
    ```csharp
    int result = 5 / 2; // 2
    double result2 = 5.0 / 2; // 2.5
    ```

---

**Math Class:**
- `Math.Abs()`, `Math.Pow()`, `Math.Sqrt()`, `Math.Round()`, `Math.Min()`, `Math.Max()`, etc.
- Example:
  ```csharp
  double x = -3.5;
  Console.WriteLine(Math.Abs(x)); // 3.5
  Console.WriteLine(Math.Pow(2, 3)); // 8
  Console.WriteLine(Math.Sqrt(16)); // 4
  Console.WriteLine(Math.Round(2.718, 2)); // 2.72
  Console.WriteLine(Math.Max(5, 10)); // 10
  Console.WriteLine(Math.Min(5, 10)); // 5
  ```
- Random numbers:
  ```csharp
  Random rand = new Random();
  int n = rand.Next(1, 7); // Random number between 1 and 6
  Console.WriteLine(n);
  ```

---

**Order of Operations:**
- Use parentheses to avoid surprises
- PEMDAS: Parentheses, Exponents, Multiplication/Division, Addition/Subtraction
- Example:
  ```csharp
  int result = 3 + 4 * 2; // 11
  int result2 = (3 + 4) * 2; // 14
  ```

---

**Real-World Problems:**
- Use for calculations, scoring, games, simulation
- Example:
  ```csharp
  double score = Math.Round(95.7);
  Console.WriteLine($"Your score: {score}");
  ```

---

**Why it Matters:**
- If you can't do math in code, you can't do science, money, or real programming
- Math class saves you from reinventing the wheel

---

**Practical:**
- Practice using math operators and Math class methods in your code.
- Try generating random numbers and rounding results.
- Experiment with parentheses to see how order of operations changes results.

---

## References
- [C# Programming Guide: Math](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/math)
- [C# Programming Guide: Random](https://learn.microsoft.com/en-us/dotnet/api/system.random)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

