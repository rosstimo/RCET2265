# Errors & Troubleshooting in C#

Different failures require different responses. Start by identifying what kind of problem you have.

## Compiler errors

The program cannot be built successfully.

```csharp
int count = "five";    // incompatible types
Console.WriteLine(x);   // x was never declared
```

Read the compiler diagnostic and fix the earliest meaningful error first. One syntax error can cause many later messages.

## Runtime exceptions

An exception reports a problem detected while the program is running:

```csharp
int[] values = { 10, 20, 30 };
Console.WriteLine(values[5]);  // IndexOutOfRangeException
```

An **unhandled** exception stops normal execution. An exception can also be caught when the program has a useful recovery or reporting action.

## Logic errors

The program builds and runs but produces the wrong result:

```csharp
int total = 10;
int count = 4;
double average = total / count;   // 2, converted to 2.0
```

The intended result was probably `2.5`, so at least one operand must participate in floating-point division.

## Course style violations

Code can be legal C# and still violate an RCET 2265 naming, formatting, documentation, or project-structure requirement. These are course-quality issues, not compiler errors.

## Troubleshooting sequence

1. Read the diagnostic completely.
2. Identify the file and line involved.
3. Reproduce the problem consistently.
4. Inspect the actual values with the debugger.
5. Change one cause at a time.
6. Test again, including edge cases.
7. Consult official documentation for unfamiliar behavior.

## References

- [C# compiler messages](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/)
- [Exceptions and exception handling](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/)
- [Use breakpoints in Visual Studio](https://learn.microsoft.com/en-us/visualstudio/debugger/using-breakpoints)
