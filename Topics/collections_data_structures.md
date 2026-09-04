# Collections & Data Structures in C#

Collections store groups of values. The useful question is not “which collection is best?” but “what operations does this problem need?”

## Arrays

Arrays have a fixed length and use zero-based indexes:

```csharp
int[] measurements = { 10, 20, 30 };
Console.WriteLine(measurements[0]);
Console.WriteLine(measurements.Length);
```

## `List<T>`

A `List<T>` can grow and shrink:

```csharp
List<string> names = new();
names.Add("Ada");
names.Add("Grace");
names.Remove("Ada");

foreach (string name in names)
{
    Console.WriteLine(name);
}
```

## `Dictionary<TKey,TValue>`

A dictionary associates keys with values:

```csharp
Dictionary<string, int> scores = new();
scores["Ada"] = 95;
scores["Grace"] = 98;

if (scores.TryGetValue("Ada", out int score))
{
    Console.WriteLine(score);
}
```

Use `TryGetValue` when a key might not be present.

## Stack and queue

A `Stack<T>` is last-in, first-out. A `Queue<T>` is first-in, first-out.

```csharp
Stack<int> stack = new();
stack.Push(10);
stack.Push(20);
Console.WriteLine(stack.Pop());   // 20

Queue<int> queue = new();
queue.Enqueue(10);
queue.Enqueue(20);
Console.WriteLine(queue.Dequeue()); // 10
```

## Selection questions

Ask:

- Is the size fixed or changing?
- Do I access by numeric index or by a key?
- Does insertion/removal order matter?
- Do I need LIFO or FIFO behavior?

## References

- [Collections](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/collections)
- [`List<T>` API](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1)
- [`Dictionary<TKey,TValue>` API](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2)
- [`Stack<T>` API](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.stack-1)
- [`Queue<T>` API](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.queue-1)
