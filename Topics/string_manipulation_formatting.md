# String Manipulation & Formatting

A `string` represents text. Strings are used for console input, messages, file contents, labels, and many other program values.

## Creation and interpolation

```csharp
string firstName = "Ada";
int score = 92;
string message = $"{firstName} scored {score}.";
Console.WriteLine(message);
```

String interpolation is usually easier to read than long chains of `+` concatenation.

## Common operations

```csharp
string text = "  RCET 2265  ";

Console.WriteLine(text.Trim());
Console.WriteLine(text.ToUpper());
Console.WriteLine(text.Contains("2265"));
Console.WriteLine(text.IndexOf("2265"));
```

Other useful members include `Substring`, `Split`, `Replace`, `StartsWith`, and `EndsWith`.

## Comparing user input

Do not use a substring test when you mean exact input. For example, `Contains("yes")` would also match unrelated words containing those letters.

```csharp
Console.Write("Continue? ");
string? input = Console.ReadLine();

if (string.Equals(input?.Trim(), "yes", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Continuing.");
}
```

## Parsing numbers

Use `TryParse` for normal user-input validation. Invalid input is expected and does not need to become an exception:

```csharp
Console.Write("Enter an integer: ");
string? input = Console.ReadLine();

if (int.TryParse(input, out int value))
{
    Console.WriteLine($"You entered {value}.");
}
else
{
    Console.WriteLine("Invalid integer.");
}
```

## Formatting

Interpolation supports alignment and format specifiers:

```csharp
double voltage = 3.2967;
Console.WriteLine($"Voltage: {voltage:F2} V");
```

## References

- [Strings in C#](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/strings/)
- [String interpolation](https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/strings/interpolation)
- [`System.String` API](https://learn.microsoft.com/en-us/dotnet/api/system.string)
