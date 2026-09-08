# File I/O in C#

File input/output lets a program preserve data outside the running process. RCET 2265 begins with text files and path handling.

## Simple whole-file operations

```csharp
File.WriteAllText("output.txt", "Hello, file!");
string text = File.ReadAllText("output.txt");
Console.WriteLine(text);
```

For multiple lines:

```csharp
string[] lines = { "first", "second", "third" };
File.WriteAllLines("output.txt", lines);

string[] loaded = File.ReadAllLines("output.txt");
```

## Append

```csharp
File.AppendAllText("log.txt", "Program started\n");
```

## StreamReader and disposal

Use a `using` statement or declaration so resources are disposed correctly:

```csharp
using StreamReader reader = new("data.txt");

string? line;
while ((line = reader.ReadLine()) is not null)
{
    Console.WriteLine(line);
}
```

## Paths

Use `Path.Combine` rather than manually inserting directory separators:

```csharp
string path = Path.Combine("data", "measurements.txt");
```

Relative paths are resolved from the process's current working directory. Do not assume that is always the project source folder.

## Exception handling

File operations can fail for many reasons, including missing files, permission problems, invalid paths, and unavailable devices. Catch an exception when the program has a meaningful response. Do not add `try/catch` around every file operation merely to suppress errors.

## Windows Forms file dialogs

When a GUI needs the user to choose a path, `OpenFileDialog` and `SaveFileDialog` are often appropriate. They select a path; the program still performs the file operation.

## References

- [`System.IO.File` API](https://learn.microsoft.com/en-us/dotnet/api/system.io.file)
- [`System.IO.Path` API](https://learn.microsoft.com/en-us/dotnet/api/system.io.path)
- [`StreamReader` API](https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader)
