# Variables & Constants

A variable gives a value a name and a type. A constant gives a name to a value that is fixed at compile time.

## Declaring and initializing variables

```csharp
int studentCount = 18;
string courseName = "RCET 2265";
bool isComplete = false;
```

### Local variables are not automatically initialized

A local variable starts **unassigned**. C# requires it to be definitely assigned before its value is read:

```csharp
int score;
score = 95;
Console.WriteLine(score);   // valid: score was assigned first
```

This does not compile:

```csharp
int score;
Console.WriteLine(score);   // compiler error: use of unassigned local variable
```

Fields are different. Instance and static fields receive default values if you do not initialize them explicitly.

## Scope

A local variable is available only inside the block where its declaration is valid:

```csharp
if (true)
{
    int count = 3;
    Console.WriteLine(count);
}

// count is not in scope here
```

Fields belong to a type or an instance and therefore have a different lifetime from locals.

## Explicit types and `var`

C# supports both explicit local variable types and `var`:

```csharp
int count = 5;
var otherCount = 5;   // compiler infers int
```

**RCET 2265 course convention:** use explicit types unless specifically instructed otherwise.

## Constants

```csharp
const int MaximumScore = 100;
const double InchesPerFoot = 12.0;
```

A constant must be assigned when declared and cannot later be changed. For class members, constants are treated as static members, but you do not write the `static` modifier with `const`.

**RCET 2265 course convention:** constant names use `PascalCase` as specified in the course style guide.

## References

- [C# language specification: variables](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/variables)
- [Default values of C# types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/default-values)
- [Constants](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants)
- [RCET 2265 Style Guide: Naming](../StyleGuide/README.md#naming)
