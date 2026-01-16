# Indentation and Spacing

Indentation organizes code into a visual hierarchy, and spacing (spaces between characters) makes individual statements easier to read. Consistent indentation and spacing are crucial for readability.

---

* **Use 4 Spaces for Indents:**
  Indent your code blocks by **4 spaces** per level (this is the default in Visual Studio). Do **not** use tab characters for indentation – configure your editor to insert spaces if you press the Tab key. This ensures code looks the same in all environments.
  ```csharp
  if (isReady)
  {
      StartProcess();
  }
  // Good: indented 4 spaces inside the block
  ```

---

* **Indent Blocks and Continuation Lines:**
  Whenever you open a block (after an `{`), increase the indent for the code inside. When the block ends (`}`), decrease the indent back. If a statement wraps to a new line (for example, a long LINQ query or function call), indent the continuation line an extra 4 spaces so it's clear it’s part of the previous line. This applies universally to all wrapped lines.
  ```csharp
  if (a > 1000 &&
      b > 1000 &&
      (c % 2 == 0))
  {
      Console.WriteLine("Large even numbers");
  }

  var result = myFunction(
      param1, param2, param3);
  // Good: continuation lines indented
  ```

---

* **No Mixed Indentation:**
  Never mix tabs and spaces. Use spaces consistently to avoid misaligned code in different editors.
  ```csharp
  // Good: only spaces used for indentation, no tabs
  int value = 10;
  ```

---

* **Space After Keywords:**
  Put a space between control flow keywords and the following parenthesis. For example, write `if (` not `if(`, and `while (` not `while(`. This tiny space improves readability.
  ```csharp
  if (x == 10)
  {
      // ...
  }
  // Good: space after 'if'
  ```

---

* **No Space After Method Names:**
  Unlike keywords, do **not** put a space between a function name and its parentheses. For example, use `ComputeSum()` not `ComputeSum ()`.
  ```csharp
  ComputeSum(); // Good: no space between method name and parentheses
  ```

---

* **Spaces Around Operators:**
  Surround binary operators with a single space on each side for readability. For instance, use `x + y` instead of `x+y`, and `i < 10` instead of `i<10`. Spaces make it clear what the operands are. An exception is unary operators (like the `!` in `!flag` or a type cast) – no space is needed there.
  ```csharp
  int sum = a + b + c; // Good: spaces around '+'
  int negative = -x; // No space for unary minus
  bool isNotReady = !isReady; // No space for logical NOT
  ```

---

* **Space After Commas:**
  In argument lists, array initializers, or enums, put a space after each comma. Example: `Console.WriteLine(firstName, lastName)` should be written as `Console.WriteLine(firstName, lastName)`. This helps separate items in a list.
  ```csharp
  Console.WriteLine(firstName, lastName); // Good: space after comma
  ```

---

* **No Extra Spaces Inside Parentheses/Brackets:**
  Don’t pad inside parentheses or square brackets. For example, write `if (x == 10)` not `if ( x == 10 )`, and `int[] nums = new int[5]` not `int[ ] nums = new int [ 5 ]`. The only time you might see a space inside parentheses is for type casts, e.g. `(int)x`, which is fine (no space after the `(` or before the `)`).
  ```csharp
  if (x == 10)
  {
      // ...
  }
  int[] nums = new int[5]; // Good: no extra spaces inside brackets
  ```

---

* **No Trailing Whitespace:**
  Avoid leaving spaces at the end of a line. It’s invisible and can cause noise in diffs. Most editors can trim this automatically.
  ```csharp
  int value = 10; // Good: no spaces at end of line
  ```

---

* **Align Multiline Parameters/Arguments:**
  If you break a long parameter list or argument list onto multiple lines, indent the subsequent lines once. Multiple styles are acceptable as long as they are consistent.
  ```csharp
  void PrintDetails(
      string name,
      int age,
      string address)
  {
      // ...
  }
  // Good: subsequent lines indented
  ```

---
