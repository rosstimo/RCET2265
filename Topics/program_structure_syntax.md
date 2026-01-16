# Program Structure & Syntax in C#

## Introduction

Understanding the structure and syntax of a C# program is essential for writing clear, maintainable code. This section explains the anatomy of a C# program, including namespaces, classes, the Main method, and commenting best practices.

---

**Anatomy of a C# Program:**
- **Namespace:**
  - Organizes code and prevents name collisions.
  - Example:
    ```csharp
    namespace HelloWorld {
        class Program {
            static void Main(string[] args) {
                // code here
            }
        }
    }
    ```
- **Class:**
  - The building block of C# programs. All code lives in classes.
- **Main Method:**
  - The entry point for console apps: `static void Main(string[] args)` or `static void Main()`
  - For GUIs, entry is handled for you, but still inside a class.

---

**Comments:**
- Use `//` for single-line comments and `/* ... */` for multi-line comments.
- Explain the "why" and "what"—not just the "how".
- Example:
  ```csharp
  // Print a welcome message to the user.
  Console.WriteLine("Welcome!");
  /*
   * Loop through all students and print their names.
   * This is a multi-line comment explaining a block of code.
   */
  for (int i = 0; i < students.Length; i++)
  {
      Console.WriteLine(students[i]);
  }
  ```

---

**Practical:**
- Create a simple console app with a namespace, class, and Main method.
- Practice writing clear comments that explain your code.

---

## References
- [C# Programming Guide: Program Structure](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/program-structure)
- [C# Programming Guide: Comments](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/comments)
- [StyleGuide/CodeLayoutAndStructure.md](../StyleGuide/CodeLayoutAndStructure.md)
- [StyleGuide/Commenting.md](../StyleGuide/Commenting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

