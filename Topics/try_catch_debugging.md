# Exceptions & Debugging

Exception handling and debugging solve different problems. Debugging helps you understand program state and find defects. Exception handling defines what a program does when a runtime operation reports an exceptional condition.

## Prefer validation for expected input

Invalid user input is normal. Use `TryParse` rather than throwing and catching an exception for routine validation:

```csharp
Console.Write("Enter an integer: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine(number * 2);
}
else
{
    Console.WriteLine("Please enter a valid integer.");
}
```

## `try` and `catch`

Catch an exception when you can respond meaningfully and leave the program in a known state.

```csharp
try
{
    string text = File.ReadAllText("settings.txt");
    Console.WriteLine(text);
}
catch (FileNotFoundException)
{
    Console.WriteLine("settings.txt was not found.");
}
```

Avoid a broad `catch (Exception)` that merely hides the problem.

## Read the exception information

When debugging an exception, inspect:

- exception type
- message
- source line
- stack trace
- relevant variable values

## Debugger workflow

1. Set a breakpoint before the suspicious statement.
2. Run under the debugger.
3. Inspect local variables.
4. Step over or into statements.
5. Compare actual state with the state you expected.
6. Fix the cause, not merely the symptom.

## References

- [Exceptions and exception handling](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/)
- [Exception-handling statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/exception-handling-statements)
- [Use breakpoints in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/debugger/using-breakpoints)
