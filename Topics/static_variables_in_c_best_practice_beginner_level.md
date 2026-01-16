## Static Variables in C#: Best Practice (Beginner Level)

## Introduction

Static variables belong to the class itself rather than to any individual object. They hold values that should be shared across all instances, like counters or common settings. This short guide explains when to use static fields, how to name them, and why they matter for beginners.

- **Only use static fields at the class level.**

  - Declare static variables (fields) at the top of your class, outside of any method.
  - Example:
    ```csharp
    public class Example {
        private static int counter = 0;
        public void Increment() {
            counter++;
            Console.WriteLine(counter);
        }
    }
    ```

- **When to use:**

  - When you need a value to be shared by all instances of a class (ex: a counter, a cache, a shared constant).
  - For utility/helper methods (like `Math.Abs()`) that don’t rely on object state.

- **When NOT to use:**

  - If each object/instance should have its *own* value, use a regular (non-static) field instead.
  - Don’t try to create static local variables inside methods—use class-level static fields only.

- **Naming:**

  - Use `camelCase` for private static fields (`private static int callCount`)
  - Use `PascalCase` for public static fields/properties (`public static int MaxValue`)

- **Access:**

  - Access static members using the class name: `Example.counter`
  - Static members can be accessed even if no objects are created.

- **TL;DR:**

  - C# does NOT support static local variables inside methods (unlike VB.NET).
  - For persistent, method-shared state, use a private static field at the class level.
  - Keep it simple. If you’re not sure if it should be static, it probably shouldn’t be!

---

**Practical:**
- Add a static counter field to a class and increment it each time you create a new object.
- Experiment with public and private static fields to see how access works.
- Try removing the `static` keyword and observe how each object keeps its own value.

---

## References
- [C# Programming Guide: Static Classes and Static Class Members](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/NamingConventions.md](../StyleGuide/NamingConventions.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

