# Naming Conventions

Using consistent naming conventions in your code makes it intuitive and self-documenting. C# and .NET have well-established naming guidelines (part of the Framework Design Guidelines). Here are the key rules:

---

* **PascalCase for Types and Public Members:** Use PascalCase (also known as **Pascal Casing**) for **classes**, **interfaces**, **structs**, **enums**, **delegates**, and **public members** (methods, properties, events). In PascalCase, each word is capitalized with no separators (e.g. `CustomerAccount`, `CalculateTotal`). For interfaces, always start the name with an **`I`** (e.g. `IStream`, `ILogger`) to indicate it’s an interface. For attribute classes, end the name with **`Attribute`** (e.g. `SerializableAttribute`) by convention. Enum type names are PascalCase; use a **singular** name for normal enums (e.g. `Color`), and a **plural** name for flags enums that allow combination of values (e.g. `FileAccessModes`).

  ```csharp
  public class StudentAccount {}
  public int TotalAmount { get; set; }
  public void CalculateTotal() {}
  // Good: PascalCase for types, properties, methods
  ```

---

* **camelCase for Locals and Parameters:** Use camelCase for **variables**, **fields**, and **parameters** that are not public. In camelCase, the first letter is lowercase and following words are capitalized (e.g. `firstName`, `totalAmount`). Method parameters and local variables are typically camelCase. This rule helps distinguish local variables from Types, which start with capital letters.

  ```csharp
  int totalScore;
  string firstName;
  void PrintName(string userName) {}
  // Good: camelCase for variables and parameters
  ```

---

* **Private Fields:** For private member fields inside classes, use camelCase **with a leading underscore** `_` by convention. Example: `_currentIndex` or `_logger`. This clearly differentiates fields from local variables in code. (Some teams omit the underscore, but the .NET Runtime style uses it, so we’ll use it here.)

  ```csharp
  private int _currentIndex;
  private string _logger;
  // Good: leading underscore for private fields
  ```

---

* **Static Fields:** A common convention (used in the .NET runtime) is to prefix private **static** fields with `s_` and thread-static fields with `t_`. For example: `private static int s_cacheSize;`. This prefix is not required by the language, but it follows the pattern that static members are prefixed differently. If you find it confusing, you can omit the `s_` prefix, but be consistent.

  ```csharp
  private static int s_cacheSize;
  // Good: s_ prefix for static fields
  ```

---

* **Constants:** For `const` values or `readonly` static fields, use ALL_CAPS (e.g. `MAX_RETRIES`, `DEFAULT_TIMEOUT`). This makes constants stand out and is the required convention for this course.

  ```csharp
  private const int MAX_RETRIES = 5;
  private const string DEFAULT_TIMEOUT = "30s";
  // Good: ALL_CAPS for constants
  ```

---

* **Meaningful Names:** Choose clear, descriptive names that indicate the purpose of the variable or method. For example, `GetCustomerOrders` is more informative than `GetData`. Avoid vague names like `Tmp`, `Data`, or `Value` that don’t convey intent. A good name reduces the need for comments.

  ```csharp
  int totalAmount;
  string customerName;
  // Good: descriptive names
  ```

---

* **Avoid Abbreviations:** Don’t abbreviate words arbitrarily. For instance, use `ComputeAverage`, not `CompAvg`. Only use acronyms or abbreviations that are widely known and accepted (e.g. `HTML`, `Id` for identifier, `Http`). When using acronyms in PascalCase, capitalize them normally (e.g. `XmlParser`, not `XMLParser`, except two-letter acronyms can be all caps like `IOStream` – but this is an advanced nuance). When in doubt, just treat the acronym as a word (e.g. `JsonWriter`).

  ```csharp
  int computeAverage;
  // Good: no abbreviations
  ```

---

