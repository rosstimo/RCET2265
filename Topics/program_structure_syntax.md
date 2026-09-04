# Program Structure & Syntax in C#

A C# program is built from statements, expressions, methods, types, and namespaces. Modern C# supports more than one valid program shape, so it is useful to recognize both the compact form and the explicit `Main` form.

## Top-level statements

New console projects can place executable statements directly in `Program.cs`:

```csharp
Console.WriteLine("Hello, world!");
```

The compiler supplies the entry-point machinery. Only one source file in a project can contain top-level statements.

## Explicit `Main` method

The same idea can be written with an explicit entry point:

```csharp
namespace HelloWorld;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, world!");
    }
}
```

RCET examples may use an explicit `Program` class and `Main` method when seeing the structure helps explain scope, methods, and classes. Top-level statements are still valid C#.

## Statements and expressions

An expression produces a value:

```csharp
3 + 4
Math.Max(10, 20)
```

A statement performs an action:

```csharp
int total = 3 + 4;
Console.WriteLine(total);
```

## Comments

```csharp
// Single-line comment

/*
   Multi-line comment
*/
```

Comments should add information that the code itself does not make obvious. Course-specific commenting requirements are in the style guide.

## References

- [General structure of a C# program](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/)
- [Top-level statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements)
- [Code Layout and Structure](../StyleGuide/CodeLayoutAndStructure.md)
- [Commenting](../StyleGuide/Commenting.md)
