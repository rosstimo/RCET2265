# Commenting

Comments are an important part of code, but they should be used wisely. The goal is to write code that is mostly self-explanatory, using comments to clarify intent or important details. Here are best practices for commenting in C#:

---

* **Use `//` for Brief Comments:**
  For short explanations or notes, use single-line comments that start with `//`. Place the comment on its own line above the code it describes (or at least on a separate line). This makes it stand out.
  ```csharp
  // This method prints a greeting to the user.
  void PrintGreeting() {}
  // Good: comment above code, short and clear
  ```

---

* **Avoid Block Comments (`/* ... */`):**
  The C-style `/* multi-line */` comments can technically span multiple lines, but they are less common in C# coding. It’s usually clearer to use multiple `//` lines for long comments. Block comments can also accidentally comment out code if not used carefully. Reserve them for temporarily disabling code (debugging) or for specifically formatting a comment, but generally prefer `//`.
  ```csharp
  // Good: use multiple // lines for longer comments
  // This section initializes the cache.
  // It must be done before any data is loaded.
  ```

---

* **Comment the Why, Not the What:**
  This is crucial. Don’t write comments that simply restate what the code does – the code itself shows that. Instead, comment **why** something is done, or any context that’s not obvious from the code.
  ```csharp
  // Move to the next index (not just increment)
  i++;
  // Good: explains intent
  ```

---

* **Keep Comments Relevant and Updated:**
  A bad (and common) practice is leaving outdated comments that no longer match the code. Always update or remove comments if the code changes. Stale comments can mislead readers more than no comment.
  ```csharp
  // Good: update or remove comments if code changes
  // This method now uses a dictionary for fast lookup.
  ```

---

* **XML Documentation Comments for Public APIs:**
  When you have public classes or public methods in libraries or larger projects, use XML comments (`/// <summary> ... </summary>`) to document their purpose. These comments appear in IntelliSense and official docs. For a beginner learning in small projects, you might not use these heavily, but it’s good to know the convention.
  ```csharp
  /// <summary>
  /// Calculates the average of an array of numbers.
  /// </summary>
  public double CalculateAverage(int[] numbers) { ... }
  // Good: XML comments for public APIs
  ```

---

* **Style of Comments:**
  When writing sentence-style comments, start with a capital letter and end with a period. Example: `// Validate input parameters.`. This gives comments a consistent, professional style. Also, put a single space after the `//` before the text starts (the IDE usually does this by default when you start a `//` comment).
  ```csharp
  // Validate input parameters.
  // Good: sentence-style, capital letter, period
  ```

---

* **Don’t Postpone with Comments:**
  Avoid leaving “to-do” or “fix me” notes in comments for long periods. It’s okay to jot a short-term `// TODO: handle error cases` as a reminder, but don’t let these accumulate and become permanent. They’re not actually informing the reader about the current code’s function; they’re just notes. If something needs fixing, create a work item or fix it soon.
  ```csharp
  // TODO: handle error cases
  // Good: short-term reminder, not permanent
  ```

---

* **No Commented-Out Code in Releases:**
  If you need to remove code, remove it rather than commenting it out, especially in committed code. Source control history is a better way to retrieve old code when needed. Large blocks of commented-out code in a file can be confusing and cluttering.
  ```csharp
  // Good: remove code instead of commenting it out
  // (no example needed)
  ```

---

* **Frequency of Comments:**
  You do **not** need a comment on every line. Well-named variables and methods reduce the need for many comments. A common beginner mistake is over-commenting trivial code. Aim for self-documenting code and use comments to clarify **why** something is done or to highlight important details or tricky parts of the code.
  ```csharp
  // Only comment when needed for clarity
  int sum = a + b; // No comment needed here
  ```

---

## Commenting in Beginner Assignments

For small, beginner-level assignments (like early calculator projects), it's common for all logic to be in the `Main` method and for code to be very linear. In these cases, well-named variables and clear structure are often enough, and only a few comments are needed to explain the overall flow or any non-obvious logic. Don't feel pressured to comment every line. Instead focus on clarity and intent. As you learn more advanced features (like methods, classes, or more complex logic), your commenting style will naturally evolve to include more context and documentation where needed.

---

Following these conventions will make your C# code clean, professional, and easy for others (and you!) to understand. At first it’s a lot to remember, but over time it becomes second nature. Consistent style is about communication – your code should clearly convey its purpose without requiring guesswork. Stick to these guidelines, and you'll be writing C# code that looks like the work of an experienced developer, even if you’re just starting out. Happy coding!
