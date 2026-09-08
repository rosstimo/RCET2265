# Built-in and Primitive Data Types in C#

The course syllabus uses the phrase **primitive data types**. In C#, Microsoft documentation more precisely distinguishes **value types** and **reference types**. The built-in numeric types, `bool`, and `char` are value types. `string` is a built-in **reference type**.

## Common types for this course

| C# type | Category | Typical use |
|---|---|---|
| `int` | value type | whole-number counts and indexes |
| `double` | value type | general floating-point calculations |
| `decimal` | value type | decimal values where base-10 precision matters, especially money |
| `float` | value type | 32-bit floating point when that format is specifically needed |
| `bool` | value type | `true` / `false` state |
| `char` | value type | one UTF-16 code unit |
| `string` | reference type | text |

Examples:

```csharp
int studentCount = 18;
double voltage = 3.3;
decimal price = 19.99m;
bool isEnabled = true;
char grade = 'A';
string course = "RCET 2265";
```

## Integral types

C# includes signed and unsigned integer types such as `sbyte`, `byte`, `short`, `ushort`, `int`, `uint`, `long`, and `ulong`. Choose a type because its meaning and range fit the data, not merely because a smaller type uses fewer bytes.

## Floating-point values are approximate

`float` and `double` use binary floating-point representation. Many decimal fractions cannot be represented exactly. Do not assume that every decimal-looking value is stored exactly.

`decimal` uses a decimal representation and is usually the appropriate choice for financial values.

## Strings are not numbers

User input from `Console.ReadLine()` is text. Convert only after validating it:

```csharp
string? input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    Console.WriteLine(number * 2);
}
```

## Value versus reference behavior

For value types, assignment copies the value. For reference types, assignment copies a reference to an object. That distinction becomes important when you work with objects and method parameters later in the course.

## References

- [Value types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)
- [Reference types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)
- [Floating-point numeric types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)
- [Built-in reference types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types)
