# RCET 2265 C# Style Guide

This guide defines the C# coding style used in RCET 2265.

The goal is readable, consistent code while learning programming fundamentals. Some requirements are deliberately more explicit than code you may see elsewhere.

If an assignment gives a specific requirement that differs from this guide, follow the assignment.

## Program Structure

Use an explicit `Program` class and `Main` method.

Do not use top-level statements in RCET 2265 assignments.

```csharp
namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
```

## Variables

Use explicit types.

```csharp
int studentCount;
string userName;
double averageScore;
```

Do not use `var` unless specifically instructed.

Declare the working variables for a method near the beginning of the method. This makes program state easier to identify while learning.

Use descriptive names.

```csharp
string userInput;
int firstNumber;
int secondNumber;
double averageScore;
```

Avoid names that do not explain what a value represents.

```csharp
string x;
int num1;
int stuff;
```

A short loop counter may be named `index` or, when the scope is very small, `i`.

## Naming

| Program element | Style | Example |
| --- | --- | --- |
| Local variable | `camelCase` | `studentCount` |
| Parameter | `camelCase` | `itemCount` |
| Boolean variable | `camelCase`, reads like a condition | `isValid` |
| Constant | `PascalCase` | `MaximumScore` |
| Method | `PascalCase` | `CalculateAverage` |
| Class | `PascalCase` | `StudentRecord` |
| Property | `PascalCase` | `StudentName` |
| Private field | `_camelCase` | `_currentScore` |

Prefer names that describe what a value means rather than its data type.

Use:

```csharp
string customerName;
```

instead of:

```csharp
string strName;
```

## Indentation and Braces

Use four spaces for each indentation level.

Use Allman-style braces. Opening and closing braces are placed on their own lines.

Always use braces for `if`, `else`, loops, and other code blocks.

```csharp
if (score >= 70)
{
    Console.WriteLine("Passing");
}
else
{
    Console.WriteLine("Not passing");
}
```

Do not write:

```csharp
if (score >= 70) Console.WriteLine("Passing");
```

## Spacing

Put spaces around binary operators.

```csharp
total = firstNumber + secondNumber;

if (score >= 70)
{
    Console.WriteLine("Passing");
}
```

Put a space after commas.

Do not add spaces just inside parentheses.

```csharp
CalculateTotal(firstNumber, secondNumber);
```

Write one statement per line and one declaration per line.

```csharp
int firstNumber;
int secondNumber;

firstNumber = 5;
secondNumber = 10;
```

## Blank Lines

Use blank lines to separate meaningful sections of code.

Avoid both large blocks of unrelated statements and excessive blank lines.

## Comments

Comments should help another person understand something that is not obvious from the code.

Good:

```csharp
// Convert the user's input before performing arithmetic.
firstNumber = Convert.ToInt32(userInput);
```

Usually unnecessary:

```csharp
// Add one to count.
count++;
```

Prefer readable code and meaningful names over large numbers of comments.

Do not leave old code commented out in completed assignments. Git preserves previous versions.

## Methods

Method names use `PascalCase`.

Parameters use `camelCase`.

A method name should normally describe an action.

```csharp
static double CalculateAverage(int total, int count)
{
    double average;

    average = (double)total / count;

    return average;
}
```

Use methods when separating part of a program makes the program easier to read, test, or reuse.

## Classes

Class names and property names use `PascalCase`.

Private fields use `_camelCase`.

Put the main class in a source file with the same name.

```text
StudentRecord.cs
```

```csharp
internal class StudentRecord
{
    private int _score;

    public string StudentName { get; set; }
}
```

## Windows Forms

Give controls names that describe both their purpose and control type.

Examples:

```text
CustomerNameTextBox
SubmitButton
ResultsListBox
StatusLabel
```

Do not manually edit generated `*.Designer.cs` files.

Event handlers should remain readable. Move calculations or other substantial program logic into appropriately named methods when that improves the program structure.

## References

- [Microsoft C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Microsoft C# Identifier Naming Rules and Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/identifier-names)
