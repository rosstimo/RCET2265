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

`PrintGreeting` performs a task but does not return a value to the caller.

## A method that returns a value

```csharp
static int Add(int first, int second)
{
    return first + second;
}

int sum = Add(3, 4);
Console.WriteLine(sum);
```

Because `Add` returns an `int`, the method call can be used anywhere an `int` expression is valid:

```csharp
Console.WriteLine(Add(3, 4));
```

## Parameters and arguments

A **parameter** is declared in the method definition. An **argument** is the value or expression supplied by the caller.

```csharp
static void PrintGreeting(string name) // name is a parameter
{
    Console.WriteLine($"Hello, {name}!");
}

PrintGreeting("Ada"); // "Ada" is an argument
```

C# passes arguments **by value by default**.

- For a value type such as `int`, the method receives a copy of the value.
- For a reference type such as a class instance, the method receives a copy of the reference. Both references can refer to the same object, so the method can modify that object's members.

`ref`, `out`, `in`, and `ref readonly` change parameter passing rules. RCET 2265 mainly uses normal value parameters first, then introduces the others when there is a reason for them.

## Why the early examples use `static`

The course console-project template uses a `static Main` method. The early helper methods are also `static` so `Main` can call them directly without first creating an object instance.

A `static` method is still a member of its containing type. It belongs to the type itself rather than to one particular object instance.

We will revisit instance methods after objects/classes are introduced in more depth.

## Scope and lifetime

Variables declared inside a method are local to the appropriate block. Parameters are local to the method call. Blocks can be nested, so an inner block can normally use names from an enclosing scope when the language rules allow it.

A local declared in one method is not automatically available inside a separate method:

```csharp
static void Main(string[] args)
{
    int value = 7;
    value = ChangeMy(value);
    Console.WriteLine(value);
}

static int ChangeMy(int value)
{
    value += 5;
    return value;
}
```

The `value` parameter inside `ChangeMy` is a different local variable from the `value` local in `Main`. Because `int` is passed by value, the caller changes only when the returned value is explicitly assigned back.

**Scope** answers where a name can be used. **Lifetime** answers how long the corresponding value/storage remains alive during execution. They are related but are not the same concept.

Fields belong to an object or a type and therefore can have a different lifetime from local variables.

## Overloading

Methods can share a name when their parameter lists differ:

```csharp
static int Add(int a, int b) => a + b;
static double Add(double a, double b) => a + b;
```

## Optional depth: recursion

Recursion is useful for understanding method calls more deeply, even though it is not required for the core RCET 2265 assignments every semester. When class pace allows, we may use a small recursive example.

A recursive method calls itself and must have a termination condition so the calls eventually stop:

```csharp
static void CountDown(int value)
{
    if (value <= 0)
    {
        Console.WriteLine("Done");
        return;
    }

    Console.WriteLine(value);
    CountDown(value - 1);
}

CountDown(3);
```

Output:

```text
3
2
1
Done
```

Trace it as a sequence of method calls rather than treating recursion as magic. Each call gets its own parameter/local state, and each unfinished call waits for the deeper call to return.

## References

- [Methods](https://learn.microsoft.com/en-us/dotnet/csharp/methods)
- [`static` modifier](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static)
- [Method parameters and modifiers](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/method-parameters)
- [C# scope rules](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/basic-concepts#77-scopes)
