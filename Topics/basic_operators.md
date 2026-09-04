# Basic Operators in C#

Operators combine values into expressions. Early C# work uses arithmetic, assignment, comparison, and Boolean operators constantly.

## Arithmetic

```csharp
int a = 9;
int b = 4;

Console.WriteLine(a + b);  // 13
Console.WriteLine(a - b);  // 5
Console.WriteLine(a * b);  // 36
Console.WriteLine(a / b);  // 2: integer division
Console.WriteLine(a % b);  // 1: remainder
```

When both operands are integral types, `/` performs integer division. Use an appropriate floating-point operand when you need a fractional result:

```csharp
double result = 9.0 / 4;
Console.WriteLine(result);  // 2.25
```

## Assignment

```csharp
int count = 5;
count += 2;  // 7
count *= 3;  // 21
count -= 1;  // 20
```

`=` assigns a value. It is not the equality operator.

## Comparison

```csharp
int score = 85;

bool isPassing = score >= 60;
bool isPerfect = score == 100;
bool isNotZero = score != 0;
```

Comparison expressions produce `bool` values.

## Boolean operators

```csharp
int age = 20;
bool hasPermit = false;

bool canEnter = age >= 18;
bool canDrive = age >= 16 || hasPermit;
bool isBlocked = !canEnter;
```

`&&` means AND, `||` means OR, and `!` negates a Boolean value.

## Precedence

```csharp
int first = 3 + 4 * 2;       // 11
int second = (3 + 4) * 2;    // 14
```

Use parentheses when they make the intended grouping easier to read.

## References

- [C# operators](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/expressions/operators)
- [C# language reference: operators](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/)
