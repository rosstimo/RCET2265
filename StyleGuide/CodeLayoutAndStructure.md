# Code Layout and Structure

Code layout refers to how you organize your code within files and projects. A consistent structure helps others (and your future self) navigate the code. Here are guidelines for organizing C# code:

---

* **One Type per File:**
  ```csharp
  // File: Student.cs
  public class Student {}
  // Good: one public type per file
  ```

---

* **Order of Members:**
  ```csharp
  public class Product
  {
      private int _id;
      public string Name { get; set; }
      public Product(string name) { Name = name; }
      public void PrintDetails() { Console.WriteLine(Name); }
      // Good: fields, properties, constructor, methods in order
  }
  ```

---

* **Consistent Access Modifiers:**
  ```csharp
  public class MyClass
  {
      public void DoWork() {}
      private void Helper() {}
      // Good: public before private
  }
  ```

---

* **Always Specify Access Level:**
  ```csharp
  public class MyClass {}
  private int _value;
  // Good: explicit access modifiers
  ```

---

* **Keep Methods Focused:**
  ```csharp
  public void PrintName(string name)
  {
      Console.WriteLine(name);
  }
  // Good: method does one thing
  ```

---

* **Use Regions Sparingly:**
  ```csharp
  // #region Helper Methods
  // ...
  // #endregion
  // Good: only use regions when truly helpful
  ```

---

* **Spacing in Code Structure:**
  ```csharp
  void PrepareData() {}

  void ProcessData() {}
  // Good: blank line between methods
  ```

---

* **Project Structure:**
  ```csharp
  // Folder: Models/
  // File: Product.cs
  namespace MyApp.Models;
  public class Product {}
  // Good: files and folders mirror namespaces
  ```

---

* **File-Scoped Namespace:**
  ```csharp
  namespace MyApp.Models;
  // Good: file-scoped namespace at top
  ```

---

**Good Example:** Each public type in its own file, clear member ordering
*File: `Product.cs`*

```csharp
namespace MyStore.Models;

public class Product
{
    // Fields (private) at top
    private static int s_totalProducts = 0;   // static field
    private readonly int _id;                // instance field

    // Properties
    public int Id => _id;
    public string Name { get; set; }

    // Constructor
    public Product(string name)
    {
        _id = ++s_totalProducts;
        Name = name;
    }

    // Public method
    public void PrintDetails()
    {
        Console.WriteLine($"Product {_id}: {Name}");
    }

    // Private helper method (grouped at bottom)
    private string GetLabel() 
    {
        return $"ID={_id}, Name={Name}";
    }
}
```

*File: `Order.cs`*

```csharp
namespace MyStore.Models;

public class Order
{
    // ... definition of Order class ...
}
```

In the good example, `Product` and `Order` are in separate files, making each file focused. Inside `Product`, members are organized clearly: fields, then properties, then constructor, then methods. This structure is easy to navigate and maintain.

**Bad Example:** Multiple classes in one file, disorganized members
*File: `Stuff.cs`*

```csharp
namespace MyStore.Models;

public class Product 
{
    public string Name;
    private int _id;
    public Product(string name) { Name = name; }
    public void PrintDetails() { Console.WriteLine($"Product {_id}: {Name}"); }
    // Bad: Fields, constructor, and methods are mixed without clear order
}

public class Order 
{
    public Product[] items;
    public int total;
    // ... (class continues) ...
}
public class OrderManager 
{
    // Three public classes in one file – bad practice, each should be separate.
}
```

*File: `Mixed.cs`*

```csharp
public class Mixed
{
    public int Data;
    private string GetData() { return Data.ToString(); }
    public string Info;
    // Bad: Member order is nonsensical; fields and methods interleaved,
    // and the class is doing too many things perhaps.
    // Also no access modifier on class (defaults to internal, but should be stated).
}
```

In the bad examples, multiple classes share one file (making it hard to locate `Order` or `OrderManager` quickly), and the members inside classes are not in a logical order. Following the good practices helps ensure each file and class has a clear purpose and structure.
