# Professionalism, Documentation & Habits

Readable code and a recoverable project history are part of the work, not decoration added after the program works.

## Comments

Use comments when they add information that is not obvious from the code. Good comments often explain intent, constraints, assumptions, or a reason for a non-obvious choice.

Avoid comments that merely repeat the statement:

```csharp
count++; // increment count
```

Course assignments may require file headers or XML documentation comments. Follow the assignment and the [RCET 2265 Style Guide: Comments](../StyleGuide/README.md#comments).

## Naming and formatting

Use descriptive names and consistent formatting. Course rules are documented in the Style Guide:

- [Naming](../StyleGuide/README.md#naming)
- [Indentation and Braces](../StyleGuide/README.md#indentation-and-braces)
- [Spacing](../StyleGuide/README.md#spacing)

## Git

Commit useful project states. Push regularly enough that loss of the local machine does not mean loss of the assignment.

Before committing:

```text
build -> test -> git status -> review changes -> commit
```

## Before submission

- build from a clean state
- test required behavior and edge cases
- remove temporary/debug-only output
- review repository contents
- confirm naming and project structure
- read the assignment/rubric again
- push the final commit required for grading

## Getting technical help

When asking for help, provide:

- the exact error or incorrect behavior
- the relevant code
- what you expected
- what actually happened
- what you already tested

Use Microsoft Learn and the .NET API browser instead of relying on random copied snippets with no source context.

## References

- [C# documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET API browser](https://learn.microsoft.com/en-us/dotnet/api/)
- [Git Best Practices](../StyleGuide/GitBestPractices.md)
