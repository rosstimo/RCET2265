# Static Members in C#

A static member belongs to the **type** rather than to one particular object.

## Static field example

```csharp
Counter first = new();
Counter second = new();

Console.WriteLine(Counter.TotalCreated);  // 2

class Counter
{
    private static int _totalCreated;

    public static int TotalCreated => _totalCreated;

    public Counter()
    {
        _totalCreated++;
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

## References

- [Static classes and static class members](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members)
- [RCET 2265 Style Guide: Naming](../StyleGuide/README.md#naming)
