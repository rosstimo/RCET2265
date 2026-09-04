# Object-Oriented Programming in C#

Object-oriented programming groups data and behavior into types. For RCET 2265, the core ideas are classes, objects, fields, properties, methods, constructors, access control, and organizing a project across source files.

## Class and object

```csharp
Person student = new("Ada");
student.Score = 95;
student.PrintSummary();

class Person
{
    public string Name { get; }
    public int Score { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public void PrintSummary()
    {
        Console.WriteLine($"{Name}: {Score}");
    }
}
```

`Person` is the type. `student` refers to one object created from that type.

## Fields and properties

A field stores data directly in a class. A property exposes an object's state through property syntax and can control reading or writing.

Prefer properties for public state instead of exposing public mutable fields by default.

## Constructors

A constructor initializes a new object:

```csharp
public Person(string name)
{
    Name = name;
}
```

## Access modifiers

The two most important modifiers at this stage are:

- `private`: accessible only within the containing type
- `public`: accessible from code that can access the type

Other modifiers exist and are introduced when needed.

## Static versus instance members

An instance member belongs to an object. A static member belongs to the type itself. See [Static Members](static_variables_in_c_best_practice_beginner_level.md).

## Multiple source files

A project can and should be split into multiple `.cs` files as it grows. A common course structure is one primary class per file. Folder and namespace organization can correspond, but C# does **not** require folders to map to namespaces.

## Inheritance

Inheritance is useful background for later programming courses. It may be demonstrated in RCET 2265, but the priority here is learning to design and use ordinary classes correctly before building inheritance hierarchies.

## References

- [Classes and objects](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/classes)
- [Access modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)
- [Inheritance](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/inheritance)
- [Project Structure](../StyleGuide/ProjectStructure.md)
