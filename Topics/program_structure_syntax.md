# Program Structure & Syntax in C#

A C# program is built from statements, expressions, methods, types, and namespaces.

## Program entry point

RCET 2265 console programs use an explicit `Program` class and `Main` method:

```csharp
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
```

The `Main` method is the entry point where program execution begins.

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
- [RCET 2265 Style Guide: Program Structure](../StyleGuide/README.md#program-structure)
- [RCET 2265 Style Guide: Comments](../StyleGuide/README.md#comments)
