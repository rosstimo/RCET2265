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

## Numeric size and range quick reference

The fixed-size integer types are useful when you need to know exactly how many bits a value occupies.

| C# type | Size | Range |
|---|---:|---:|
| `sbyte` | 8 bits | -128 to 127 |
| `byte` | 8 bits | 0 to 255 |
| `short` | 16 bits | -32,768 to 32,767 |
| `ushort` | 16 bits | 0 to 65,535 |
| `int` | 32 bits | -2,147,483,648 to 2,147,483,647 |
| `uint` | 32 bits | 0 to 4,294,967,295 |
| `long` | 64 bits | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| `ulong` | 64 bits | 0 to 18,446,744,073,709,551,615 |

For floating-point and decimal types:

| C# type | Size | Approximate range | Precision |
|---|---:|---:|---:|
| `float` | 32 bits | ±1.5 × 10^-45 to ±3.4 × 10^38 | about 6-9 digits |
| `double` | 64 bits | ±5.0 × 10^-324 to ±1.7 × 10^308 | about 15-17 digits |
| `decimal` | 128 bits | ±1.0 × 10^-28 to ±7.9228 × 10^28 | 28-29 digits |

You do not need to memorize every range. Know the common types, know that integer types have fixed widths, and know where to look up the exact limits when they matter. Types such as `int` also expose constants such as `int.MinValue` and `int.MaxValue`.

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

- [Integral numeric types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
- [Floating-point numeric types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types)
- [Value types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)
- [Reference types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)
- [Built-in reference types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/reference-types)
