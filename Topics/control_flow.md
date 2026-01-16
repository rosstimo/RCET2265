# Control Flow & Error Types in C#

## Introduction

Control flow lets you decide what your program does next, based on conditions and choices. Understanding control flow is key to writing programs that make decisions, repeat actions, and handle errors. This section covers the basics of conditionals and best practices for readable code.

---

**Conditionals:**

- **Using `if` Statements**
  - The `if` statement lets your program make decisions based on a condition. If the condition is true, the code inside the block runs.
  - Example:
    ```csharp
    int score = 95;
    if (score >= 90)
    {
        Console.WriteLine("Excellent! You got an A.");
    }
    ```
  - You can add an `else` to handle the opposite case:
    ```csharp
    int score = 75;
    if (score >= 60)
    {
        Console.WriteLine("Pass. You did well enough.");
    }
    else
    {
        Console.WriteLine("Fail. Let's review and try again.");
    }
    ```
  - For more choices, use `else if`:
    ```csharp
    int score = 85;
    if (score >= 90)
    {
        Console.WriteLine("Excellent! You got an A.");
    }
    else if (score >= 70)
    {
        Console.WriteLine("Good job! You passed.");
    }
    else
    {
        Console.WriteLine("Keep trying! Practice makes perfect.");
    }
    ```

- **Using `switch` Statements**
  - The `switch` statement is useful when you have many possible values for a variable and want to handle each one differently.
  - Example:
    ```csharp
    int day = 3;
    switch (day)
    {
        case 1:
            Console.WriteLine("It's Monday. Time to start the week!");
            break;
        case 2:
            Console.WriteLine("It's Tuesday. Keep going!");
            break;
        case 3:
            Console.WriteLine("It's Wednesday. Halfway there!");
            break;
        default:
            Console.WriteLine("It's another day. Make it count!");
            break;
    }
    ```
- Boolean logic: `&&`, `||`, `!`—combine/negate conditions
  - Example:
    ```csharp
    bool isAdult = age >= 18;
    bool hasID = true;
    if (isAdult && hasID)
    {
        Console.WriteLine("Entry allowed.");
    }
    if (!hasID)
    {
        Console.WriteLine("ID required.");
    }
    ```
- Ternary operator (`? :`)—show, but not required
  - Example:
    ```csharp
    int points = 75;
    string result = (points >= 60) ? "Pass" : "Fail";
    Console.WriteLine(result);
    ```

---

**How Conditionals Are Evaluated**

- In an `if`/`else if`/`else` chain, conditions are checked from top to bottom, one at a time.
- As soon as a condition is true, its block runs and the rest are skipped.
- Only one block in the chain will run.
- Example:
  ```csharp
  int score = 85;
  if (score >= 90)
  {
      Console.WriteLine("Excellent! You got an A."); // Not run (score is 85)
  }
  else if (score >= 70)
  {
      Console.WriteLine("Good job! You passed."); // This runs (score is 85)
  }
  else
  {
      Console.WriteLine("Keep trying! Practice makes perfect."); // Skipped
  }
  ```
- If none of the conditions are true, the `else` block runs.

**Order Matters:**
- Always put the most specific or highest-priority condition first.
- Example:
  ```csharp
  int temp = 100;
  if (temp > 90)
  {
      Console.WriteLine("Hot!");
  }
  else if (temp > 70)
  {
      Console.WriteLine("Warm.");
  }
  else
  {
      Console.WriteLine("Cool.");
  }
  ```

**Switch Statement Evaluation**
- The value in the `switch` is compared to each `case` in order.
- When a match is found, only that block runs, and the rest are skipped.
- If no match is found, the `default` block runs.
- Example:
  ```csharp
  int day = 2;
  switch (day)
  {
      case 1:
          Console.WriteLine("It's Monday."); // Skipped
          break;
      case 2:
          Console.WriteLine("It's Tuesday."); // This runs
          break;
      case 3:
          Console.WriteLine("It's Wednesday."); // Skipped
          break;
      default:
          Console.WriteLine("Other day."); // Skipped
          break;
  }
  ```
- **Why use `break`?**
  - The `break` statement tells C# to stop checking more cases and exit the switch block after a match is found and its code runs.
  - Without `break`, C# would keep running the code in the next cases (called "fall-through"), which is almost never what you want in C#.
  - Always use `break` at the end of each case unless you have a special reason to let execution continue to the next case.

---

**Why Flat, Not Deep?**
- Avoid “pyramid of doom” (deeply nested if/else)
- Write code that’s easy to read and debug
  - Example (bad):
    ```csharp
    if (a)
    {
        if (b)
        {
            if (c)
            {
                // hard to read
            }
        }
    }
    ```
  - Example (good):
    ```csharp
    if (a && b && c)
    {
        // much clearer
    }
    ```

---

**Practical:**
- Practice writing your own `if`, `if/else`, and `if/else if/else` statements to make decisions in your code.
- Try using a `switch` statement to handle multiple possible values for a variable, like days of the week or menu choices.
- Experiment with different conditions and see how changing the order affects which block runs.
- Use meaningful messages in your output to make your code easy to understand and debug.
- Remember: clear, flat code is easier to read and maintain than deeply nested logic.

---

## References
- [C# Programming Guide: Control Flow](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/control-flow/)
- [C# Programming Guide: Statements, Expressions, and Operators](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/)
- [C# Language Reference: Statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

