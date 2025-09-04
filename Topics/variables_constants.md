## 5. Variables & Constants

- **Declaring Variables:**
  - Syntax: `type variableName = value;`
    - Examples: `int count = 0;`, `string name = "Sheila";`, `bool isActive = true;`
  - Always use a clear, descriptive name. Avoid: `x`, `tmp`, `a1` (unless it’s a loop index).
  - **Declare variables and constants at the top of their local method or scope for clarity.**
    - This makes it easy to find all declarations and avoids hunting through code.
  - You can declare multiple variables of the same type in one line: `int a = 1, b = 2;`
  - Example:
    ```csharp
    void ShowStudentInfo()
    {
        // Variable declarations at the top
        int age = 25;
        string firstName = "Alex";
        double temperature = 98.6;
        bool isStudent = true;
        int a = 1, b = 2, c = 3;

        // Other code using the variables
        Console.WriteLine($"Name: {firstName}, Age: {age}");
        Console.WriteLine($"Temperature: {temperature}");
        Console.WriteLine($"Is student: {isStudent}");
        Console.WriteLine($"a + b + c = {a + b + c}");
    }
    ```

- **Explicit Typing:**
  - For beginners, always use the actual type (`int`, `string`, etc.), not `var`.
    - Example: `double price = 19.99;` (not `var price = 19.99;`)
  - `var` is for advanced/when the type is obvious, like in LINQ queries.
  - Sometimes using `var` makes code less clear, especially when the type is not obvious:
    ```csharp
    var result = Calculate(); // What type is result?
    var data = GetData();     // Is data a string, a list, or something else?
    ```
    - In these cases, prefer explicit types:
    ```csharp
    int result = Calculate();
    List<string> data = GetData();
    ```
  - See: [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md) for explicit typing rules in this course.

- **Variable Initialization:**
  - Always initialize if possible. Uninitialized = unpredictable bugs.
    - Example: `int score = 0;` (not just `int score;`)
  - If you don't assign a value, C# gives a default (e.g., `0` for `int`, `false` for `bool`), but it's best to be explicit.

- **Scope:**
  - Local: Only lives inside `{}` where declared.
    - Example:
      ```csharp
      void PrintName() {
          string name = "Sheila";
          Console.WriteLine(name);
      }
      // 'name' only exists inside PrintName
      ```
  - Class-level (fields): Declared in a class, used by any method in that class.
    - Example:
      ```csharp
      class Person {
          int age; // field
          void SetAge(int newAge) { age = newAge; }
      }
      ```
  - Shadowing: Never reuse a variable name in nested scopes.
    - Example (avoid this):
      ```csharp
      int value = 5;
      {
          int value = 10; // confusing, don't do this
      }
      ```

- **Lifetime:**
  - Local variables exist only during the method execution.
    - Example: Once a method finishes, its local variables disappear.
  - Class-level fields exist as long as the class instance exists.
    - Example: `Person p = new Person();` — `p.age` exists as long as `p` does.

- **Constants:**
  - Syntax: `const type NAME = value;`
    - Example: `const int MAX_SCORE = 100;`
  - Naming: Use ALL_CAPS for constant names, as required by the course style guide.
    - Example: `const double PI = 3.14159;`
  - Purpose: Use constants for values that never change. Avoid "magic numbers" (unnamed values) in your code.
    - Example (bad): `if (score > 100) ...` (should use `MAX_SCORE`)
    - Example (good): `if (score > MAX_SCORE) ...`
  - Constants must be assigned a value when declared and cannot be changed later.
    - Example:
      ```csharp
      const int DAYS_IN_WEEK = 7;
      // DAYS_IN_WEEK = 8; // Error: cannot change a constant
      ```
  - Constants are always static and shared across all instances of a class.
  - See: [StyleGuide/NamingConventions.md](../StyleGuide/NamingConventions.md) for naming and usage rules for constants in this course.

- **Good Habits:**
  - Use variables for meaning, not just to store a number.
    - Example: `int numberOfStudents` is better than `int n`.
  - Delete dead code and unused variables.
  - If you’re not sure what a variable is for, fix your code until it’s obvious.

- **Why it Matters:**
  - Good variables = easy to read, easy to debug, easy to upgrade later.
  - Constants = less pain when requirements change.
  - Clear code helps you and others avoid mistakes and makes programs easier to maintain.

---

## References

- [C# Language Reference: Variables](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables)
- [C# Language Reference: Constants](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables#93-default-values)
- [C# Programming Guide: Variables](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/variables/)
- [C# Programming Guide: Constants](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/constants/)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)

