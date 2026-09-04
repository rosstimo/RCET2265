# Control Flow in C#

Selection statements let a program choose which code should run.

## `if`, `else if`, and `else`

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 80)
{
    Console.WriteLine("B");
}
else
{
    Console.WriteLine("Below B");
}
```

Conditions are tested from top to bottom. In one connected `if` / `else if` / `else` chain, the first true branch runs and the remaining branches are skipped.

## Boolean expressions

```csharp
int age = 20;
bool hasId = true;

if (age >= 18 && hasId)
{
    Console.WriteLine("Entry allowed.");
}
```

## `switch`

```csharp
int menuChoice = 2;

switch (menuChoice)
{
    case 1:
        Console.WriteLine("Open");
        break;
    case 2:
        Console.WriteLine("Save");
        break;
    default:
        Console.WriteLine("Unknown choice");
        break;
}
```

### C# does not implicitly fall through between non-empty cases

Unlike C and C++, C# does not allow execution to continue automatically from one non-empty `case` section into the next. A switch section normally ends with `break`, `return`, `throw`, or another permitted jump statement. Multiple case labels can share one section when they intentionally need the same behavior.

## Ternary conditional operator

The conditional operator is useful for a small expression:

```csharp
int score = 75;
string result = score >= 60 ? "Pass" : "Fail";
```

Do not force complicated control flow into a ternary expression just to make the code shorter.

## References

- [Selection statements](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/statements/selection)
- [`if` and `switch` language reference](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements)
