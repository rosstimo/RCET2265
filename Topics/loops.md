# Loops in C#

Loops repeat a statement or block. Choose the loop form that makes the stopping condition and the data being processed easy to see.

## `for`

Useful when the loop has an index or a clear counter:

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}
```

## `foreach`

Useful when you want each element in a collection and do not need to manage an index manually:

```csharp
string[] names = { "Ada", "Grace", "Linus" };

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

## `while`

Tests the condition before each iteration:

```csharp
int number = 1;

while (number <= 3)
{
    Console.WriteLine(number);
    number++;
}
```

## `do` / `while`

Runs the body once before testing the condition:

```csharp
int tries = 0;

do
{
    tries++;
    Console.WriteLine($"Try {tries}");
}
while (tries < 3);
```

## `break` and `continue`

- `break` exits the nearest loop.
- `continue` skips the rest of the current iteration and begins the next one.

Use them deliberately. A loop is easier to debug when its termination behavior is obvious.

## Common mistakes

- off-by-one bounds
- forgetting to update a `while` condition
- using `<= collection.Length` instead of `< collection.Length` for a zero-based index
- modifying a collection in an invalid way during `foreach`

## References

- [Iteration statements](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements)