* **Booleans as Questions:** Name boolean variables and properties like a question or affirmative statement. Common prefixes are `is`, `has`, `can`, `should` (e.g. `isFinished`, `hasItems`, `canExecute`). This makes it clear that the value represents a true/false condition.

  ```csharp
  bool isFinished;
  bool hasItems;
  // Good: booleans as questions
  ```

---

* **No Hungarians or Prefixes for Scope:** Do not add prefixes like `tbl_` or `m_` or Hungarian notation (encoding type in the name, e.g. `strName` for string). C# code should be clean of type or scope prefixes – the type system and good naming make that information clear. The only prefix in common use is `I` for interfaces as mentioned, and `_` for private fields.

  ```csharp
  int value;
  // Good: no type or scope prefixes
  ```

---

* **Avoid Single Letter Names:** Single-letter variables (like `x` or `i`) should generally only be used for *very short-lived loop indices* or similar tiny scopes. Even then, prefer `i`, `j` for loop counters rather than something like `a` or `b` which may be less clear. For anything that carries meaning or is used outside a few lines, use a descriptive name. (One exception: in LINQ expressions or lambda expressions, single-letter like `x` is sometimes used for a generic object, but you can still choose a meaningful name in those contexts for clarity.)

  ```csharp
  for (int i = 0; i < 10; i++) {}
  // Good: single-letter only for short-lived loop indices
  ```

---

* **Consistent Naming:** Don’t use names that differ only in capitalization in the same context. C# is case-sensitive, but having `product` and `Product` as separate variables is confusing. Also avoid names that sound too similar.

  ```csharp
  int productCount;
  int productTotal;
  // Good: names are distinct and clear
  ```

---

* **Namespaces and Assemblies:** This is more advanced, but if you create namespaces, use PascalCase and typically a dot-separated hierarchy (often starting with your company or project name). Example: `MyProject.Services.Logging`. Assembly names (project names) should also be PascalCase and reflect the content (e.g. `MyProject.Utilities`).

  ```csharp
  namespace MyProject.Services.Logging;
  // Good: PascalCase, dot-separated hierarchy
  ```

---

Here are some examples of good and bad naming:

**Good Example:** Descriptive, conventional names

```csharp
public class OrderProcessor    // Class in PascalCase
{
    private readonly int MAX_ORDER_SIZE = 100;   // Private constant field in ALL_CAPS

    private int _currentCount;   // Private field with underscore in camelCase

    public int CurrentCount     // Public property in PascalCase
    {
        get { return _currentCount; }
    }

    public void ProcessOrder(string customerName, int itemCount)   // Method in PascalCase, parameters in camelCase
    {
        bool isValid = itemCount <= MAX_ORDER_SIZE;   // Boolean variable as question (isValid)
        if (!isValid)
        {
            Console.WriteLine($"Order too large for {customerName}");
        }
        // ...
    }
}

interface IShape    // Interface with 'I' prefix
{
    void Draw();
}
```

**Bad Example:** Unclear or unconventional names

```csharp
public class order_processor   // Bad: uses snake_case or lower-case, not PascalCase
{
    private int currentCount;   // Bad: private field not prefixed with _ (in this convention guide)
    private static int cacheSize;   // Bad: static field without s_ prefix (if following that convention)

    public int curCnt   // Bad: unclear abbreviation, not PascalCase
    {
        get { return currentCount; }
    }

    public void Process_Order(string CustomerName, int ItemCount)   // Bad: underscores in name, parameters should be camelCase
    {
        bool valid = ItemCount <= 100;   // Bad: boolean not clearly named (could be isValid), parameter name capitalized wrongly
        if (!valid)
        {
            Console.WriteLine($"Order too large for {CustomerName}");
        }
    }
}

class shapeInterface { }   // Bad: interface without 'I' prefix and not PascalCase
```

In the bad example, the naming is inconsistent and non-standard: class name is not in PascalCase, `_` is missing on the private field, abbreviations like `curCnt` are used, and parameter naming is wrong. Following the **Good** naming conventions makes the code far more understandable at a glance.
