# File I/O in C#

## Introduction

File I/O (input/output) lets your programs read and write data to files. This is how you save user input, load settings, and work with real-world data. This section covers the basics of reading and writing text files, handling file paths, and using dialogs in GUIs.

---

**Text Files (Beginner Focus):**
- `File.ReadAllText`, `File.ReadAllLines`: read file contents into string/array
  - Example:
    ```csharp
    string text = File.ReadAllText("data.txt");
    string[] lines = File.ReadAllLines("data.txt");
    ```
- `File.WriteAllText`, `File.WriteAllLines`: write (overwrite) a file
  - Example:
    ```csharp
    File.WriteAllText("output.txt", "Hello, World!");
    File.WriteAllLines("output.txt", new string[] {"Line 1", "Line 2"});
    ```
- `File.AppendAllText`, `File.AppendAllLines`: add to the end of a file
  - Example:
    ```csharp
    File.AppendAllText("output.txt", "Another line\n");
    File.AppendAllLines("output.txt", new string[] {"Line 3"});
    ```
- `StreamReader` / `StreamWriter`: read/write line-by-line (with `using` block)
  - Example:
    ```csharp
    using (StreamReader reader = new StreamReader("data.txt"))
    {
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
    ```
- Always wrap file access in `try/catch`
  - Example:
    ```csharp
    try
    {
        string text = File.ReadAllText("missing.txt");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error reading file: " + ex.Message);
    }
    ```

---

**Dialogs (WinForms):**
- OpenFileDialog, SaveFileDialog, ColorDialog, FontDialog, PrintDialog for GUIs
- How to use, get results, basic error handling

---

**Path Handling:**
- Use `Path.Combine` to avoid “it works on my computer but not theirs” syndrome
  - Example:
    ```csharp
    string fullPath = Path.Combine("folder", "file.txt");
    ```

---

**Demo Only (Save for Advanced):**
- Binary file read/write (`File.ReadAllBytes`, `File.WriteAllBytes`)
- Random access with `FileStream` and `Seek`
- Serialization (JSON, XML), async file I/O, FileSystemWatcher

---

**Why it Matters:**
- Reading/writing files = saving/loading data, config, user input
- 99% of practical programming touches a file at some point

---

**Practical:**
- Practice reading and writing text files using the examples above.
- Try using `try/catch` to handle file errors.
- Experiment with file paths using `Path.Combine`.
- Use dialogs in WinForms to open and save files.

---

## References
- [C# Programming Guide: File I/O](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-and-write-to-a-text-file/)
- [C# Programming Guide: Streams](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-and-write-to-a-file-by-using-streams/)
- [C# Programming Guide: Path Class](https://learn.microsoft.com/en-us/dotnet/api/system.io.path)
- [C# Coding Conventions](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions)
- [StyleGuide/CodeFormatting.md](../StyleGuide/CodeFormatting.md)
- [Topics/dotnet_documentation_links.md](dotnet_documentation_links.md)

