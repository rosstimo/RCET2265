# Methods & Functions in C#

In C#, the language term is **method**. In class discussion, “subroutine” may describe a method that returns `void`, while “function” may describe a method that returns a value.

## A method that returns `void`

```csharp
static void PrintGreeting(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

PrintGreeting("Ada");
```

## A method that returns a value

```csharp
static int Add(int first, int second)
{
    return first + second;
}

int sum = Add(3, 4);
Console.WriteLine(sum);
```

## Parameters and arguments

C# passes arguments **by value by default**.

- For a value type such as `int`, the method receives a copy of the value.
- For a reference type such as a class instance, the method receives a copy of the reference. Both references can refer to the same object, so the method can modify that object's members.

`ref`, `out`, `in`, and `ref readonly` change parameter passing rules. RCET 2265 mainly uses normal value parameters first, then introduces the others when there is a reason for them.

## Scope and lifetime

Variables declared inside a method are local to the appropriate block. Parameters are local to the method call. Fields belong to an object or a type and therefore have a different lifetime.

## Overloading

Methods can share a name when their parameter lists differ:

```csharp
static int Add(int a, int b) => a + b;
static double Add(double a, double b) => a + b;
```

## Recursion

Recursion is a useful concept but not a core RCET 2265 requirement unless assigned. A recursive method calls itself and must have a termination condition.

## References

- [Methods](https://learn.microsoft.com/en-us/dotnet/csharp/methods)
- [Method parameters and modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters)
