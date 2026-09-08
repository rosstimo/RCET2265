# Math & the `Math` Class

C# uses normal arithmetic operators for basic calculations and the `System.Math` class for common mathematical functions.

## Arithmetic and integer division

```csharp
int total = 5 + 2 * 5;       // 15
int whole = 5 / 2;           // 2
double fraction = 5.0 / 2;   // 2.5
```

Integer division discards the fractional part by truncating toward zero.

## `Math` examples

```csharp
Console.WriteLine(Math.Abs(-3.5));
Console.WriteLine(Math.Pow(2, 3));
Console.WriteLine(Math.Sqrt(16));
Console.WriteLine(Math.Round(2.718, 2));
Console.WriteLine(Math.Min(5, 10));
Console.WriteLine(Math.Max(5, 10));
```

C# does **not** have an exponentiation operator. Exponentiation is normally performed with a method such as `Math.Pow`.

## Random numbers are a separate API

`Random` is not part of the `Math` class:

```csharp
Random random = new();
int dieRoll = random.Next(1, 7);
Console.WriteLine(dieRoll);
```

The upper bound passed to `Next(min, max)` is exclusive, so `Next(1, 7)` produces values 1 through 6.

## Order of evaluation

Do not rely on a memorized “PEMDAS” slogan to explain every C# expression. Learn operator precedence and use parentheses to make grouping explicit when it improves readability.

## References

- [C# operators](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/expressions/operators)
- [`System.Math` API](https://learn.microsoft.com/en-us/dotnet/api/system.math)
- [`System.Random` API](https://learn.microsoft.com/en-us/dotnet/api/system.random)
