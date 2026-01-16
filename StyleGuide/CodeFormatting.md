# Code Formatting

Consistency and clarity in code make it easier to read and maintain. This section covers the basics of formatting in C#: braces, line breaks, blank lines, and line length. Good formatting makes your code easier to follow at a glance.

---

* **Braces on New Lines (Allman Style):** Always put opening `{` and closing `}` braces on their own lines, aligned with the current indentation level. This style clearly separates blocks of code. For example, an `if` statement’s brace should be on a new line below the `if` condition.
  ```csharp
  if (x > 0)
  {
      Console.WriteLine("Positive");
  }
  else
  {
      Console.WriteLine("Non-positive");
  }
  ```

---

* **Always Use Braces:** Even if an `if` or loop has a single statement, include the braces. This prevents errors if someone later adds another line inside the block.
  ```csharp
  if (isReady)
  {
      StartProcess();
  }
  // Good: braces used even for single statement
  ```

---

* **One Statement Per Line:** Don’t pack multiple statements on one line. Each statement (like a declaration or an expression) goes on its own line. This improves readability and makes diffs cleaner.
  ```csharp
  int count = 5;
  string name = "Alice";
  Console.WriteLine(name);
  // Good: each statement on its own line
  ```

---

* **One Declaration Per Line:** Similarly, declare only one variable per line (with a type). This way each declaration stands out.
  ```csharp
  int a = 1;
  int b = 2;
  // Good: one variable declared per line
  ```

---

* **Blank Lines Between Blocks:** Use blank lines to separate logical sections of your code. For example, add an empty line between methods, between property definitions, or before a new logical section in a method. Avoid excessive blank lines – usually one blank line is enough to separate sections.
  ```csharp
  void ProcessData()
  {
      // ...
  }

  void PrintResults()
  {
      // ...
  }
  // Good: blank line separates methods
  ```

---

* **Reasonable Line Length:** Avoid very long lines of code. A common guideline is to keep lines under ~120 characters for better readability. If a line is too long, break it into multiple lines.
  ```csharp
  string message = "This is a short line."; // Good: under 120 characters
  // If a line is too long, break it up:
  string longText = "This is a very long string that should be split " +
      "across multiple lines for readability.";
  ```

---

* **Break Long Expressions Clearly:** If you break a long expression or statement into multiple lines, do so at natural breakpoints. It’s often recommended to break *before* an operator, so the operator sits at the start of the new line. This makes it clear the line is a continuation of the previous one. Also indent the continuation line (usually by one additional indent).
  ```csharp
  int result = a +
      b +
      c;
  // Good: break before operator, indent continuation
  ```

---

* **Use Parentheses for Clarity:** When an expression has multiple conditions or operations, use parentheses to group and clarify order of evaluation. This isn’t always required by the compiler, but it helps humans understand the logic.
  ```csharp
  if ((a > 0 && b > 0) || (c == 10))
  {
      // ...
  }
  // Good: parentheses clarify order of evaluation
  ```

---
