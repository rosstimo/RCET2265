# Basic Operators in C#

## Introduction

Operators are special symbols or keywords in C# that let you perform calculations, compare values, and work with data. You use operators every time you add numbers, check if something is true, or join strings together. Learning how operators work is essential for writing clear, correct code.

This section covers the most common operators you'll use as a beginner, with simple examples and explanations for each type.

## 4. Basic Operators

- **Arithmetic Operators:**
  - `+` (addition), `-` (subtraction), `*` (multiplication), `/` (division), `%` (modulus, remainder)
  - Examples:
    ```csharp
    int sum = 5 + 3;      // 8
    double result = 7.0 / 2; // 3.5
    int rem = 9 % 4;      // 1
    int product = 4 * 6;  // 24
    int difference = 10 - 2; // 8
    ```

- **Assignment Operators:**
  - `=` (assign), `+=`, `-=`, `*=`, `/=`, `%=` (shorthand for changing value)
  - Examples:
    ```csharp
    int count = 1;
    count += 5; // count is now 6
    count *= 2; // count is now 12
    count -= 4; // count is now 8
    count /= 2; // count is now 4
    count %= 3; // count is now 1
    ```

- **Comparison Operators:**
  - `==` (equal), `!=` (not equal), `<`, `>`, `<=`, `>=`
  - Used in conditions, returns bool.
    ```csharp
    int score = 85;
    bool isSame = (score == 10);      // false
    bool isHigh = (score >= 90);      // false
    bool isPassing = (score >= 60);   // true
    bool isNotZero = (score != 0);    // true
    bool isLow = (score < 50);        // false
    ```

- **Logical Operators:**
  - `&&` (and), `||` (or), `!` (not)
  - Used to combine or invert boolean values.
    ```csharp
    bool isCitizen = true;
    int age = 20;
    bool canVote = (age >= 18) && isCitizen; // true
    bool notReady = !isCitizen;              // false
    bool canDrive = (age >= 16) || hasPermit; // true if age >= 16 or hasPermit is true
    ```

- **String Concatenation:**
  - `+` to join strings: `"Sheila" + " " + "Rocks!"`
  - Use interpolation for readable code: `$"Name: {name}, Age: {age}"`
  - Example:
    ```csharp
    string name = "Sheila";
    int age = 30;
    string message = name + " is " + age + " years old.";
    string info = $"Name: {name}, Age: {age}";
    ```

- **Operator Precedence:**
  - Order matters! Use parentheses to group calculations if unsure.
  - Example: `3 + 4 * 2` is 11, not 14.
  - Cheat code: `(3 + 4) * 2` is 14.
  - Example:
    ```csharp
    int result1 = 3 + 4 * 2;      // 11
    int result2 = (3 + 4) * 2;    // 14
    ```

- **Why it Matters:**
  - Know your operators = less debugging hell, fewer “why is this wrong?!” moments.
  - Good code reads like math you actually understand.

---

**Practical:**
- Practice using arithmetic, assignment, comparison, and logical operators in your own code.
- Try combining operators to solve simple math and logic problems.
- Use string concatenation and interpolation to build readable output messages.
- Experiment with operator precedence by adding parentheses and seeing how results change.

---

## References
- [C# Programming Guide: Operators and Expressions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/)
- [C# Language Reference: Operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [StyleGuide/NamingConventions.md](../StyleGuide/NamingConventions.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

