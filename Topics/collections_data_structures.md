# Collections & Data Structures in C#

## Introduction

Collections and data structures let you store, organize, and work with groups of data in your programs. They are essential for everything from simple lists to complex databases. This section covers the most common types: arrays, lists, dictionaries, stacks, and queues, with examples for each.

---

**Arrays:**
- Declare, initialize, access values
  - Example:
    ```csharp
    int[] numbers = {1, 2, 3, 4};
    Console.WriteLine(numbers[0]); // 1
    ```
- Loop through: `for`, `foreach`
  - Example:
    ```csharp
    foreach (int n in numbers)
    {
        Console.WriteLine(n);
    }
    ```
- Zero-based index, common bugs
  - Remember: first item is at index 0
- Multi-dimensional arrays (optional, demo)
  - Example:
    ```csharp
    int[,] grid = new int[2, 2];
    grid[0, 0] = 1;
    grid[1, 1] = 2;
    ```

---

**Lists (`List<T>`):**
- Dynamic size: `.Add()`, `.Remove()`, `.Count`
  - Example:
    ```csharp
    List<string> names = new List<string>();
    names.Add("Sheila");
    names.Add("Alex");
    Console.WriteLine(names.Count); // 2
    names.Remove("Alex");
    ```
- Convert between arrays and lists
  - Example:
    ```csharp
    string[] arr = {"a", "b"};
    List<string> list = new List<string>(arr);
    ```
- Iterating with `foreach`
  - Example:
    ```csharp
    foreach (string name in names)
    {
        Console.WriteLine(name);
    }
    ```

---

**Dictionaries:**
- Key/value pairs: `Dictionary<string, int>`
  - Example:
    ```csharp
    Dictionary<string, int> ages = new Dictionary<string, int>();
    ages["Sheila"] = 30;
    ages["Alex"] = 25;
    Console.WriteLine(ages["Sheila"]); // 30
    ```
- Add, lookup, remove, `.ContainsKey`, `.TryGetValue`
  - Example:
    ```csharp
    if (ages.ContainsKey("Alex"))
    {
        Console.WriteLine("Alex is in the dictionary.");
    }
    ages.Remove("Alex");
    int value;
    if (ages.TryGetValue("Sheila", out value))
    {
        Console.WriteLine($"Sheila's age is {value}");
    }
    ```
- Real uses: phonebook, lookup table, word counter

---

**Stack & Queue:**
- Stack (LIFO): `.Push()`, `.Pop()`, `.Peek()`
  - Example:
    ```csharp
    Stack<int> stack = new Stack<int>();
    stack.Push(1);
    stack.Push(2);
    Console.WriteLine(stack.Pop()); // 2
    Console.WriteLine(stack.Peek()); // 1
    ```
- Queue (FIFO): `.Enqueue()`, `.Dequeue()`, `.Peek()`
  - Example:
    ```csharp
    Queue<string> queue = new Queue<string>();
    queue.Enqueue("First");
    queue.Enqueue("Second");
    Console.WriteLine(queue.Dequeue()); // First
    Console.WriteLine(queue.Peek()); // Second
    ```
- Use cases: Undo/redo, print jobs, simulation

---

**Why it Matters:**
- Data structures = how you actually do anything useful with code
- Choosing the right tool makes code shorter, clearer, faster

---

**Practical:**
- Practice creating and using arrays, lists, dictionaries, stacks, and queues.
- Try looping through collections and accessing their elements.
- Experiment with adding, removing, and looking up values.
- Think about which data structure fits your problem best.

---

## References
- [C# Programming Guide: Arrays](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/)
- [C# Programming Guide: Collections](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections/)
- [C# Programming Guide: Dictionaries](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections/dictionary-collection)
- [C# Programming Guide: Stack and Queue](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections/stack-queue)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

