# C# Project Structure, File Naming, and Folder Organization

A sloppy folder/project setup turns good code into an unholy mess. Don’t be that person. Here’s how to organize your C# project like a pro (and keep your future self from rage-quitting):

---

## File Naming

* **Class Files:**

  * Each public class, interface, struct, or enum goes in its own file.
  * File name **must** match the class/interface/struct/enum name. `OrderProcessor.cs` contains `OrderProcessor`. If you rename the class, rename the file.

  **Good:**

  ```csharp
  // In file: InvoiceManager.cs
  public class InvoiceManager { ... }
  ```

  **Bad:**

  ```csharp
  // In file: Utility.cs
  public class DatabaseHelper { ... } // WTF, file name and class name don't match
  ```

* **Private/Helper Classes:**

  * If a class is private and only used inside one file, it can live with the public class. Never more than one public type per file.

  **Good:**

  ```csharp
  // In file: Foo.cs
  public class Foo { ... }
  internal class FooHelper { ... }
  ```

  **Bad:**

  ```csharp
  // In file: Foo.cs
  public class Foo { ... }
  public class Bar { ... } // Bad: multiple public classes in one file
  ```

---

## Folder Organization

* **Folders Mirror Namespaces:**

  * Folder structure should match your C# namespaces. If your namespace is `MyApp.Models`, then the file should be in the `Models` folder.

  **Good:**

  ```shell
  /Models/Customer.cs  --> namespace MyApp.Models;
  /Services/OrderService.cs  --> namespace MyApp.Services;
  ```

  **Bad:**

  ```shell
  /Customer.cs         // No folder, global namespace? That’s chaos.
  /OrderService.cs     // Just dumped at root? Nope.
  ```

* **Group by Feature or Layer:**

  * Organize files by what they do (feature or layer), not just type. Put all stuff related to orders in `/Orders/`, all data models in `/Models/`, etc.

  **Good:**

  ```shell
  /Orders/Order.cs
  /Orders/OrderManager.cs
  /Models/Customer.cs
  ```

  **Bad:**

  ```shell
  /Classes/Order.cs   // 'Classes' means nothing
  /DataStuff/Customer.cs // 'DataStuff' isn’t a real layer
  ```

---

## Solution & Project Naming

* **Solution (.sln) Name:**

  * Should match the main product/app name, in PascalCase. Example: `InventoryManager.sln` for the InventoryManager app.

* **Project (.csproj) Name:**

  * Project name matches the primary namespace and folder. Example: `/DataAccess/DataAccess.csproj`.
  * Don’t use spaces or underscores. Always PascalCase.

  **Good:**

  ```shell
  InventoryManager.sln
  /DataAccess/DataAccess.csproj
  /WebApp/WebApp.csproj
  ```

  **Bad:**

  ```shell
  Inventory Manager.sln   // Spaces are a no
  /data_access/data_access.csproj   // all lowercase, underscores, ugly
  ```

---

## Example Layout

```
MyApp.sln
MyApp/
├── Models/
│   ├── Customer.cs
│   └── Product.cs
├── Orders/
│   ├── Order.cs
│   └── OrderManager.cs
├── Services/
│   ├── EmailService.cs
│   └── OrderService.cs
├── WebApp/
│   └── WebApp.csproj
├── DataAccess/
│   └── DataAccess.csproj
```

* Every file and folder tells you what it’s for.
* No duplicate names, no dumping ground folders.
* If you look at the structure and have to ask “what’s in here?” — rename it.

---

## C# Project Structure

Project structure is about organizing your files and folders so your codebase is easy to navigate and maintain.

---

* **One Public Type per File:**
  ```csharp
  // File: Customer.cs
  public class Customer {}
  // Good: one public type per file
  ```

---

* **Folders Mirror Namespaces:**
  ```csharp
  // Folder: Models/
  // File: Product.cs
  namespace MyApp.Models;
  public class Product {}
  // Good: folder and namespace match
  ```

---

* **PascalCase for Files and Folders:**
  ```csharp
  // Folder: Services/
  // File: OrderManager.cs
  // Good: PascalCase for names
  ```

---

* **No Spaces or Underscores in Names:**
  ```csharp
  // Good: use PascalCase, no spaces or underscores
  // File: OrderHistory.cs
  ```

---

* **Plural Folder Names for Collections:**
  ```csharp
  // Folder: Models/
  // Good: plural for collections
  ```

---

* **Avoid Dumping Files at Root:**
  ```csharp
  // Good: organize files into folders by feature
  // (no example needed)
  ```

---

**Summary:**

* One public type per file, file name matches the type.
* Folders mirror namespaces. No root file dumping.
* Projects and solutions are PascalCase, no spaces or underscores.
* Organize by what things *do*, not just what they *are*.

Follow this and your codebase won’t look like a crime scene. Your teammates will thank you. So will your future self.
