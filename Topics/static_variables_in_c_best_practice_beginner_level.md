# Static Members in C#

A static member belongs to the **type** rather than to one particular object.

## Static field example

```csharp
Counter first = new();
Counter second = new();

Console.WriteLine(Counter.TotalCreated);  // 2

class Counter
{
    private static int s_totalCreated;

    public static int TotalCreated => s_totalCreated;

    public Counter()
    {
        s_totalCreated++;
    }
}
```

Each `Counter` object has its own instance state, but every object shares the same static field.

## Access

Access static members through the type name when they are accessible:

```csharp
Console.WriteLine(Counter.TotalCreated);
```

A `private` static field can only be accessed from within its containing type. Making a field static does not make it public.

## Static methods

A static method can be useful when an operation does not require a particular object's instance state. `Math.Sqrt` is a familiar example.

## Static locals

C# does not support C-style or VB-style static local variables inside methods. Persistent shared state belongs in an appropriate field or object design.

## Course naming

The course style guide may use a distinct convention for private static fields. Follow the course guide for graded work.

## References

- [Static classes and static class members](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
- [Naming Conventions](../StyleGuide/NamingConventions.md)
