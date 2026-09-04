# Getting Started & Console Fundamentals

Console programs are a convenient place to learn sequencing, variables, input, output, conversion, and debugging without adding a graphical interface.

## Output

```csharp
Console.WriteLine("Hello, world!");
Console.Write("Enter your name: ");
```

`WriteLine` ends the output with a new line. `Write` does not.

## Input

`Console.ReadLine()` returns text entered by the user. In nullable-enabled projects, the return type is `string?` because input can end without producing a line.

```csharp
Console.Write("Enter your name: ");
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");
```

When you need a number, validate the text rather than assuming the conversion will work:

```csharp
Console.Write("Enter a whole number: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Twice that number is {number * 2}.");
}
else
{
    Console.WriteLine("That was not a valid whole number.");
}
```

## Running and debugging

Run the actual console application and watch its console/terminal output. In Visual Studio, F5 starts with debugging and Ctrl+F5 starts without debugging. A breakpoint lets you stop before a statement executes and inspect the current values.

Do not add a meaningless `Console.ReadLine()` solely because a launch environment closes a terminal window. Learn how your IDE launches console applications and pause only when the program itself needs input.

## Platform note

Methods such as `Console.Beep()` depend on operating-system support. They are demonstrations, not portable program behavior you should rely on.

## References

- [System.Console API](https://learn.microsoft.com/en-us/dotnet/api/system.console)
- [Use breakpoints in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/debugger/using-breakpoints)
